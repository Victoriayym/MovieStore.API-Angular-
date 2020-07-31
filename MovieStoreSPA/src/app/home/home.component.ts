import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

}
//its a super set of JS, its strongly typed like C#; Java
//Angular cli will transiple TypeScript to Javascript and send it to browser
//ASP.NET converts your razor syntax to HTML/JS, similar concept
//ctrl +p, search files in project
//ctrl +shift+search VS Code
//crtl+/for commenting /uncommenting
//crtl+f search for text inside the file
//ctrl+shift+f: global search
