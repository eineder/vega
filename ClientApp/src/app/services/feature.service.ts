import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class FeatureService {

  constructor(private httpClient: HttpClient) { }

  getFeatures(): Observable<any[]>  {
      return this.httpClient.get<any[]>('/api/features');
  }
}
