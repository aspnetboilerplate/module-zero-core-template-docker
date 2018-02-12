import { AbpTemplateTemplatePage } from './app.po';

describe('AbpTemplate App', function() {
  let page: AbpTemplateTemplatePage;

  beforeEach(() => {
    page = new AbpTemplateTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
