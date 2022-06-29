import { HttpClient } from "@angular/common/http";
import { Component, Inject } from "@angular/core";
import { Colaboradores } from "./colaboradores";

@Component({
  selector: 'colaboradores', 
  templateUrl: './colaboradores.component.html'
})

export class ColaboradoresComponent {
  public colaboradores: Colaboradores[] = [];
  
  private _http: HttpClient;
  private _baseUrl: string;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this._http = http;
    this._baseUrl = baseUrl;
  }

  public getList() {
    this._http.get<Colaboradores[]>(this._baseUrl + 'api/colaboradores').subscribe(result => {
      this.colaboradores = result;
    }, error => console.log(error));
  }

}


