import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms'; 
import { HttpClientModule } from '@angular/common/http'; 
import { SimulationComponent } from './simulation/simulation.component';

import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent,
    SimulationComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule, 
    HttpClientModule, 
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule { }
