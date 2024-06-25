// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditCustomerRequest extends TeaModel {
    @NameInMap("data")
    public EditCustomerRequestData data;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>148</p>
     */
    @NameInMap("datatype")
    public Long datatype;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("msgid")
    public Long msgid;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1621822122</p>
     */
    @NameInMap("stamp")
    public Long stamp;

    public static EditCustomerRequest build(java.util.Map<String, ?> map) throws Exception {
        EditCustomerRequest self = new EditCustomerRequest();
        return TeaModel.build(map, self);
    }

    public EditCustomerRequest setData(EditCustomerRequestData data) {
        this.data = data;
        return this;
    }
    public EditCustomerRequestData getData() {
        return this.data;
    }

    public EditCustomerRequest setDatatype(Long datatype) {
        this.datatype = datatype;
        return this;
    }
    public Long getDatatype() {
        return this.datatype;
    }

    public EditCustomerRequest setMsgid(Long msgid) {
        this.msgid = msgid;
        return this;
    }
    public Long getMsgid() {
        return this.msgid;
    }

    public EditCustomerRequest setStamp(Long stamp) {
        this.stamp = stamp;
        return this;
    }
    public Long getStamp() {
        return this.stamp;
    }

    public static class EditCustomerRequestData extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>张三</p>
         * 
         * <strong>if can be null:</strong>
         * <p>false</p>
         */
        @NameInMap("data_userid")
        public String dataUserid;

        @NameInMap("kh_address")
        public String khAddress;

        @NameInMap("kh_appellation")
        public String khAppellation;

        @NameInMap("kh_befontof")
        public String khBefontof;

        @NameInMap("kh_billinfo")
        public String khBillinfo;

        @NameInMap("kh_city")
        public String khCity;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("kh_class")
        public String khClass;

        @NameInMap("kh_coaddress")
        public String khCoaddress;

        @NameInMap("kh_contype")
        public String khContype;

        @NameInMap("kh_country")
        public String khCountry;

        @NameInMap("kh_creditgrade")
        public String khCreditgrade;

        @NameInMap("kh_ctnumber")
        public String khCtnumber;

        @NameInMap("kh_cttype")
        public String khCttype;

        @NameInMap("kh_department")
        public String khDepartment;

        @NameInMap("kh_dingtalk")
        public String khDingtalk;

        @NameInMap("kh_email")
        public String khEmail;

        @NameInMap("kh_employees")
        public String khEmployees;

        @NameInMap("kh_fax")
        public String khFax;

        @NameInMap("kh_from")
        public String khFrom;

        @NameInMap("kh_handset")
        public String khHandset;

        @NameInMap("kh_headship")
        public String khHeadship;

        @NameInMap("kh_hotfl")
        public String khHotfl;

        @NameInMap("kh_hotlevel")
        public String khHotlevel;

        @NameInMap("kh_hotmemo")
        public String khHotmemo;

        @NameInMap("kh_hottype")
        public String khHottype;

        @NameInMap("kh_industry")
        public String khIndustry;

        @NameInMap("kh_info")
        public String khInfo;

        @NameInMap("kh_jibie")
        public String khJibie;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("kh_name")
        public String khName;

        @NameInMap("kh_pkhid")
        public String khPkhid;

        @NameInMap("kh_preside")
        public String khPreside;

        @NameInMap("kh_province")
        public String khProvince;

        @NameInMap("kh_pst")
        public String khPst;

        @NameInMap("kh_qq")
        public String khQq;

        @NameInMap("kh_ralagrade")
        public String khRalagrade;

        @NameInMap("kh_remark")
        public String khRemark;

        @NameInMap("kh_sex")
        public String khSex;

        @NameInMap("kh_shortname")
        public String khShortname;

        @NameInMap("kh_skype")
        public String khSkype;

        @NameInMap("kh_sn")
        public String khSn;

        @NameInMap("kh_status")
        public String khStatus;

        @NameInMap("kh_tel")
        public String khTel;

        @NameInMap("kh_type")
        public String khType;

        @NameInMap("kh_valrating")
        public String khValrating;

        @NameInMap("kh_wangwang")
        public String khWangwang;

        @NameInMap("kh_web")
        public String khWeb;

        @NameInMap("kh_weixin")
        public String khWeixin;

        @NameInMap("kh_worktel")
        public String khWorktel;

        public static EditCustomerRequestData build(java.util.Map<String, ?> map) throws Exception {
            EditCustomerRequestData self = new EditCustomerRequestData();
            return TeaModel.build(map, self);
        }

        public EditCustomerRequestData setDataUserid(String dataUserid) {
            this.dataUserid = dataUserid;
            return this;
        }
        public String getDataUserid() {
            return this.dataUserid;
        }

        public EditCustomerRequestData setKhAddress(String khAddress) {
            this.khAddress = khAddress;
            return this;
        }
        public String getKhAddress() {
            return this.khAddress;
        }

        public EditCustomerRequestData setKhAppellation(String khAppellation) {
            this.khAppellation = khAppellation;
            return this;
        }
        public String getKhAppellation() {
            return this.khAppellation;
        }

        public EditCustomerRequestData setKhBefontof(String khBefontof) {
            this.khBefontof = khBefontof;
            return this;
        }
        public String getKhBefontof() {
            return this.khBefontof;
        }

        public EditCustomerRequestData setKhBillinfo(String khBillinfo) {
            this.khBillinfo = khBillinfo;
            return this;
        }
        public String getKhBillinfo() {
            return this.khBillinfo;
        }

        public EditCustomerRequestData setKhCity(String khCity) {
            this.khCity = khCity;
            return this;
        }
        public String getKhCity() {
            return this.khCity;
        }

        public EditCustomerRequestData setKhClass(String khClass) {
            this.khClass = khClass;
            return this;
        }
        public String getKhClass() {
            return this.khClass;
        }

        public EditCustomerRequestData setKhCoaddress(String khCoaddress) {
            this.khCoaddress = khCoaddress;
            return this;
        }
        public String getKhCoaddress() {
            return this.khCoaddress;
        }

        public EditCustomerRequestData setKhContype(String khContype) {
            this.khContype = khContype;
            return this;
        }
        public String getKhContype() {
            return this.khContype;
        }

        public EditCustomerRequestData setKhCountry(String khCountry) {
            this.khCountry = khCountry;
            return this;
        }
        public String getKhCountry() {
            return this.khCountry;
        }

        public EditCustomerRequestData setKhCreditgrade(String khCreditgrade) {
            this.khCreditgrade = khCreditgrade;
            return this;
        }
        public String getKhCreditgrade() {
            return this.khCreditgrade;
        }

        public EditCustomerRequestData setKhCtnumber(String khCtnumber) {
            this.khCtnumber = khCtnumber;
            return this;
        }
        public String getKhCtnumber() {
            return this.khCtnumber;
        }

        public EditCustomerRequestData setKhCttype(String khCttype) {
            this.khCttype = khCttype;
            return this;
        }
        public String getKhCttype() {
            return this.khCttype;
        }

        public EditCustomerRequestData setKhDepartment(String khDepartment) {
            this.khDepartment = khDepartment;
            return this;
        }
        public String getKhDepartment() {
            return this.khDepartment;
        }

        public EditCustomerRequestData setKhDingtalk(String khDingtalk) {
            this.khDingtalk = khDingtalk;
            return this;
        }
        public String getKhDingtalk() {
            return this.khDingtalk;
        }

        public EditCustomerRequestData setKhEmail(String khEmail) {
            this.khEmail = khEmail;
            return this;
        }
        public String getKhEmail() {
            return this.khEmail;
        }

        public EditCustomerRequestData setKhEmployees(String khEmployees) {
            this.khEmployees = khEmployees;
            return this;
        }
        public String getKhEmployees() {
            return this.khEmployees;
        }

        public EditCustomerRequestData setKhFax(String khFax) {
            this.khFax = khFax;
            return this;
        }
        public String getKhFax() {
            return this.khFax;
        }

        public EditCustomerRequestData setKhFrom(String khFrom) {
            this.khFrom = khFrom;
            return this;
        }
        public String getKhFrom() {
            return this.khFrom;
        }

        public EditCustomerRequestData setKhHandset(String khHandset) {
            this.khHandset = khHandset;
            return this;
        }
        public String getKhHandset() {
            return this.khHandset;
        }

        public EditCustomerRequestData setKhHeadship(String khHeadship) {
            this.khHeadship = khHeadship;
            return this;
        }
        public String getKhHeadship() {
            return this.khHeadship;
        }

        public EditCustomerRequestData setKhHotfl(String khHotfl) {
            this.khHotfl = khHotfl;
            return this;
        }
        public String getKhHotfl() {
            return this.khHotfl;
        }

        public EditCustomerRequestData setKhHotlevel(String khHotlevel) {
            this.khHotlevel = khHotlevel;
            return this;
        }
        public String getKhHotlevel() {
            return this.khHotlevel;
        }

        public EditCustomerRequestData setKhHotmemo(String khHotmemo) {
            this.khHotmemo = khHotmemo;
            return this;
        }
        public String getKhHotmemo() {
            return this.khHotmemo;
        }

        public EditCustomerRequestData setKhHottype(String khHottype) {
            this.khHottype = khHottype;
            return this;
        }
        public String getKhHottype() {
            return this.khHottype;
        }

        public EditCustomerRequestData setKhIndustry(String khIndustry) {
            this.khIndustry = khIndustry;
            return this;
        }
        public String getKhIndustry() {
            return this.khIndustry;
        }

        public EditCustomerRequestData setKhInfo(String khInfo) {
            this.khInfo = khInfo;
            return this;
        }
        public String getKhInfo() {
            return this.khInfo;
        }

        public EditCustomerRequestData setKhJibie(String khJibie) {
            this.khJibie = khJibie;
            return this;
        }
        public String getKhJibie() {
            return this.khJibie;
        }

        public EditCustomerRequestData setKhName(String khName) {
            this.khName = khName;
            return this;
        }
        public String getKhName() {
            return this.khName;
        }

        public EditCustomerRequestData setKhPkhid(String khPkhid) {
            this.khPkhid = khPkhid;
            return this;
        }
        public String getKhPkhid() {
            return this.khPkhid;
        }

        public EditCustomerRequestData setKhPreside(String khPreside) {
            this.khPreside = khPreside;
            return this;
        }
        public String getKhPreside() {
            return this.khPreside;
        }

        public EditCustomerRequestData setKhProvince(String khProvince) {
            this.khProvince = khProvince;
            return this;
        }
        public String getKhProvince() {
            return this.khProvince;
        }

        public EditCustomerRequestData setKhPst(String khPst) {
            this.khPst = khPst;
            return this;
        }
        public String getKhPst() {
            return this.khPst;
        }

        public EditCustomerRequestData setKhQq(String khQq) {
            this.khQq = khQq;
            return this;
        }
        public String getKhQq() {
            return this.khQq;
        }

        public EditCustomerRequestData setKhRalagrade(String khRalagrade) {
            this.khRalagrade = khRalagrade;
            return this;
        }
        public String getKhRalagrade() {
            return this.khRalagrade;
        }

        public EditCustomerRequestData setKhRemark(String khRemark) {
            this.khRemark = khRemark;
            return this;
        }
        public String getKhRemark() {
            return this.khRemark;
        }

        public EditCustomerRequestData setKhSex(String khSex) {
            this.khSex = khSex;
            return this;
        }
        public String getKhSex() {
            return this.khSex;
        }

        public EditCustomerRequestData setKhShortname(String khShortname) {
            this.khShortname = khShortname;
            return this;
        }
        public String getKhShortname() {
            return this.khShortname;
        }

        public EditCustomerRequestData setKhSkype(String khSkype) {
            this.khSkype = khSkype;
            return this;
        }
        public String getKhSkype() {
            return this.khSkype;
        }

        public EditCustomerRequestData setKhSn(String khSn) {
            this.khSn = khSn;
            return this;
        }
        public String getKhSn() {
            return this.khSn;
        }

        public EditCustomerRequestData setKhStatus(String khStatus) {
            this.khStatus = khStatus;
            return this;
        }
        public String getKhStatus() {
            return this.khStatus;
        }

        public EditCustomerRequestData setKhTel(String khTel) {
            this.khTel = khTel;
            return this;
        }
        public String getKhTel() {
            return this.khTel;
        }

        public EditCustomerRequestData setKhType(String khType) {
            this.khType = khType;
            return this;
        }
        public String getKhType() {
            return this.khType;
        }

        public EditCustomerRequestData setKhValrating(String khValrating) {
            this.khValrating = khValrating;
            return this;
        }
        public String getKhValrating() {
            return this.khValrating;
        }

        public EditCustomerRequestData setKhWangwang(String khWangwang) {
            this.khWangwang = khWangwang;
            return this;
        }
        public String getKhWangwang() {
            return this.khWangwang;
        }

        public EditCustomerRequestData setKhWeb(String khWeb) {
            this.khWeb = khWeb;
            return this;
        }
        public String getKhWeb() {
            return this.khWeb;
        }

        public EditCustomerRequestData setKhWeixin(String khWeixin) {
            this.khWeixin = khWeixin;
            return this;
        }
        public String getKhWeixin() {
            return this.khWeixin;
        }

        public EditCustomerRequestData setKhWorktel(String khWorktel) {
            this.khWorktel = khWorktel;
            return this;
        }
        public String getKhWorktel() {
            return this.khWorktel;
        }

    }

}
