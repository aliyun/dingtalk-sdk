// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class ConsultCreateSubInstitutionRequest extends TeaModel {
    /**
     * <p>签约支付宝账户，用于协议确认</p>
     */
    @NameInMap("bindingAlipayLogonId")
    public String bindingAlipayLogonId;

    /**
     * <p>联系人</p>
     */
    @NameInMap("contactInfo")
    public ConsultCreateSubInstitutionRequestContactInfo contactInfo;

    /**
     * <p>主机构编号</p>
     */
    @NameInMap("instId")
    public String instId;

    @NameInMap("legalPersonCertInfo")
    public ConsultCreateSubInstitutionRequestLegalPersonCertInfo legalPersonCertInfo;

    /**
     * <p>进件创建外部流水号</p>
     */
    @NameInMap("outTradeNo")
    public String outTradeNo;

    /**
     * <p>进件渠道</p>
     */
    @NameInMap("payChannel")
    public String payChannel;

    /**
     * <p>资质信息</p>
     */
    @NameInMap("qualificationInfos")
    public java.util.List<ConsultCreateSubInstitutionRequestQualificationInfos> qualificationInfos;

    /**
     * <p>开通的服务类型</p>
     */
    @NameInMap("services")
    public java.util.List<String> services;

    /**
     * <p>资金账户信息</p>
     */
    @NameInMap("settleInfo")
    public ConsultCreateSubInstitutionRequestSettleInfo settleInfo;

    /**
     * <p>解决方案，包含清算、费率规则</p>
     */
    @NameInMap("solution")
    public String solution;

    /**
     * <p>子机构地址信息</p>
     */
    @NameInMap("subInstAddressInfo")
    public ConsultCreateSubInstitutionRequestSubInstAddressInfo subInstAddressInfo;

    /**
     * <p>授权信息</p>
     */
    @NameInMap("subInstAuthInfo")
    public ConsultCreateSubInstitutionRequestSubInstAuthInfo subInstAuthInfo;

    /**
     * <p>子机构基本信息</p>
     */
    @NameInMap("subInstBasicInfo")
    public ConsultCreateSubInstitutionRequestSubInstBasicInfo subInstBasicInfo;

    /**
     * <p>子机构认证信息</p>
     */
    @NameInMap("subInstCertifyInfo")
    public ConsultCreateSubInstitutionRequestSubInstCertifyInfo subInstCertifyInfo;

    /**
     * <p>子机构编号</p>
     */
    @NameInMap("subInstId")
    public String subInstId;

    /**
     * <p>开票信息</p>
     */
    @NameInMap("subInstInvoiceInfo")
    public ConsultCreateSubInstitutionRequestSubInstInvoiceInfo subInstInvoiceInfo;

    /**
     * <p>子机构门店信息</p>
     */
    @NameInMap("subInstShopInfo")
    public ConsultCreateSubInstitutionRequestSubInstShopInfo subInstShopInfo;

    public static ConsultCreateSubInstitutionRequest build(java.util.Map<String, ?> map) throws Exception {
        ConsultCreateSubInstitutionRequest self = new ConsultCreateSubInstitutionRequest();
        return TeaModel.build(map, self);
    }

    public ConsultCreateSubInstitutionRequest setBindingAlipayLogonId(String bindingAlipayLogonId) {
        this.bindingAlipayLogonId = bindingAlipayLogonId;
        return this;
    }
    public String getBindingAlipayLogonId() {
        return this.bindingAlipayLogonId;
    }

    public ConsultCreateSubInstitutionRequest setContactInfo(ConsultCreateSubInstitutionRequestContactInfo contactInfo) {
        this.contactInfo = contactInfo;
        return this;
    }
    public ConsultCreateSubInstitutionRequestContactInfo getContactInfo() {
        return this.contactInfo;
    }

    public ConsultCreateSubInstitutionRequest setInstId(String instId) {
        this.instId = instId;
        return this;
    }
    public String getInstId() {
        return this.instId;
    }

    public ConsultCreateSubInstitutionRequest setLegalPersonCertInfo(ConsultCreateSubInstitutionRequestLegalPersonCertInfo legalPersonCertInfo) {
        this.legalPersonCertInfo = legalPersonCertInfo;
        return this;
    }
    public ConsultCreateSubInstitutionRequestLegalPersonCertInfo getLegalPersonCertInfo() {
        return this.legalPersonCertInfo;
    }

    public ConsultCreateSubInstitutionRequest setOutTradeNo(String outTradeNo) {
        this.outTradeNo = outTradeNo;
        return this;
    }
    public String getOutTradeNo() {
        return this.outTradeNo;
    }

    public ConsultCreateSubInstitutionRequest setPayChannel(String payChannel) {
        this.payChannel = payChannel;
        return this;
    }
    public String getPayChannel() {
        return this.payChannel;
    }

    public ConsultCreateSubInstitutionRequest setQualificationInfos(java.util.List<ConsultCreateSubInstitutionRequestQualificationInfos> qualificationInfos) {
        this.qualificationInfos = qualificationInfos;
        return this;
    }
    public java.util.List<ConsultCreateSubInstitutionRequestQualificationInfos> getQualificationInfos() {
        return this.qualificationInfos;
    }

    public ConsultCreateSubInstitutionRequest setServices(java.util.List<String> services) {
        this.services = services;
        return this;
    }
    public java.util.List<String> getServices() {
        return this.services;
    }

    public ConsultCreateSubInstitutionRequest setSettleInfo(ConsultCreateSubInstitutionRequestSettleInfo settleInfo) {
        this.settleInfo = settleInfo;
        return this;
    }
    public ConsultCreateSubInstitutionRequestSettleInfo getSettleInfo() {
        return this.settleInfo;
    }

    public ConsultCreateSubInstitutionRequest setSolution(String solution) {
        this.solution = solution;
        return this;
    }
    public String getSolution() {
        return this.solution;
    }

    public ConsultCreateSubInstitutionRequest setSubInstAddressInfo(ConsultCreateSubInstitutionRequestSubInstAddressInfo subInstAddressInfo) {
        this.subInstAddressInfo = subInstAddressInfo;
        return this;
    }
    public ConsultCreateSubInstitutionRequestSubInstAddressInfo getSubInstAddressInfo() {
        return this.subInstAddressInfo;
    }

    public ConsultCreateSubInstitutionRequest setSubInstAuthInfo(ConsultCreateSubInstitutionRequestSubInstAuthInfo subInstAuthInfo) {
        this.subInstAuthInfo = subInstAuthInfo;
        return this;
    }
    public ConsultCreateSubInstitutionRequestSubInstAuthInfo getSubInstAuthInfo() {
        return this.subInstAuthInfo;
    }

    public ConsultCreateSubInstitutionRequest setSubInstBasicInfo(ConsultCreateSubInstitutionRequestSubInstBasicInfo subInstBasicInfo) {
        this.subInstBasicInfo = subInstBasicInfo;
        return this;
    }
    public ConsultCreateSubInstitutionRequestSubInstBasicInfo getSubInstBasicInfo() {
        return this.subInstBasicInfo;
    }

    public ConsultCreateSubInstitutionRequest setSubInstCertifyInfo(ConsultCreateSubInstitutionRequestSubInstCertifyInfo subInstCertifyInfo) {
        this.subInstCertifyInfo = subInstCertifyInfo;
        return this;
    }
    public ConsultCreateSubInstitutionRequestSubInstCertifyInfo getSubInstCertifyInfo() {
        return this.subInstCertifyInfo;
    }

    public ConsultCreateSubInstitutionRequest setSubInstId(String subInstId) {
        this.subInstId = subInstId;
        return this;
    }
    public String getSubInstId() {
        return this.subInstId;
    }

    public ConsultCreateSubInstitutionRequest setSubInstInvoiceInfo(ConsultCreateSubInstitutionRequestSubInstInvoiceInfo subInstInvoiceInfo) {
        this.subInstInvoiceInfo = subInstInvoiceInfo;
        return this;
    }
    public ConsultCreateSubInstitutionRequestSubInstInvoiceInfo getSubInstInvoiceInfo() {
        return this.subInstInvoiceInfo;
    }

    public ConsultCreateSubInstitutionRequest setSubInstShopInfo(ConsultCreateSubInstitutionRequestSubInstShopInfo subInstShopInfo) {
        this.subInstShopInfo = subInstShopInfo;
        return this;
    }
    public ConsultCreateSubInstitutionRequestSubInstShopInfo getSubInstShopInfo() {
        return this.subInstShopInfo;
    }

    public static class ConsultCreateSubInstitutionRequestContactInfo extends TeaModel {
        /**
         * <p>联系人姓名</p>
         */
        @NameInMap("contactName")
        public String contactName;

        /**
         * <p>联系人手机号</p>
         */
        @NameInMap("mobile")
        public String mobile;

        public static ConsultCreateSubInstitutionRequestContactInfo build(java.util.Map<String, ?> map) throws Exception {
            ConsultCreateSubInstitutionRequestContactInfo self = new ConsultCreateSubInstitutionRequestContactInfo();
            return TeaModel.build(map, self);
        }

        public ConsultCreateSubInstitutionRequestContactInfo setContactName(String contactName) {
            this.contactName = contactName;
            return this;
        }
        public String getContactName() {
            return this.contactName;
        }

        public ConsultCreateSubInstitutionRequestContactInfo setMobile(String mobile) {
            this.mobile = mobile;
            return this;
        }
        public String getMobile() {
            return this.mobile;
        }

    }

    public static class ConsultCreateSubInstitutionRequestLegalPersonCertInfo extends TeaModel {
        /**
         * <p>法人证件反面url</p>
         */
        @NameInMap("certBackImage")
        public String certBackImage;

        /**
         * <p>法人证件正面url</p>
         */
        @NameInMap("certFrontImage")
        public String certFrontImage;

        /**
         * <p>法人姓名</p>
         */
        @NameInMap("certName")
        public String certName;

        /**
         * <p>法人证件类型 不填默认为身份证</p>
         */
        @NameInMap("certType")
        public String certType;

        /**
         * <p>法人证件号</p>
         */
        @NameInMap("idCardNo")
        public String idCardNo;

        public static ConsultCreateSubInstitutionRequestLegalPersonCertInfo build(java.util.Map<String, ?> map) throws Exception {
            ConsultCreateSubInstitutionRequestLegalPersonCertInfo self = new ConsultCreateSubInstitutionRequestLegalPersonCertInfo();
            return TeaModel.build(map, self);
        }

        public ConsultCreateSubInstitutionRequestLegalPersonCertInfo setCertBackImage(String certBackImage) {
            this.certBackImage = certBackImage;
            return this;
        }
        public String getCertBackImage() {
            return this.certBackImage;
        }

        public ConsultCreateSubInstitutionRequestLegalPersonCertInfo setCertFrontImage(String certFrontImage) {
            this.certFrontImage = certFrontImage;
            return this;
        }
        public String getCertFrontImage() {
            return this.certFrontImage;
        }

        public ConsultCreateSubInstitutionRequestLegalPersonCertInfo setCertName(String certName) {
            this.certName = certName;
            return this;
        }
        public String getCertName() {
            return this.certName;
        }

        public ConsultCreateSubInstitutionRequestLegalPersonCertInfo setCertType(String certType) {
            this.certType = certType;
            return this;
        }
        public String getCertType() {
            return this.certType;
        }

        public ConsultCreateSubInstitutionRequestLegalPersonCertInfo setIdCardNo(String idCardNo) {
            this.idCardNo = idCardNo;
            return this;
        }
        public String getIdCardNo() {
            return this.idCardNo;
        }

    }

    public static class ConsultCreateSubInstitutionRequestQualificationInfos extends TeaModel {
        /**
         * <p>子机构行业资质图片</p>
         */
        @NameInMap("qualificationImage")
        public String qualificationImage;

        /**
         * <p>子机构行业资质类型</p>
         */
        @NameInMap("qualificationType")
        public String qualificationType;

        public static ConsultCreateSubInstitutionRequestQualificationInfos build(java.util.Map<String, ?> map) throws Exception {
            ConsultCreateSubInstitutionRequestQualificationInfos self = new ConsultCreateSubInstitutionRequestQualificationInfos();
            return TeaModel.build(map, self);
        }

        public ConsultCreateSubInstitutionRequestQualificationInfos setQualificationImage(String qualificationImage) {
            this.qualificationImage = qualificationImage;
            return this;
        }
        public String getQualificationImage() {
            return this.qualificationImage;
        }

        public ConsultCreateSubInstitutionRequestQualificationInfos setQualificationType(String qualificationType) {
            this.qualificationType = qualificationType;
            return this;
        }
        public String getQualificationType() {
            return this.qualificationType;
        }

    }

    public static class ConsultCreateSubInstitutionRequestSettleInfo extends TeaModel {
        /**
         * <p>账户账号</p>
         */
        @NameInMap("accountId")
        public String accountId;

        /**
         * <p>账户名称 账号类型银行卡时为卡户名</p>
         */
        @NameInMap("accountName")
        public String accountName;

        /**
         * <p>卡类型</p>
         */
        @NameInMap("accountType")
        public String accountType;

        /**
         * <p>支行名称</p>
         */
        @NameInMap("bankBranchName")
        public String bankBranchName;

        /**
         * <p>开户行所在地 市</p>
         */
        @NameInMap("bankCity")
        public String bankCity;

        /**
         * <p>联行号</p>
         */
        @NameInMap("bankCode")
        public String bankCode;

        /**
         * <p>银行名称</p>
         */
        @NameInMap("bankName")
        public String bankName;

        /**
         * <p>开户行所在地 省</p>
         */
        @NameInMap("bankProvince")
        public String bankProvince;

        /**
         * <p>开户行简称缩写</p>
         */
        @NameInMap("bankShortNameCode")
        public String bankShortNameCode;

        /**
         * <p>账号类型</p>
         */
        @NameInMap("type")
        public String type;

        /**
         * <p>账户使用类型</p>
         */
        @NameInMap("usageType")
        public String usageType;

        public static ConsultCreateSubInstitutionRequestSettleInfo build(java.util.Map<String, ?> map) throws Exception {
            ConsultCreateSubInstitutionRequestSettleInfo self = new ConsultCreateSubInstitutionRequestSettleInfo();
            return TeaModel.build(map, self);
        }

        public ConsultCreateSubInstitutionRequestSettleInfo setAccountId(String accountId) {
            this.accountId = accountId;
            return this;
        }
        public String getAccountId() {
            return this.accountId;
        }

        public ConsultCreateSubInstitutionRequestSettleInfo setAccountName(String accountName) {
            this.accountName = accountName;
            return this;
        }
        public String getAccountName() {
            return this.accountName;
        }

        public ConsultCreateSubInstitutionRequestSettleInfo setAccountType(String accountType) {
            this.accountType = accountType;
            return this;
        }
        public String getAccountType() {
            return this.accountType;
        }

        public ConsultCreateSubInstitutionRequestSettleInfo setBankBranchName(String bankBranchName) {
            this.bankBranchName = bankBranchName;
            return this;
        }
        public String getBankBranchName() {
            return this.bankBranchName;
        }

        public ConsultCreateSubInstitutionRequestSettleInfo setBankCity(String bankCity) {
            this.bankCity = bankCity;
            return this;
        }
        public String getBankCity() {
            return this.bankCity;
        }

        public ConsultCreateSubInstitutionRequestSettleInfo setBankCode(String bankCode) {
            this.bankCode = bankCode;
            return this;
        }
        public String getBankCode() {
            return this.bankCode;
        }

        public ConsultCreateSubInstitutionRequestSettleInfo setBankName(String bankName) {
            this.bankName = bankName;
            return this;
        }
        public String getBankName() {
            return this.bankName;
        }

        public ConsultCreateSubInstitutionRequestSettleInfo setBankProvince(String bankProvince) {
            this.bankProvince = bankProvince;
            return this;
        }
        public String getBankProvince() {
            return this.bankProvince;
        }

        public ConsultCreateSubInstitutionRequestSettleInfo setBankShortNameCode(String bankShortNameCode) {
            this.bankShortNameCode = bankShortNameCode;
            return this;
        }
        public String getBankShortNameCode() {
            return this.bankShortNameCode;
        }

        public ConsultCreateSubInstitutionRequestSettleInfo setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public ConsultCreateSubInstitutionRequestSettleInfo setUsageType(String usageType) {
            this.usageType = usageType;
            return this;
        }
        public String getUsageType() {
            return this.usageType;
        }

    }

    public static class ConsultCreateSubInstitutionRequestSubInstAddressInfo extends TeaModel {
        /**
         * <p>详细地址</p>
         */
        @NameInMap("address")
        public String address;

        /**
         * <p>市码</p>
         */
        @NameInMap("cityCode")
        public String cityCode;

        /**
         * <p>区码</p>
         */
        @NameInMap("districtCode")
        public String districtCode;

        /**
         * <p>省码</p>
         */
        @NameInMap("provinceCode")
        public String provinceCode;

        public static ConsultCreateSubInstitutionRequestSubInstAddressInfo build(java.util.Map<String, ?> map) throws Exception {
            ConsultCreateSubInstitutionRequestSubInstAddressInfo self = new ConsultCreateSubInstitutionRequestSubInstAddressInfo();
            return TeaModel.build(map, self);
        }

        public ConsultCreateSubInstitutionRequestSubInstAddressInfo setAddress(String address) {
            this.address = address;
            return this;
        }
        public String getAddress() {
            return this.address;
        }

        public ConsultCreateSubInstitutionRequestSubInstAddressInfo setCityCode(String cityCode) {
            this.cityCode = cityCode;
            return this;
        }
        public String getCityCode() {
            return this.cityCode;
        }

        public ConsultCreateSubInstitutionRequestSubInstAddressInfo setDistrictCode(String districtCode) {
            this.districtCode = districtCode;
            return this;
        }
        public String getDistrictCode() {
            return this.districtCode;
        }

        public ConsultCreateSubInstitutionRequestSubInstAddressInfo setProvinceCode(String provinceCode) {
            this.provinceCode = provinceCode;
            return this;
        }
        public String getProvinceCode() {
            return this.provinceCode;
        }

    }

    public static class ConsultCreateSubInstitutionRequestSubInstAuthInfo extends TeaModel {
        /**
         * <p>授权函图片url</p>
         */
        @NameInMap("authorizationLetterUrl")
        public String authorizationLetterUrl;

        public static ConsultCreateSubInstitutionRequestSubInstAuthInfo build(java.util.Map<String, ?> map) throws Exception {
            ConsultCreateSubInstitutionRequestSubInstAuthInfo self = new ConsultCreateSubInstitutionRequestSubInstAuthInfo();
            return TeaModel.build(map, self);
        }

        public ConsultCreateSubInstitutionRequestSubInstAuthInfo setAuthorizationLetterUrl(String authorizationLetterUrl) {
            this.authorizationLetterUrl = authorizationLetterUrl;
            return this;
        }
        public String getAuthorizationLetterUrl() {
            return this.authorizationLetterUrl;
        }

    }

    public static class ConsultCreateSubInstitutionRequestSubInstBasicInfo extends TeaModel {
        /**
         * <p>别名</p>
         */
        @NameInMap("aliasName")
        public String aliasName;

        /**
         * <p>机构识别码</p>
         */
        @NameInMap("mcc")
        public String mcc;

        /**
         * <p>名称</p>
         */
        @NameInMap("subInstName")
        public String subInstName;

        /**
         * <p>类型</p>
         */
        @NameInMap("type")
        public String type;

        public static ConsultCreateSubInstitutionRequestSubInstBasicInfo build(java.util.Map<String, ?> map) throws Exception {
            ConsultCreateSubInstitutionRequestSubInstBasicInfo self = new ConsultCreateSubInstitutionRequestSubInstBasicInfo();
            return TeaModel.build(map, self);
        }

        public ConsultCreateSubInstitutionRequestSubInstBasicInfo setAliasName(String aliasName) {
            this.aliasName = aliasName;
            return this;
        }
        public String getAliasName() {
            return this.aliasName;
        }

        public ConsultCreateSubInstitutionRequestSubInstBasicInfo setMcc(String mcc) {
            this.mcc = mcc;
            return this;
        }
        public String getMcc() {
            return this.mcc;
        }

        public ConsultCreateSubInstitutionRequestSubInstBasicInfo setSubInstName(String subInstName) {
            this.subInstName = subInstName;
            return this;
        }
        public String getSubInstName() {
            return this.subInstName;
        }

        public ConsultCreateSubInstitutionRequestSubInstBasicInfo setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class ConsultCreateSubInstitutionRequestSubInstCertifyInfo extends TeaModel {
        /**
         * <p>证件图片, 如果是特殊行业必填</p>
         */
        @NameInMap("certImage")
        public String certImage;

        /**
         * <p>证件号码</p>
         */
        @NameInMap("certNo")
        public String certNo;

        /**
         * <p>证件类型</p>
         */
        @NameInMap("certType")
        public String certType;

        public static ConsultCreateSubInstitutionRequestSubInstCertifyInfo build(java.util.Map<String, ?> map) throws Exception {
            ConsultCreateSubInstitutionRequestSubInstCertifyInfo self = new ConsultCreateSubInstitutionRequestSubInstCertifyInfo();
            return TeaModel.build(map, self);
        }

        public ConsultCreateSubInstitutionRequestSubInstCertifyInfo setCertImage(String certImage) {
            this.certImage = certImage;
            return this;
        }
        public String getCertImage() {
            return this.certImage;
        }

        public ConsultCreateSubInstitutionRequestSubInstCertifyInfo setCertNo(String certNo) {
            this.certNo = certNo;
            return this;
        }
        public String getCertNo() {
            return this.certNo;
        }

        public ConsultCreateSubInstitutionRequestSubInstCertifyInfo setCertType(String certType) {
            this.certType = certType;
            return this;
        }
        public String getCertType() {
            return this.certType;
        }

    }

    public static class ConsultCreateSubInstitutionRequestSubInstInvoiceInfoMailAddress extends TeaModel {
        /**
         * <p>详细地址</p>
         */
        @NameInMap("address")
        public String address;

        /**
         * <p>市码</p>
         */
        @NameInMap("cityCode")
        public String cityCode;

        /**
         * <p>区码</p>
         */
        @NameInMap("districtCode")
        public String districtCode;

        /**
         * <p>省码</p>
         */
        @NameInMap("provinceCode")
        public String provinceCode;

        public static ConsultCreateSubInstitutionRequestSubInstInvoiceInfoMailAddress build(java.util.Map<String, ?> map) throws Exception {
            ConsultCreateSubInstitutionRequestSubInstInvoiceInfoMailAddress self = new ConsultCreateSubInstitutionRequestSubInstInvoiceInfoMailAddress();
            return TeaModel.build(map, self);
        }

        public ConsultCreateSubInstitutionRequestSubInstInvoiceInfoMailAddress setAddress(String address) {
            this.address = address;
            return this;
        }
        public String getAddress() {
            return this.address;
        }

        public ConsultCreateSubInstitutionRequestSubInstInvoiceInfoMailAddress setCityCode(String cityCode) {
            this.cityCode = cityCode;
            return this;
        }
        public String getCityCode() {
            return this.cityCode;
        }

        public ConsultCreateSubInstitutionRequestSubInstInvoiceInfoMailAddress setDistrictCode(String districtCode) {
            this.districtCode = districtCode;
            return this;
        }
        public String getDistrictCode() {
            return this.districtCode;
        }

        public ConsultCreateSubInstitutionRequestSubInstInvoiceInfoMailAddress setProvinceCode(String provinceCode) {
            this.provinceCode = provinceCode;
            return this;
        }
        public String getProvinceCode() {
            return this.provinceCode;
        }

    }

    public static class ConsultCreateSubInstitutionRequestSubInstInvoiceInfo extends TeaModel {
        /**
         * <p>是否接受电票</p>
         */
        @NameInMap("acceptElectronic")
        public Boolean acceptElectronic;

        /**
         * <p>开票地址</p>
         */
        @NameInMap("address")
        public String address;

        /**
         * <p>是否自动开票</p>
         */
        @NameInMap("autoInvoice")
        public Boolean autoInvoice;

        /**
         * <p>银行账户</p>
         */
        @NameInMap("bankAccount")
        public String bankAccount;

        /**
         * <p>银行名称</p>
         */
        @NameInMap("bankName")
        public String bankName;

        /**
         * <p>收件地址</p>
         */
        @NameInMap("mailAddress")
        public ConsultCreateSubInstitutionRequestSubInstInvoiceInfoMailAddress mailAddress;

        /**
         * <p>收件人名称</p>
         */
        @NameInMap("mailName")
        public String mailName;

        /**
         * <p>收件人号码</p>
         */
        @NameInMap("mailPhone")
        public String mailPhone;

        /**
         * <p>纳税人识别号</p>
         */
        @NameInMap("taxNo")
        public String taxNo;

        /**
         * <p>纳税人资质</p>
         */
        @NameInMap("taxPayerQualification")
        public String taxPayerQualification;

        /**
         * <p>纳税人资格开始时间</p>
         */
        @NameInMap("taxPayerValidDate")
        public String taxPayerValidDate;

        /**
         * <p>开票电话</p>
         */
        @NameInMap("telephone")
        public String telephone;

        /**
         * <p>纳税人抬头</p>
         */
        @NameInMap("title")
        public String title;

        public static ConsultCreateSubInstitutionRequestSubInstInvoiceInfo build(java.util.Map<String, ?> map) throws Exception {
            ConsultCreateSubInstitutionRequestSubInstInvoiceInfo self = new ConsultCreateSubInstitutionRequestSubInstInvoiceInfo();
            return TeaModel.build(map, self);
        }

        public ConsultCreateSubInstitutionRequestSubInstInvoiceInfo setAcceptElectronic(Boolean acceptElectronic) {
            this.acceptElectronic = acceptElectronic;
            return this;
        }
        public Boolean getAcceptElectronic() {
            return this.acceptElectronic;
        }

        public ConsultCreateSubInstitutionRequestSubInstInvoiceInfo setAddress(String address) {
            this.address = address;
            return this;
        }
        public String getAddress() {
            return this.address;
        }

        public ConsultCreateSubInstitutionRequestSubInstInvoiceInfo setAutoInvoice(Boolean autoInvoice) {
            this.autoInvoice = autoInvoice;
            return this;
        }
        public Boolean getAutoInvoice() {
            return this.autoInvoice;
        }

        public ConsultCreateSubInstitutionRequestSubInstInvoiceInfo setBankAccount(String bankAccount) {
            this.bankAccount = bankAccount;
            return this;
        }
        public String getBankAccount() {
            return this.bankAccount;
        }

        public ConsultCreateSubInstitutionRequestSubInstInvoiceInfo setBankName(String bankName) {
            this.bankName = bankName;
            return this;
        }
        public String getBankName() {
            return this.bankName;
        }

        public ConsultCreateSubInstitutionRequestSubInstInvoiceInfo setMailAddress(ConsultCreateSubInstitutionRequestSubInstInvoiceInfoMailAddress mailAddress) {
            this.mailAddress = mailAddress;
            return this;
        }
        public ConsultCreateSubInstitutionRequestSubInstInvoiceInfoMailAddress getMailAddress() {
            return this.mailAddress;
        }

        public ConsultCreateSubInstitutionRequestSubInstInvoiceInfo setMailName(String mailName) {
            this.mailName = mailName;
            return this;
        }
        public String getMailName() {
            return this.mailName;
        }

        public ConsultCreateSubInstitutionRequestSubInstInvoiceInfo setMailPhone(String mailPhone) {
            this.mailPhone = mailPhone;
            return this;
        }
        public String getMailPhone() {
            return this.mailPhone;
        }

        public ConsultCreateSubInstitutionRequestSubInstInvoiceInfo setTaxNo(String taxNo) {
            this.taxNo = taxNo;
            return this;
        }
        public String getTaxNo() {
            return this.taxNo;
        }

        public ConsultCreateSubInstitutionRequestSubInstInvoiceInfo setTaxPayerQualification(String taxPayerQualification) {
            this.taxPayerQualification = taxPayerQualification;
            return this;
        }
        public String getTaxPayerQualification() {
            return this.taxPayerQualification;
        }

        public ConsultCreateSubInstitutionRequestSubInstInvoiceInfo setTaxPayerValidDate(String taxPayerValidDate) {
            this.taxPayerValidDate = taxPayerValidDate;
            return this;
        }
        public String getTaxPayerValidDate() {
            return this.taxPayerValidDate;
        }

        public ConsultCreateSubInstitutionRequestSubInstInvoiceInfo setTelephone(String telephone) {
            this.telephone = telephone;
            return this;
        }
        public String getTelephone() {
            return this.telephone;
        }

        public ConsultCreateSubInstitutionRequestSubInstInvoiceInfo setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class ConsultCreateSubInstitutionRequestSubInstShopInfo extends TeaModel {
        /**
         * <p>内景照</p>
         */
        @NameInMap("inDoorImages")
        public java.util.List<String> inDoorImages;

        /**
         * <p>外景照</p>
         */
        @NameInMap("outDoorImages")
        public java.util.List<String> outDoorImages;

        public static ConsultCreateSubInstitutionRequestSubInstShopInfo build(java.util.Map<String, ?> map) throws Exception {
            ConsultCreateSubInstitutionRequestSubInstShopInfo self = new ConsultCreateSubInstitutionRequestSubInstShopInfo();
            return TeaModel.build(map, self);
        }

        public ConsultCreateSubInstitutionRequestSubInstShopInfo setInDoorImages(java.util.List<String> inDoorImages) {
            this.inDoorImages = inDoorImages;
            return this;
        }
        public java.util.List<String> getInDoorImages() {
            return this.inDoorImages;
        }

        public ConsultCreateSubInstitutionRequestSubInstShopInfo setOutDoorImages(java.util.List<String> outDoorImages) {
            this.outDoorImages = outDoorImages;
            return this;
        }
        public java.util.List<String> getOutDoorImages() {
            return this.outDoorImages;
        }

    }

}
