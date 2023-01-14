select 
"KisiID",
"pansiyonKayitSchemas"."tblCalisanDepartman"."Departman",
"Maas"
from "pansiyonKayitSchemas"."tblPersoneller"
inner join "pansiyonKayitSchemas"."tblCalisanDepartman" on  "pansiyonKayitSchemas"."tblPersoneller"."DePartmanID"="pansiyonKayitSchemas"."tblCalisanDepartman"."DepartmanID" 
ORDER BY "KisiID" ASC;



