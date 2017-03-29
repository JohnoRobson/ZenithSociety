import { Component } from '@angular/core';
import { Headers, Http, RequestOptions } from '@angular/http';
import { TokenService } from './token.service';

@Component({
  selector: 'login',
  templateUrl: './login.component.html'
})

export class LoginComponent {
  private URL = 'http://zenith-society-nj-core.azurewebsites.net/connect/token/';

  constructor(private http: Http, private tokenService: TokenService) {}

  username: string;
  password: string;

  onSubmit() { this.login(this.username, this.password) }
  login(username: string, password: string) {
      let creds = 'username='+username+'&password='+password+'&grant_type=password'
       let headers = new Headers({ 'Content-Type': 'application/x-www-form-urlencoded' });
       let options = new RequestOptions({ headers: headers });
        return this.http.post(this.URL, creds, options)
            .toPromise()
            .then(r => {
                
                let user = r.json();
                this.tokenService.setToken(user["access_token"]);
            });
    }
}