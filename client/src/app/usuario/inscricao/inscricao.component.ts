import { Component, OnInit, AfterViewInit, ViewChildren, ElementRef } from '@angular/core';
import { FormGroup, FormBuilder, Validators, FormControlName, FormControl } from '@angular/forms';
import { GenericValidator } from 'src/app/utils/genericValidator';
import { Observable, fromEvent, merge } from 'rxjs';
import { CustomValidators } from 'ngx-custom-validators';

import { Organizador } from '../models/organizador';
import { OrganizadorService } from 'src/app/services/organizador.service';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-inscricao',
  templateUrl: './inscricao.component.html'
})
export class InscricaoComponent implements OnInit, AfterViewInit {

  @ViewChildren(FormControlName, { read: ElementRef }) formInputElements: ElementRef[];

  inscricaoForm: FormGroup;
  organizador: Organizador;
  validationMessages: { [key: string]: { [key: string] : string } };
  displayMessage: { [key: string]: string } = {};
  errors: any[] = [];

  genericValidator: GenericValidator;

  constructor(private fb: FormBuilder,
    private organizadorService: OrganizadorService,
    private router: Router,
    private toastr: ToastrService) {

    this.validationMessages = {
      nome: {
        required: 'O Nome é requerido',
        minlength: 'O Nome precisa ter no mínimo 2 caracteres',
        maxlength: 'O Nome precisa ter no máximo 150 caracteres'
      },
      cpf: {
        required: 'Informe o CPF',
        rangeLength: 'O CPF deve conter 11 cacacteres'
      },
      email: {
        required: 'Informe o e-mail',
        email: 'Email invalido'
      },
      password: {
        required: 'Informe a senha',
        minlength: 'O Nome precisa ter no mínimo 6 caracteres'
      },
      confirmPassword: {
        required: 'Informe a senha novamente',
        minlength: 'O Nome precisa ter no mínimo 6 caracteres',
        equalTo: 'As senhas não conferem'
      },
    }

    this.genericValidator = new GenericValidator(this.validationMessages);
  }

  ngOnInit(): void {

    let password = new FormControl('', [Validators.required, Validators.minLength(6)]);
    let confirmPassword = new FormControl('', [Validators.required, Validators.minLength(6), CustomValidators.equalTo(password)]);

    this.inscricaoForm = this.fb.group({
      nome: ['', [Validators.required, Validators.maxLength(150), Validators.minLength(2)]],
      cpf: ['', [Validators.required, CustomValidators.rangeLength([11,11])]],
      email: ['', [Validators.required, CustomValidators.email]],
      password: password,
      confirmPassword: confirmPassword
    }); 
  }

  ngAfterViewInit(){
    let controlBlurs: Observable<any>[] = this.formInputElements
    .map((formControl: ElementRef) => fromEvent(formControl.nativeElement, 'blur'));

    merge(...controlBlurs).subscribe(value => {
      this.displayMessage = this.genericValidator.processMessages(this.inscricaoForm);
    })
  }

  adicionarOrganizador(){ 
    if(this.inscricaoForm.valid && this.inscricaoForm.dirty){

      let org = Object.assign({},this.organizador, this.inscricaoForm.value);
      this.organizadorService.registrarOrganizador(org)
        .subscribe(
          result => {this.onSaveComplete(result)},
          fail => {this.onError(fail)}
        );
    }
  }

  onSaveComplete(response: any){
    this.inscricaoForm.reset();
    this.errors = [];

    this.organizadorService.setLocalStorage(response.access_token, JSON.stringify(response.user));

    let toastrMessage = this.toastr.success("Registro realizado com Sucesso!", "Bem vindo!");
    if(toastrMessage){
      toastrMessage.onHidden.subscribe(() => {
        this.router.navigate(['/home']);
      });
    }
    
  }

  onError(fail: any){
    this.errors = fail.error.errors;

    this.toastr.error("Ocorreu um erro!", "OPS!");
  }
}