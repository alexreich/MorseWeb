import { Component, Inject, ChangeDetectorRef  } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public originalText: string;
  public morseString: string;
  public morseWords: string[];

  constructor(
    private http: HttpClient,
    private cd: ChangeDetectorRef,
    @Inject('BASE_URL') private baseUrl: string) {
  }
  onclick(translateWords) {
    //clear current translation
    this.morseString = null;
    this.cd.markForCheck();

    //fetch new translation
    this.http.get<any>(this.baseUrl + 'api/Morse/' + translateWords.value).subscribe(r => {
      console.log(r);
      

      const result = r.result;

      this.originalText = r.original;
      this.morseString = result;

      if (result.indexOf('  ') > 0) {
        this.morseWords = result.split('  ');
      } else {
        this.morseWords = null;
      }
      this.cd.markForCheck();
    }, error => console.error(error));
  }
}
