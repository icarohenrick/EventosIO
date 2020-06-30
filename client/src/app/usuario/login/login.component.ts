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
  selector: 'app-login',
  templateUrl: './login.component.html'
})

export class LoginComponent implements OnInit, AfterViewInit {

  @ViewChildren(FormControlName, { read: ElementRef }) formInputElements: ElementRef[];

  loginForm: FormGroup;
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
      email: {
        required: 'Informe o e-mail',
        email: 'Email invalido'
      },
      password: {
        required: 'Informe a senha',
        minlength: 'O Nome precisa ter no mínimo 6 caracteres'
      }
    }

    this.genericValidator = new GenericValidator(this.validationMessages);
  }

  ngOnInit(): void {

    let password = new FormControl('', [Validators.required, Validators.minLength(6)]);

    this.loginForm = this.fb.group({
      email: ['', [Validators.required, CustomValidators.email]],
      password: password
    }); 
  }

  ngAfterViewInit(){
    let controlBlurs: Observable<any>[] = this.formInputElements
    .map((formControl: ElementRef) => fromEvent(formControl.nativeElement, 'blur'));

    merge(...controlBlurs).subscribe(value => {
      this.displayMessage = this.genericValidator.processMessages(this.loginForm);
    })
  }

  login(){ 
    if(this.loginForm.valid && this.loginForm.dirty){

      let org = Object.assign({},this.organizador, this.loginForm.value);
      this.organizadorService.login(org)
        .subscribe(
          result => {this.onSaveComplete(result)},
          fail => {this.onError(fail)}
        );
    }
  }

  onSaveComplete(response: any){
    this.loginForm.reset();
    this.errors = [];

    this.organizadorService.setLocalStorage(response.access_token, JSON.stringify(response.user));

    let toastrMessage = this.toastr.success("Login realizado com Sucesso!", "Bem vindo!");
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