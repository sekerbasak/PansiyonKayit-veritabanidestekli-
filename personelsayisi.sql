CREATE OR REPLACE FUNCTION "pansiyonKayitSchemas".personelsayisi()
RETURNS integer
LANGUAGE plpgsql
AS $function$
DECLARE 
 personel_sayi integer;
BEGIN
 SELECT count("KisiID") into personel_sayi from "pansiyonKayitSchemas"."tblPersonel1";
 RETURN personel_sayi;
END; 
$function$