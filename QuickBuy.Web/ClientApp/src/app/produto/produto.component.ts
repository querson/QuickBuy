import { Component } from "@angular/core"

@Component({
  selector: "app-produto",
  template: "<html><body> {{ obterNome() }} </body></html>"

})


export class ProdutoComponent {//nome da classe começando com Maiusculo por conta da convenção PascalCase
 /* public id: number;
  public nome: string;
  public preco: number; */

  //camelCase para as variáveis, atributos e nomes das funções
  public nome: string;
  public liberadoParaVenda: boolean;
  
  public obterNome(): string {
    return "Sansung";
  }

}
