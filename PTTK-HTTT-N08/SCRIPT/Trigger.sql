--TRIGGER neu so tien coc >0 thi CHECKDC =true
-- DROP TRIGGER trig_UpdateCheckDC
CREATE OR REPLACE TRIGGER trig_UpdateCheckDC
BEFORE INSERT OR UPDATE ON PhieuDatPhong
FOR EACH ROW
BEGIN
    IF :NEW.SoTienDatCoc >= 0 THEN
        :NEW.CheckDC := 1;
    END IF;
END;
/