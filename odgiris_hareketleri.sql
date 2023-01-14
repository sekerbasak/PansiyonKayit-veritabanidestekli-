CREATE OR REPLACE FUNCTION "pansiyonKayitSchemas".oda_giris_hareketleri()
RETURNS trigger
LANGUAGE plpgsql
AS $function$
BEGIN 
 insert into "pansiyonKayitSchemas"."tblgiris_hareketleri"(odanumara,oda_giris_tarihi) VALUES 
(OLD."OdaNo",OLD."GirisTarihi");
 return old;
END; 
$function$
CREATE TRIGGER "oda_giris_yapildiginda" 
AFTER delete ON "pansiyonKayitSchemas"."tblMusteri1" 
FOR EACH ROW 
EXECUTE PROCEDURE "pansiyonKayitSchemas".oda_giris_hareketleri();