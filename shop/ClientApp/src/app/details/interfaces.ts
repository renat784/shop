interface Ad {
    adId: number;
    title: string;
    price: number;
    desc: string;
    subCategoryId: number;
    categoryId: number;
    cityId: number;
    phone: string;
    email: string;
    contactPerson: string;
    city: City;
    category: Category;
    subCategory: SubCategory;
  }

  interface SubCategory {
    subCategoryId: number;
    categoryId: number;
    name: string;
  }

  interface Category{
    categoryId: number;
    name: string;
  }

  interface StyleCategory{
    categoryId:number;
    color: string;
    iconClass:string;
  }

  interface City{
    cityId: number;
    name : string;
  }