import { Component } from '@angular/core';
import { Headers, Http, RequestOptions } from '@angular/http';
import { TokenService } from './token.service';

@Component({
  selector: 'register',
  templateUrl: './register.component.html'
})

export class RegisterComponent {
    private URL = 'http://zenith-society-nj-core.azurewebsites.net/Account/Register';

    constructor(private http: Http, private tokenService: TokenService) {}

    username: string;
    password: string;
    email: string;
    firstname: string;
    lastname: string;

    onSubmit() { this.register(this.username, this.password, this.email, this.firstname, this.lastname) }
    register(username: string, password: string, email: string, firstname: string, lastname: string) {
      let creds = 'username='+username+'&password='+password+'&confirmpassword='+password+'&email='+email+'&firstname='+firstname+'&lastname='+lastname;
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