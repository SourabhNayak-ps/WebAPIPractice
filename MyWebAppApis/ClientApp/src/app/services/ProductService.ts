import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Category } from 'src/app/models/Category';
import { ApiUrl } from 'src/app/helpers/urls';

@Injectable({
    providedIn: 'root',
  })
export class ProductService {
    constructor(private http: HttpClient) {}
  
    fetchCategoryList(): Observable<Category[]> {
      let url = ApiUrl.GetCategoryListUrl();
      return this.http.get<Category[]>(url);
    }
  
    fetchCategoryById(id: number): Observable<Category> {
      let url = ApiUrl.GetCategoryDetailUrl(id);
      return this.http.get<Category>(url);
    }
}
  
