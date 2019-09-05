import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';

import { FormsModule } from '@angular/forms';

//import { enableProdMode } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ProdutoComponent } from './produto/produto.component';
import { UsuarioServico } from './servicos/usuario/usuario.servico';
import { GuardaRotas } from './autorizacao/guarda.rotas';
import { LoginComponent } from './usuario/login/login.component';


//enableProdMode();

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    ProdutoComponent,
    LoginComponent,
    HomeComponent
  ],
  imports: [
   // BrowserModule,
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'entrar', component: LoginComponent },
      { path: 'produto', component: ProdutoComponent }//, canActivate: [GuardaRotas] }
      
      
    ]),
    AppRoutingModule
  ],
  providers: [UsuarioServico],
  bootstrap: [AppComponent],

})

export class AppModule { }
