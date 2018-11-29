import { Component, Input } from '@angular/core';

@Component(
  {
    selector: 'app-infoblock-component',
    templateUrl: './infoblock-component.html'
  })

export class InfoBlockComponent {
  @Input() title: string;
  @Input() value: number;
}
