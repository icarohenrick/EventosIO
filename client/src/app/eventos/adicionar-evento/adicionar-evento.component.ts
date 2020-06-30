import { Component, OnInit, AfterViewInit, ViewChildren, ElementRef } from '@angular/core';
import { FormGroup, FormBuilder, Validators, FormControlName, FormControl } from '@angular/forms';
import { Router } from '@angular/router';

import { Observable, fromEvent, merge, Subscription } from 'rxjs';

import { ToastrService } from 'ngx-toastr';

import { GenericValidator } from 'src/app/utils/genericValidator';

import { Evento, Categoria, Endereco } from '../models/evento';
import { EventoService } from '../services/evento.service';
import { DateUtils } from 'src/app/utils/date.type';
import { CurrencyUtils } from 'src/app/utils/currency.type';

@Component({
  selector: 'app-adicionar-evento',
  templateUrl: './adicionar-evento.component.html'
})

export class AdicionarEventoComponent implements OnInit, AfterViewInit {

  @ViewChildren(FormControlName, { read: ElementRef }) formInputElements: ElementRef[];

  public myDatePickerOptions = DateUtils.getMyDatePickerOptions();

  public errors: any[] = [];
  public eventoForm: FormGroup;
  public evento: Evento;
  public categorias: Categoria[];
  public gratuito: boolean = false;
  public online: boolean = false;

  displayMessage: { [key: string]: string } = {};
  validationMessages: { [key: string]: { [key: string] : string } };
  genericValidator: GenericValidator;

  constructor(private fb: FormBuilder,
    private router: Router,
    private toastr: ToastrService,
    private eventoService: EventoService) {

    this.validationMessages = {
      nome: {
        required: 'O Nome é requerido',
        minlength: 'O Nome precisa ter no mínimo 2 caracteres',
        maxlength: 'O Nome precisa ter no máximo 150 caracteres'
      },
      dataInicio: {
        required: 'Informe a Data de Início do Evento'
      },
      dataFim: {
        required: 'Informe a Data de Encerramento do Evento'
      },
      categoriaId: {
        required: 'Escolha uma categoria'
      },
      logradouro: {
        maxlength: 'O Nome precisa ter no máximo 150 caracteres'
      }
    }

    this.genericValidator = new GenericValidator(this.validationMessages);
    this.evento = new Evento();
    this.evento.endereco = new Endereco();
  }

  ngOnInit() {

    this.eventoForm = this.fb.group({
      nome: ['', [Validators.required, Validators.maxLength(150), Validators.minLength(2)]],
      categoriaId: ['', Validators.required],
      descricaoCurta: '',
      descricaoLonga: '',
      dataInicio: ['', Validators.required],
      dataFim: ['', Validators.required],
      gratuito:'',
      valor:'0',
      online:'',
      nomeEmpresa:'',
      logradouro:['', Validators.maxLength(20)],
      numero:'',
      complemento:'',
      bairro:'',
      cep:'',
      cidade:'',
      estado:''
    }); 

    this.eventoService.obterCategorias()
    .subscribe(
      categorias => this.categorias = categorias,
      fail => this.errors = fail.error.errors
    );
  }

  ngAfterViewInit(): void{
    let controlBlurs: Observable<any>[] = this.formInputElements
    .map((formControl: ElementRef) => fromEvent(formControl.nativeElement, 'blur'));

    merge(...controlBlurs).subscribe(value => {
      this.displayMessage = this.genericValidator.processMessages(this.eventoForm);
    });
  }

  adicionarEvento(){ 
    if(this.eventoForm.valid && this.eventoForm.dirty){
      let e = Object.assign({}, this.evento, this.eventoForm.value);
      let user = JSON.parse(this.eventoService.getUser());

      e.organizadorId = user.id;
      
      e.dataInicio = DateUtils.getMyDatePickerDate(e.dataInicio);
      e.dataFim = DateUtils.getMyDatePickerDate(e.dataFim);

      e.valor = CurrencyUtils.ToDecimal(e.valor);
     

      e.endereco.logradouro = e.logradouro;
      e.endereco.numero = e.numero;
      e.endereco.complemento = e.complemento;
      e.endereco.bairro = e.bairro;
      e.endereco.cep = e.cep;
      e.endereco.cidade = e.cidade;
      e.endereco.estado = e.estado;

      this.eventoService.registrarEvento(e)
        .subscribe(
          result => { this.onSaveComplete() },
          fail => { this.onError(fail) }
        );
    }
  }

  onError(fail: any){
    this.toastr.error('Ocorreu um erro no processamento!", "Ops! :(');
    this.errors = fail.error.errors;
  }

  onSaveComplete(){

    this.eventoForm.reset();
    this.errors = [];

    const toast = this.toastr.success('Evento registrado com Sucesso!', 'Oba! :D');
    if(toast){
      toast.onHidden.subscribe(() => {
        this.router.navigate(['/eventos/meus-eventos']);
      });
    }
  }
}



 
