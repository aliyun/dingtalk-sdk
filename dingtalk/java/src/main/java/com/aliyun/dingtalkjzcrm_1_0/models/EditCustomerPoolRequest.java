// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditCustomerPoolRequest extends TeaModel {
    // 编辑数据
    @NameInMap("data")
    public EditCustomerPoolRequestData data;

    // 数据类型，固定填写238
    @NameInMap("datatype")
    public Long datatype;

    // 数据id，不填或者填0为新增数据
    @NameInMap("msgid")
    public Long msgid;

    // 时间戳
    @NameInMap("stamp")
    public Long stamp;

    public static EditCustomerPoolRequest build(java.util.Map<String, ?> map) throws Exception {
        EditCustomerPoolRequest self = new EditCustomerPoolRequest();
        return TeaModel.build(map, self);
    }

    public EditCustomerPoolRequest setData(EditCustomerPoolRequestData data) {
        this.data = data;
        return this;
    }
    public EditCustomerPoolRequestData getData() {
        return this.data;
    }

    public EditCustomerPoolRequest setDatatype(Long datatype) {
        this.datatype = datatype;
        return this;
    }
    public Long getDatatype() {
        return this.datatype;
    }

    public EditCustomerPoolRequest setMsgid(Long msgid) {
        this.msgid = msgid;
        return this;
    }
    public Long getMsgid() {
        return this.msgid;
    }

    public EditCustomerPoolRequest setStamp(Long stamp) {
        this.stamp = stamp;
        return this;
    }
    public Long getStamp() {
        return this.stamp;
    }

    public static class EditCustomerPoolRequestData extends TeaModel {
        // 创建人
        @NameInMap("data_userid")
        public String dataUserid;

        // 家庭地址
        @NameInMap("kh_address")
        public String khAddress;

        // 称谓
        @NameInMap("kh_appellation")
        public String khAppellation;

        // 爱好
        @NameInMap("kh_befontof")
        public String khBefontof;

        // 开票资料
        @NameInMap("kh_billinfo")
        public String khBillinfo;

        // 城市
        @NameInMap("kh_city")
        public String khCity;

        // 类别（企业客户，个人客户，供应商，个人供应商）
        @NameInMap("kh_class")
        public String khClass;

        // 单位地址
        @NameInMap("kh_coaddress")
        public String khCoaddress;

        // 联系人分类
        @NameInMap("kh_contype")
        public String khContype;

        // 国家地区
        @NameInMap("kh_country")
        public String khCountry;

        // 信用等级（低，中，高）
        @NameInMap("kh_creditgrade")
        public String khCreditgrade;

        // 证件号码
        @NameInMap("kh_ctnumber")
        public String khCtnumber;

        // 证件类型
        @NameInMap("kh_cttype")
        public String khCttype;

        // 部门
        @NameInMap("kh_department")
        public String khDepartment;

        // 钉钉号
        @NameInMap("kh_dingtalk")
        public String khDingtalk;

        // 邮箱
        @NameInMap("kh_email")
        public String khEmail;

        // 人员规模
        @NameInMap("kh_employees")
        public String khEmployees;

        // 传真
        @NameInMap("kh_fax")
        public String khFax;

        // 来源
        @NameInMap("kh_from")
        public String khFrom;

        // 最后跟踪
        @NameInMap("kh_genzongtime")
        public String khGenzongtime;

        // 手机
        @NameInMap("kh_handset")
        public String khHandset;

        // 职务
        @NameInMap("kh_headship")
        public String khHeadship;

        // 热点分类
        @NameInMap("kh_hotfl")
        public String khHotfl;

        // 热度（无，低热，中热，高热）
        @NameInMap("kh_hotlevel")
        public String khHotlevel;

        // 热点说明
        @NameInMap("kh_hotmemo")
        public String khHotmemo;

        // 热点客户（是，否）
        @NameInMap("kh_hottype")
        public String khHottype;

        // 行业
        @NameInMap("kh_industry")
        public String khIndustry;

        // 公司简介
        @NameInMap("kh_info")
        public String khInfo;

        // 客户级别
        @NameInMap("kh_jibie")
        public String khJibie;

        // 客户名称
        @NameInMap("kh_name")
        public String khName;

        // 上级客户
        @NameInMap("kh_pkhid")
        public String khPkhid;

        // 负责业务
        @NameInMap("kh_preside")
        public String khPreside;

        // 省份
        @NameInMap("kh_province")
        public String khProvince;

        // 邮编
        @NameInMap("kh_pst")
        public String khPst;

        // QQ
        @NameInMap("kh_qq")
        public String khQq;

        // 关系等级
        @NameInMap("kh_ralagrade")
        public String khRalagrade;

        // 备注
        @NameInMap("kh_remark")
        public String khRemark;

        // 性别（男，女）
        @NameInMap("kh_sex")
        public String khSex;

        // 助记简称
        @NameInMap("kh_shortname")
        public String khShortname;

        // Skype
        @NameInMap("kh_skype")
        public String khSkype;

        // 编号
        @NameInMap("kh_sn")
        public String khSn;

        // 阶段
        @NameInMap("kh_status")
        public String khStatus;

        // 家庭电话
        @NameInMap("kh_tel")
        public String khTel;

        // 种类
        @NameInMap("kh_type")
        public String khType;

        // 价值评估（低，中，高）
        @NameInMap("kh_valrating")
        public String khValrating;

        // 旺旺
        @NameInMap("kh_wangwang")
        public String khWangwang;

        // 网址
        @NameInMap("kh_web")
        public String khWeb;

        // 微信号
        @NameInMap("kh_weixin")
        public String khWeixin;

        // 工作电话
        @NameInMap("kh_worktel")
        public String khWorktel;

        public static EditCustomerPoolRequestData build(java.util.Map<String, ?> map) throws Exception {
            EditCustomerPoolRequestData self = new EditCustomerPoolRequestData();
            return TeaModel.build(map, self);
        }

        public EditCustomerPoolRequestData setDataUserid(String dataUserid) {
            this.dataUserid = dataUserid;
            return this;
        }
        public String getDataUserid() {
            return this.dataUserid;
        }

        public EditCustomerPoolRequestData setKhAddress(String khAddress) {
            this.khAddress = khAddress;
            return this;
        }
        public String getKhAddress() {
            return this.khAddress;
        }

        public EditCustomerPoolRequestData setKhAppellation(String khAppellation) {
            this.khAppellation = khAppellation;
            return this;
        }
        public String getKhAppellation() {
            return this.khAppellation;
        }

        public EditCustomerPoolRequestData setKhBefontof(String khBefontof) {
            this.khBefontof = khBefontof;
            return this;
        }
        public String getKhBefontof() {
            return this.khBefontof;
        }

        public EditCustomerPoolRequestData setKhBillinfo(String khBillinfo) {
            this.khBillinfo = khBillinfo;
            return this;
        }
        public String getKhBillinfo() {
            return this.khBillinfo;
        }

        public EditCustomerPoolRequestData setKhCity(String khCity) {
            this.khCity = khCity;
            return this;
        }
        public String getKhCity() {
            return this.khCity;
        }

        public EditCustomerPoolRequestData setKhClass(String khClass) {
            this.khClass = khClass;
            return this;
        }
        public String getKhClass() {
            return this.khClass;
        }

        public EditCustomerPoolRequestData setKhCoaddress(String khCoaddress) {
            this.khCoaddress = khCoaddress;
            return this;
        }
        public String getKhCoaddress() {
            return this.khCoaddress;
        }

        public EditCustomerPoolRequestData setKhContype(String khContype) {
            this.khContype = khContype;
            return this;
        }
        public String getKhContype() {
            return this.khContype;
        }

        public EditCustomerPoolRequestData setKhCountry(String khCountry) {
            this.khCountry = khCountry;
            return this;
        }
        public String getKhCountry() {
            return this.khCountry;
        }

        public EditCustomerPoolRequestData setKhCreditgrade(String khCreditgrade) {
            this.khCreditgrade = khCreditgrade;
            return this;
        }
        public String getKhCreditgrade() {
            return this.khCreditgrade;
        }

        public EditCustomerPoolRequestData setKhCtnumber(String khCtnumber) {
            this.khCtnumber = khCtnumber;
            return this;
        }
        public String getKhCtnumber() {
            return this.khCtnumber;
        }

        public EditCustomerPoolRequestData setKhCttype(String khCttype) {
            this.khCttype = khCttype;
            return this;
        }
        public String getKhCttype() {
            return this.khCttype;
        }

        public EditCustomerPoolRequestData setKhDepartment(String khDepartment) {
            this.khDepartment = khDepartment;
            return this;
        }
        public String getKhDepartment() {
            return this.khDepartment;
        }

        public EditCustomerPoolRequestData setKhDingtalk(String khDingtalk) {
            this.khDingtalk = khDingtalk;
            return this;
        }
        public String getKhDingtalk() {
            return this.khDingtalk;
        }

        public EditCustomerPoolRequestData setKhEmail(String khEmail) {
            this.khEmail = khEmail;
            return this;
        }
        public String getKhEmail() {
            return this.khEmail;
        }

        public EditCustomerPoolRequestData setKhEmployees(String khEmployees) {
            this.khEmployees = khEmployees;
            return this;
        }
        public String getKhEmployees() {
            return this.khEmployees;
        }

        public EditCustomerPoolRequestData setKhFax(String khFax) {
            this.khFax = khFax;
            return this;
        }
        public String getKhFax() {
            return this.khFax;
        }

        public EditCustomerPoolRequestData setKhFrom(String khFrom) {
            this.khFrom = khFrom;
            return this;
        }
        public String getKhFrom() {
            return this.khFrom;
        }

        public EditCustomerPoolRequestData setKhGenzongtime(String khGenzongtime) {
            this.khGenzongtime = khGenzongtime;
            return this;
        }
        public String getKhGenzongtime() {
            return this.khGenzongtime;
        }

        public EditCustomerPoolRequestData setKhHandset(String khHandset) {
            this.khHandset = khHandset;
            return this;
        }
        public String getKhHandset() {
            return this.khHandset;
        }

        public EditCustomerPoolRequestData setKhHeadship(String khHeadship) {
            this.khHeadship = khHeadship;
            return this;
        }
        public String getKhHeadship() {
            return this.khHeadship;
        }

        public EditCustomerPoolRequestData setKhHotfl(String khHotfl) {
            this.khHotfl = khHotfl;
            return this;
        }
        public String getKhHotfl() {
            return this.khHotfl;
        }

        public EditCustomerPoolRequestData setKhHotlevel(String khHotlevel) {
            this.khHotlevel = khHotlevel;
            return this;
        }
        public String getKhHotlevel() {
            return this.khHotlevel;
        }

        public EditCustomerPoolRequestData setKhHotmemo(String khHotmemo) {
            this.khHotmemo = khHotmemo;
            return this;
        }
        public String getKhHotmemo() {
            return this.khHotmemo;
        }

        public EditCustomerPoolRequestData setKhHottype(String khHottype) {
            this.khHottype = khHottype;
            return this;
        }
        public String getKhHottype() {
            return this.khHottype;
        }

        public EditCustomerPoolRequestData setKhIndustry(String khIndustry) {
            this.khIndustry = khIndustry;
            return this;
        }
        public String getKhIndustry() {
            return this.khIndustry;
        }

        public EditCustomerPoolRequestData setKhInfo(String khInfo) {
            this.khInfo = khInfo;
            return this;
        }
        public String getKhInfo() {
            return this.khInfo;
        }

        public EditCustomerPoolRequestData setKhJibie(String khJibie) {
            this.khJibie = khJibie;
            return this;
        }
        public String getKhJibie() {
            return this.khJibie;
        }

        public EditCustomerPoolRequestData setKhName(String khName) {
            this.khName = khName;
            return this;
        }
        public String getKhName() {
            return this.khName;
        }

        public EditCustomerPoolRequestData setKhPkhid(String khPkhid) {
            this.khPkhid = khPkhid;
            return this;
        }
        public String getKhPkhid() {
            return this.khPkhid;
        }

        public EditCustomerPoolRequestData setKhPreside(String khPreside) {
            this.khPreside = khPreside;
            return this;
        }
        public String getKhPreside() {
            return this.khPreside;
        }

        public EditCustomerPoolRequestData setKhProvince(String khProvince) {
            this.khProvince = khProvince;
            return this;
        }
        public String getKhProvince() {
            return this.khProvince;
        }

        public EditCustomerPoolRequestData setKhPst(String khPst) {
            this.khPst = khPst;
            return this;
        }
        public String getKhPst() {
            return this.khPst;
        }

        public EditCustomerPoolRequestData setKhQq(String khQq) {
            this.khQq = khQq;
            return this;
        }
        public String getKhQq() {
            return this.khQq;
        }

        public EditCustomerPoolRequestData setKhRalagrade(String khRalagrade) {
            this.khRalagrade = khRalagrade;
            return this;
        }
        public String getKhRalagrade() {
            return this.khRalagrade;
        }

        public EditCustomerPoolRequestData setKhRemark(String khRemark) {
            this.khRemark = khRemark;
            return this;
        }
        public String getKhRemark() {
            return this.khRemark;
        }

        public EditCustomerPoolRequestData setKhSex(String khSex) {
            this.khSex = khSex;
            return this;
        }
        public String getKhSex() {
            return this.khSex;
        }

        public EditCustomerPoolRequestData setKhShortname(String khShortname) {
            this.khShortname = khShortname;
            return this;
        }
        public String getKhShortname() {
            return this.khShortname;
        }

        public EditCustomerPoolRequestData setKhSkype(String khSkype) {
            this.khSkype = khSkype;
            return this;
        }
        public String getKhSkype() {
            return this.khSkype;
        }

        public EditCustomerPoolRequestData setKhSn(String khSn) {
            this.khSn = khSn;
            return this;
        }
        public String getKhSn() {
            return this.khSn;
        }

        public EditCustomerPoolRequestData setKhStatus(String khStatus) {
            this.khStatus = khStatus;
            return this;
        }
        public String getKhStatus() {
            return this.khStatus;
        }

        public EditCustomerPoolRequestData setKhTel(String khTel) {
            this.khTel = khTel;
            return this;
        }
        public String getKhTel() {
            return this.khTel;
        }

        public EditCustomerPoolRequestData setKhType(String khType) {
            this.khType = khType;
            return this;
        }
        public String getKhType() {
            return this.khType;
        }

        public EditCustomerPoolRequestData setKhValrating(String khValrating) {
            this.khValrating = khValrating;
            return this;
        }
        public String getKhValrating() {
            return this.khValrating;
        }

        public EditCustomerPoolRequestData setKhWangwang(String khWangwang) {
            this.khWangwang = khWangwang;
            return this;
        }
        public String getKhWangwang() {
            return this.khWangwang;
        }

        public EditCustomerPoolRequestData setKhWeb(String khWeb) {
            this.khWeb = khWeb;
            return this;
        }
        public String getKhWeb() {
            return this.khWeb;
        }

        public EditCustomerPoolRequestData setKhWeixin(String khWeixin) {
            this.khWeixin = khWeixin;
            return this;
        }
        public String getKhWeixin() {
            return this.khWeixin;
        }

        public EditCustomerPoolRequestData setKhWorktel(String khWorktel) {
            this.khWorktel = khWorktel;
            return this;
        }
        public String getKhWorktel() {
            return this.khWorktel;
        }

    }

}
