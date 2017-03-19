import { FootCapPage } from './app.po';

describe('foot-cap App', function() {
  let page: FootCapPage;

  beforeEach(() => {
    page = new FootCapPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
