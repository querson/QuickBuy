import { Component, OnInit } from '@angular/core';

import { Router } from '@angular/router';
import { UsuarioServico } from '../servicos/usuario/usuario.servico';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent implements OnInit {

  isExpanded = false;

  //constructor(private router: Router, private usuarioServico: UsuarioServico) {

  //}


  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }


  ////public usuarioLogado(): boolean {
  ////  /* var usuarioLogado = sessionStorage.getItem("usuario-autenticado");
  ////   if (usuarioLogado == "1") {
  ////     return true;
  ////   }
  ////   return false;*/
  ////  return this.usuarioServico.usuario_autenticado();
  ////}

  ngOnInit() {
  }

}
