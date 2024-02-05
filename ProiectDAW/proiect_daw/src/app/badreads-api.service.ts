import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BadreadsApiService {

  // Book

  readonly badreadsAPIUrl = "https://localhost:7034/api";

  constructor(private http:HttpClient) { }

  getBooksList():Observable<any[]> {
    return this.http.get<any>(this.badreadsAPIUrl + '/Books');
  }

  addBooks(data:any) {
    return this.http.post(this.badreadsAPIUrl + '/Books', data);
  }

  updateBooks(id:number|string, data:any) {
    return this.http.put(this.badreadsAPIUrl + `/Book/${id}`, data);
  }

  // NormalUser

  getNormalUserList():Observable<any[]> {
    return this.http.get<any>(this.badreadsAPIUrl + '/NormalUsers');
  }

  addNormalUser(data:any, adminId:number|string) {
    return this.http.post(this.badreadsAPIUrl + `/NormalUsers/${adminId}`, data);
  }

  updateNormalUsers(id:number|string, data:any) {
    return this.http.put(this.badreadsAPIUrl + `/NormalUsers/${id}`, data);
  }

  deleteNormalUser(id:number|string, adminId:number|string) {
    return this.http.delete(this.badreadsAPIUrl + `/Normal/${id}/${adminId}`)
  }

    // AdminUser

    getAdminUserList():Observable<any[]> {
      return this.http.get<any>(this.badreadsAPIUrl + '/AdminUsers');
    }
  
    addAdminUser(data:any) {
      return this.http.post(this.badreadsAPIUrl + '/AdminUsers', data);
    }
  
    updateAdminUsers(id:number|string, data:any) {
      return this.http.put(this.badreadsAPIUrl + `/AdminUsers/${id}`, data);
    }

}
