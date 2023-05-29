SELECT "Products"."Name", "Categories"."Name" FROM "Products"
LEFT JOIN "ProductsCategories" ON "ProductsCategories"."ProductId" = "Products"."Id"
LEFT JOIN "Categories" ON "Categories"."Id" = "ProductsCategories"."CategoryId"
