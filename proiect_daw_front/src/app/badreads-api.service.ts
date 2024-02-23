import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Book, BookSelf, NormalUser, AdminUser, BookType } from './classes';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BadreadsApiService {

  requestBody: any[] = [];

  readonly badreadsAPIUrl = "https://localhost:7034/api";

  constructor(private http: HttpClient) { }

  // Book

  getBooksList(): Observable<any[]> {
    return this.http.get<any>(this.badreadsAPIUrl + '/Books');
  }

  addBook(book: Book, adminId: number | string) {
    this.requestBody = [book, adminId];
    return this.http.post(this.badreadsAPIUrl + '/Books', this.requestBody);
  }

  updateBook(book: Book, adminId: number | string) {
    this.requestBody = [book, adminId];
    return this.http.put(this.badreadsAPIUrl + `/Books/${book.id}`, this.requestBody);
  }

  deleteBook(bookId: number | String) {
    return this.http.delete(this.badreadsAPIUrl + `/Books/${bookId}`);
  }

  // NormalUser

  getNormalUserList(): Observable<any[]> {
    return this.http.get<any>(this.badreadsAPIUrl + '/NormalUsers');
  }

  getNormalUserWithCredentials(id: number | string, password: string) {
    return this.http.get<any>(this.badreadsAPIUrl + `/NormalUsers/${id}/${password}`);
  }

  addNormalUser(user: NormalUser) {
    return this.http.post(this.badreadsAPIUrl + `/NormalUsers`, user);
  }

  updateNormalUsers(user: NormalUser) {
    return this.http.put(this.badreadsAPIUrl + `/NormalUsers/${user.id}`, user);
  }

  deleteNormalUser(id: number | string) {
    return this.http.delete(this.badreadsAPIUrl + `/Normal/${id}`);
  }

  // AdminUser

  getAdminUserList(): Observable<any[]> {
    return this.http.get<any>(this.badreadsAPIUrl + '/AdminUsers');
  }

  addAdminUser(user: AdminUser, adminId: number | String) {
    this.requestBody = [user, adminId];
    return this.http.post(this.badreadsAPIUrl + '/AdminUsers', this.requestBody);
  }

  updateAdminUsers(adminId: number | String, user: AdminUser) {
    this.requestBody = [user, adminId];
    return this.http.put(this.badreadsAPIUrl + `/AdminUsers/${adminId}`, this.requestBody);
  }

  deleteAdminUser(id: number | String, adminId: number | String) {
    this.requestBody = [id, adminId];
    return this.http.delete(this.badreadsAPIUrl + `/AdminUsers/${id}/${adminId}`);
  }

  // BookSelf

  getBookSelfs(): Observable<any[]> {
    return this.http.get<any>(this.badreadsAPIUrl + '/BookSelfs');
  }

  addBookSelf(bookSelf: BookSelf) {
    return this.http.post(this.badreadsAPIUrl + '/BookSelfs', bookSelf);
  }

  updateBookSelf(bookSelf: BookSelf) {
    return this.http.put(this.badreadsAPIUrl + `/BookSelfs/${bookSelf.id}`, bookSelf);
  }

  deleteBookelf(bookSelfId: number | String) {
    return this.http.delete(this.badreadsAPIUrl + `/BookSelfs/${bookSelfId}`);
  }

  // BookType

  getBookTypesList(): Observable<any[]> {
    return this.http.get<any>(this.badreadsAPIUrl + '/BookTypes');
  }

  addBookType(bookType: BookType, adminId: number | string) {
    this.requestBody = [bookType, adminId];
    return this.http.post(this.badreadsAPIUrl + '/BookTypes', this.requestBody);
  }

  updateBookType(bookType: BookType, adminId: number | string) {
    this.requestBody = [bookType, adminId];
    return this.http.put(this.badreadsAPIUrl + `/BookTypes/${bookType.id}`, this.requestBody);
  }

  deleteBooktype(bookTypeId: number | String) {
    return this.http.delete(this.badreadsAPIUrl + `/BookTypes/${bookTypeId}`);
  }

}
