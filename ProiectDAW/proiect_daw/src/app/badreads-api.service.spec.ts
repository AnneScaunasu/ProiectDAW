import { TestBed } from '@angular/core/testing';

import { BadreadsApiService } from './badreads-api.service';

describe('BadreadsApiService', () => {
  let service: BadreadsApiService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(BadreadsApiService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
