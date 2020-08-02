import { Router } from '@angular/router';
import { Register } from './../../shared/models/register';
import { SignupService } from './../../core/services/signup.service';
import { Component, OnInit } from '@angular/core';
import {FormBuilder} from '@angular/forms';
@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})
export class SignUpComponent implements OnInit {
signupForm;

  constructor(private signupService:SignupService, private formBuilder: FormBuilder,
    private router:Router) {
    this.signupForm=this.formBuilder.group({
      email:'',
      firstName:'',
      lastName:'',
      password:''
    });
   }
   onSubmit(register:Register){
     this.signupService.RegisterUser(register).subscribe((r)=>{
      this.router.navigate(['login']);
     })
   }

  ngOnInit(): void {
  }

}
