export class ApiUrl {
  static hostName = 'https://localhost:7151/';
  static apiPath = 'api/';

  // Students
  public static GetProductListUrl(): string {
    return this.hostName + this.apiPath + 'products';
  }

  public static GetStudentDetailUrl(id: number): string {
    let url =
      this.hostName.concat(this.apiPath) + 'products/id'.concat(id.toString());
    return url;
  }

}
