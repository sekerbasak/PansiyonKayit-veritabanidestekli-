CREATE OR REPLACE FUNCTION "pansiyonKayitSchemas".oda_cikis_hareketleri()
RETURNS trigger
LANGUAGE plpgsql
AS $function$
BEGIN 
 insert into "pansiyonKayitSchemas"."tblcikis_hareketleri"(odanumara,oda_cikis_tarihi) VALUES 
(OLD."OdaNo",current_timestamp::timestamp);
 return old;
END; 
$function$
CREATE TRIGGER "oda_cikis_yapildiginda" 
AFTER delete ON "pansiyonKayitSchemas"."tblMusteri1" 
FOR EACH ROW 
EXECUTE PROCEDURE "pansiyonKayitSchemas".oda_cikis_hareketleri();