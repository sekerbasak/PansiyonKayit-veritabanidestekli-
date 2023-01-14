select 
"pansiyonKayitSchemas"."tblOdaNo"."ODaNo" AS OdaID,
"KatNo",
"pansiyonKayitSchemas"."tblOdaDurumu"."OdaDurumu",
"pansiyonKayitSchemas"."tblOdaTip"."OdaTipi",
"pansiyonKayitSchemas"."tblOdaTip"."GunlukUcret"
from "pansiyonKayitSchemas"."tblOdalar"
inner join "pansiyonKayitSchemas"."tblOdaNo" on  "pansiyonKayitSchemas"."tblOdalar"."OdaID"="pansiyonKayitSchemas"."tblOdaNo"."OdaNoID" 
inner join "pansiyonKayitSchemas"."tblOdaDurumu" on  "pansiyonKayitSchemas"."tblOdalar"."OdaDurumuID"="pansiyonKayitSchemas"."tblOdaDurumu"."OdaDurumID"
inner join "pansiyonKayitSchemas"."tblOdaTip" ON "pansiyonKayitSchemas"."tblOdaTip"."OdaTipID" = "pansiyonKayitSchemas"."tblOdalar"."OdaTipID"
ORDER BY "OdaID" ASC; 