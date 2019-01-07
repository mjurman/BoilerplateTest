import { AppTemplatePage } from './app.po';

describe('App App', function() {
  let page: AppTemplatePage;

  beforeEach(() => {
    page = new AppTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
