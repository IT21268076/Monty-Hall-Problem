import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-simulation',
  templateUrl: './simulation.component.html',
  styleUrls: ['./simulation.component.css']
})
export class SimulationComponent {
  totalGames: number = 1000;
  switchDoor: boolean = true;
  simulationResult: any;

  constructor(private http: HttpClient) {}

  simulateGames() {
    this.http.post<any>('http://localhost:5014/api/montyhall/simulate', { totalGames: this.totalGames, switchDoor: this.switchDoor }).subscribe(
      (result) => {
        this.simulationResult = result;
      },
      (error) => {
        console.error('Simulation request failed:', error);
      }
    );
  }
}
