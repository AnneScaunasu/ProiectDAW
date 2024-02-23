import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import { BadreadsApiService } from '../badreads-api.service';
import { Book, BookSelf, BookType } from '../classes';

@Component({
  selector: 'app-home-page',
  standalone: true,
  imports: [],
  templateUrl: './home-page.component.html',
  styleUrl: './home-page.component.css'
})
export class HomePageComponent {

  booksList$!: Observable<Book[]>;
  bookShelfsList$!: Observable<BookSelf[]>;
  bookTypesList$!: Observable<BookType[]>;
  bookSelfsList: BookSelf[] = [];

  // Map to desplay data associated with foreign keys
  bookTypesMap:Map<number,string> = new Map();

  constructor(private service: BadreadsApiService) {}

  ngOnInit(): void{
    this.booksList$ = this.service.getBooksList();
  }

}
