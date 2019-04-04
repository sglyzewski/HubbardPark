import { Component, OnInit } from '@angular/core';
import { DataService } from './data.service';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'where the rubber does not meet the rubber';


constructor(private dataService: DataService) {
}

ngOnInit() {
  this.dataService.getValues().subscribe(value => this.title = value);
}


}
