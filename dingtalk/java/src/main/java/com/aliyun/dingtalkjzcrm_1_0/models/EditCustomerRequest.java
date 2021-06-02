// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditCustomerRequest extends TeaModel {
    // 数据类型，固定填写148
    @NameInMap("datatype")
    public Long datatype;

    // 时间戳
    @NameInMap("stamp")
    public Long stamp;

    // 数据id，不填或者填0为新增数据
    @NameInMap("msgid")
    public Long msgid;

    // 编辑数据
    @NameInMap("data")
    public EditCustomerRequestData data;

    public static EditCustomerRequest build(java.util.Map<String, ?> map) throws Exception {
        EditCustomerRequest self = new EditCustomerRequest();
        return TeaModel.build(map, self);
    }

    public EditCustomerRequest setDatatype(Long datatype) {
        this.datatype = datatype;
        return this;
    }
    public Long getDatatype() {
        return this.datatype;
    }

    public EditCustomerRequest setStamp(Long stamp) {
        this.stamp = stamp;
        return this;
    }
    public Long getStamp() {
        return this.stamp;
    }

    public EditCustomerRequest setMsgid(Long msgid) {
        this.msgid = msgid;
        return this;
    }
    public Long getMsgid() {
        return this.msgid;
    }

    public EditCustomerRequest setData(EditCustomerRequestData data) {
        this.data = data;
        return this;
    }
    public EditCustomerRequestData getData() {
        return this.data;
    }

    public static class EditCustomerRequestData extends TeaModel {
        // 创建人
        @NameInMap("data_userid")
        public String dataUserid;

        // 上级客户
        @NameInMap("kh_pkhid")
        public String khPkhid;

        // 类别（企业客户，个人客户，供应商，个人供应商）
        @NameInMap("kh_class")
        public String khClass;

        // 客户名称
        @NameInMap("kh_name")
        public String khName;

        // 性别（男，女）
        @NameInMap("kh_sex")
        public String khSex;

        // 助记简称
        @NameInMap("kh_shortname")
        public String khShortname;

        // 行业
        @NameInMap("kh_industry")
        public String khIndustry;

        // 人员规模
        @NameInMap("kh_employees")
        public String khEmployees;

        // 家庭地址
        @NameInMap("kh_address")
        public String khAddress;

        // 国家地区
        @NameInMap("kh_country")
        public String khCountry;

        // 省份
        @NameInMap("kh_province")
        public String khProvince;

        // 城市
        @NameInMap("kh_city")
        public String khCity;

        // 单位地址
        @NameInMap("kh_coaddress")
        public String khCoaddress;

        // 热点客户（是，否）
        @NameInMap("kh_hottype")
        public String khHottype;

        // 热度（无，低热，中热，高热）
        @NameInMap("kh_hotlevel")
        public String khHotlevel;

        // 热点分类
        @NameInMap("kh_hotfl")
        public String khHotfl;

        // 热点说明
        @NameInMap("kh_hotmemo")
        public String khHotmemo;

        // 种类
        @NameInMap("kh_type")
        public String khType;

        // 阶段
        @NameInMap("kh_status")
        public String khStatus;

        // 编号
        @NameInMap("kh_sn")
        public String khSn;

        // 手机
        @NameInMap("kh_handset")
        public String khHandset;

        // 邮箱
        @NameInMap("kh_email")
        public String khEmail;

        // 钉钉号
        @NameInMap("kh_dingtalk")
        public String khDingtalk;

        // 家庭电话
        @NameInMap("kh_tel")
        public String khTel;

        // 微信号
        @NameInMap("kh_weixin")
        public String khWeixin;

        // QQ
        @NameInMap("kh_qq")
        public String khQq;

        // Skype
        @NameInMap("kh_skype")
        public String khSkype;

        // 旺旺
        @NameInMap("kh_wangwang")
        public String khWangwang;

        // 工作电话
        @NameInMap("kh_worktel")
        public String khWorktel;

        // 传真
        @NameInMap("kh_fax")
        public String khFax;

        // 邮编
        @NameInMap("kh_pst")
        public String khPst;

        // 部门
        @NameInMap("kh_department")
        public String khDepartment;

        // 称谓
        @NameInMap("kh_appellation")
        public String khAppellation;

        // 负责业务
        @NameInMap("kh_preside")
        public String khPreside;

        // 职务
        @NameInMap("kh_headship")
        public String khHeadship;

        // 网址
        @NameInMap("kh_web")
        public String khWeb;

        // 爱好
        @NameInMap("kh_befontof")
        public String khBefontof;

        // 来源
        @NameInMap("kh_from")
        public String khFrom;

        // 开票资料
        @NameInMap("kh_billinfo")
        public String khBillinfo;

        // 公司简介
        @NameInMap("kh_info")
        public String khInfo;

        // 关系等级
        @NameInMap("kh_ralagrade")
        public String khRalagrade;

        // 信用等级（低，中，高）
        @NameInMap("kh_creditgrade")
        public String khCreditgrade;

        // 价值评估（低，中，高）
        @NameInMap("kh_valrating")
        public String khValrating;

        // 证件类型
        @NameInMap("kh_cttype")
        public String khCttype;

        // 证件号码
        @NameInMap("kh_ctnumber")
        public String khCtnumber;

        // 联系人分类
        @NameInMap("kh_contype")
        public String khContype;

        // 备注
        @NameInMap("kh_remark")
        public String khRemark;

        // 客户级别
        @NameInMap("kh_jibie")
        public String khJibie;

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

        public EditCustomerRequestData setKhPkhid(String khPkhid) {
            this.khPkhid = khPkhid;
            return this;
        }
        public String getKhPkhid() {
            return this.khPkhid;
        }

        public EditCustomerRequestData setKhClass(String khClass) {
            this.khClass = khClass;
            return this;
        }
        public String getKhClass() {
            return this.khClass;
        }

        public EditCustomerRequestData setKhName(String khName) {
            this.khName = khName;
            return this;
        }
        public String getKhName() {
            return this.khName;
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

        public EditCustomerRequestData setKhIndustry(String khIndustry) {
            this.khIndustry = khIndustry;
            return this;
        }
        public String getKhIndustry() {
            return this.khIndustry;
        }

        public EditCustomerRequestData setKhEmployees(String khEmployees) {
            this.khEmployees = khEmployees;
            return this;
        }
        public String getKhEmployees() {
            return this.khEmployees;
        }

        public EditCustomerRequestData setKhAddress(String khAddress) {
            this.khAddress = khAddress;
            return this;
        }
        public String getKhAddress() {
            return this.khAddress;
        }

        public EditCustomerRequestData setKhCountry(String khCountry) {
            this.khCountry = khCountry;
            return this;
        }
        public String getKhCountry() {
            return this.khCountry;
        }

        public EditCustomerRequestData setKhProvince(String khProvince) {
            this.khProvince = khProvince;
            return this;
        }
        public String getKhProvince() {
            return this.khProvince;
        }

        public EditCustomerRequestData setKhCity(String khCity) {
            this.khCity = khCity;
            return this;
        }
        public String getKhCity() {
            return this.khCity;
        }

        public EditCustomerRequestData setKhCoaddress(String khCoaddress) {
            this.khCoaddress = khCoaddress;
            return this;
        }
        public String getKhCoaddress() {
            return this.khCoaddress;
        }

        public EditCustomerRequestData setKhHottype(String khHottype) {
            this.khHottype = khHottype;
            return this;
        }
        public String getKhHottype() {
            return this.khHottype;
        }

        public EditCustomerRequestData setKhHotlevel(String khHotlevel) {
            this.khHotlevel = khHotlevel;
            return this;
        }
        public String getKhHotlevel() {
            return this.khHotlevel;
        }

        public EditCustomerRequestData setKhHotfl(String khHotfl) {
            this.khHotfl = khHotfl;
            return this;
        }
        public String getKhHotfl() {
            return this.khHotfl;
        }

        public EditCustomerRequestData setKhHotmemo(String khHotmemo) {
            this.khHotmemo = khHotmemo;
            return this;
        }
        public String getKhHotmemo() {
            return this.khHotmemo;
        }

        public EditCustomerRequestData setKhType(String khType) {
            this.khType = khType;
            return this;
        }
        public String getKhType() {
            return this.khType;
        }

        public EditCustomerRequestData setKhStatus(String khStatus) {
            this.khStatus = khStatus;
            return this;
        }
        public String getKhStatus() {
            return this.khStatus;
        }

        public EditCustomerRequestData setKhSn(String khSn) {
            this.khSn = khSn;
            return this;
        }
        public String getKhSn() {
            return this.khSn;
        }

        public EditCustomerRequestData setKhHandset(String khHandset) {
            this.khHandset = khHandset;
            return this;
        }
        public String getKhHandset() {
            return this.khHandset;
        }

        public EditCustomerRequestData setKhEmail(String khEmail) {
            this.khEmail = khEmail;
            return this;
        }
        public String getKhEmail() {
            return this.khEmail;
        }

        public EditCustomerRequestData setKhDingtalk(String khDingtalk) {
            this.khDingtalk = khDingtalk;
            return this;
        }
        public String getKhDingtalk() {
            return this.khDingtalk;
        }

        public EditCustomerRequestData setKhTel(String khTel) {
            this.khTel = khTel;
            return this;
        }
        public String getKhTel() {
            return this.khTel;
        }

        public EditCustomerRequestData setKhWeixin(String khWeixin) {
            this.khWeixin = khWeixin;
            return this;
        }
        public String getKhWeixin() {
            return this.khWeixin;
        }

        public EditCustomerRequestData setKhQq(String khQq) {
            this.khQq = khQq;
            return this;
        }
        public String getKhQq() {
            return this.khQq;
        }

        public EditCustomerRequestData setKhSkype(String khSkype) {
            this.khSkype = khSkype;
            return this;
        }
        public String getKhSkype() {
            return this.khSkype;
        }

        public EditCustomerRequestData setKhWangwang(String khWangwang) {
            this.khWangwang = khWangwang;
            return this;
        }
        public String getKhWangwang() {
            return this.khWangwang;
        }

        public EditCustomerRequestData setKhWorktel(String khWorktel) {
            this.khWorktel = khWorktel;
            return this;
        }
        public String getKhWorktel() {
            return this.khWorktel;
        }

        public EditCustomerRequestData setKhFax(String khFax) {
            this.khFax = khFax;
            return this;
        }
        public String getKhFax() {
            return this.khFax;
        }

        public EditCustomerRequestData setKhPst(String khPst) {
            this.khPst = khPst;
            return this;
        }
        public String getKhPst() {
            return this.khPst;
        }

        public EditCustomerRequestData setKhDepartment(String khDepartment) {
            this.khDepartment = khDepartment;
            return this;
        }
        public String getKhDepartment() {
            return this.khDepartment;
        }

        public EditCustomerRequestData setKhAppellation(String khAppellation) {
            this.khAppellation = khAppellation;
            return this;
        }
        public String getKhAppellation() {
            return this.khAppellation;
        }

        public EditCustomerRequestData setKhPreside(String khPreside) {
            this.khPreside = khPreside;
            return this;
        }
        public String getKhPreside() {
            return this.khPreside;
        }

        public EditCustomerRequestData setKhHeadship(String khHeadship) {
            this.khHeadship = khHeadship;
            return this;
        }
        public String getKhHeadship() {
            return this.khHeadship;
        }

        public EditCustomerRequestData setKhWeb(String khWeb) {
            this.khWeb = khWeb;
            return this;
        }
        public String getKhWeb() {
            return this.khWeb;
        }

        public EditCustomerRequestData setKhBefontof(String khBefontof) {
            this.khBefontof = khBefontof;
            return this;
        }
        public String getKhBefontof() {
            return this.khBefontof;
        }

        public EditCustomerRequestData setKhFrom(String khFrom) {
            this.khFrom = khFrom;
            return this;
        }
        public String getKhFrom() {
            return this.khFrom;
        }

        public EditCustomerRequestData setKhBillinfo(String khBillinfo) {
            this.khBillinfo = khBillinfo;
            return this;
        }
        public String getKhBillinfo() {
            return this.khBillinfo;
        }

        public EditCustomerRequestData setKhInfo(String khInfo) {
            this.khInfo = khInfo;
            return this;
        }
        public String getKhInfo() {
            return this.khInfo;
        }

        public EditCustomerRequestData setKhRalagrade(String khRalagrade) {
            this.khRalagrade = khRalagrade;
            return this;
        }
        public String getKhRalagrade() {
            return this.khRalagrade;
        }

        public EditCustomerRequestData setKhCreditgrade(String khCreditgrade) {
            this.khCreditgrade = khCreditgrade;
            return this;
        }
        public String getKhCreditgrade() {
            return this.khCreditgrade;
        }

        public EditCustomerRequestData setKhValrating(String khValrating) {
            this.khValrating = khValrating;
            return this;
        }
        public String getKhValrating() {
            return this.khValrating;
        }

        public EditCustomerRequestData setKhCttype(String khCttype) {
            this.khCttype = khCttype;
            return this;
        }
        public String getKhCttype() {
            return this.khCttype;
        }

        public EditCustomerRequestData setKhCtnumber(String khCtnumber) {
            this.khCtnumber = khCtnumber;
            return this;
        }
        public String getKhCtnumber() {
            return this.khCtnumber;
        }

        public EditCustomerRequestData setKhContype(String khContype) {
            this.khContype = khContype;
            return this;
        }
        public String getKhContype() {
            return this.khContype;
        }

        public EditCustomerRequestData setKhRemark(String khRemark) {
            this.khRemark = khRemark;
            return this;
        }
        public String getKhRemark() {
            return this.khRemark;
        }

        public EditCustomerRequestData setKhJibie(String khJibie) {
            this.khJibie = khJibie;
            return this;
        }
        public String getKhJibie() {
            return this.khJibie;
        }

    }

}
