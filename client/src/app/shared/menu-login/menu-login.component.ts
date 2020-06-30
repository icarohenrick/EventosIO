import { Component, OnInit } from '@angular/core';
import { OrganizadorService } from 'src/app/services/organizador.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-menu-login',
  templateUrl: './menu-login.component.html',
  styleUrls: []
})
export class MenuLoginComponent {

  public user;
  public nome: string = "";

  constructor(private organizadorService: OrganizadorService,
    private router: Router) { }

    usuarioLogado(){
    this.user = JSON.parse(this.organizadorService.getUser());

    if(this.user){
      this.nome = this.user.userName;
    }

    return this.organizadorService.isAuthenticated();
  }

  logout(){
    this.organizadorService.removeUserToken();
    this.router.navigate(['/home']);
  }

}
