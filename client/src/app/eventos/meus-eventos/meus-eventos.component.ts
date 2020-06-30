import { Component, OnInit } from '@angular/core';

import { Evento } from '../models/evento';
import { EventoService } from '../services/evento.service';

@Component({
  selector: 'app-meus-eventos',
  templateUrl: './meus-eventos.component.html',
  styleUrls: ['./meus-eventos.component.css']
})
export class MeusEventosComponent implements OnInit {

  public eventos: Evento[];
  errorMessage: string;

  constructor(private eventosService: EventoService) {}

  ngOnInit(): void {
    this.eventosService.obterMeusEventos()
    .subscribe(
      eventos => this.eventos = eventos,
      error => this.errorMessage
    );
  }

}
