// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class CreateSubInstitutionRequest extends TeaModel {
    /**
     * <p>签约支付宝账户，用于协议确认</p>
     */
    @NameInMap("bindingAlipayLogonId")
    public String bindingAlipayLogonId;

    /**
     * <p>联系人</p>
     */
    @NameInMap("contactInfo")
    public CreateSubInstitutionRequestContactInfo contactInfo;

    /**
     * <p>主机构编号</p>
     */
    @NameInMap("instId")
    public String instId;

    @NameInMap("legalPersonCertInfo")
    public CreateSubInstitutionRequestLegalPersonCertInfo legalPersonCertInfo;

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
    public java.util.List<CreateSubInstitutionRequestQualificationInfos> qualificationInfos;

    /**
     * <p>开通的服务类型</p>
     */
    @NameInMap("services")
    public java.util.List<String> services;

    /**
     * <p>资金账户信息</p>
     */
    @NameInMap("settleInfo")
    public CreateSubInstitutionRequestSettleInfo settleInfo;

    /**
     * <p>解决方案，包含费率、清算规则等</p>
     */
    @NameInMap("solution")
    public String solution;

    /**
     * <p>子机构地址信息</p>
     */
    @NameInMap("subInstAddressInfo")
    public CreateSubInstitutionRequestSubInstAddressInfo subInstAddressInfo;

    /**
     * <p>授权信息</p>
     */
    @NameInMap("subInstAuthInfo")
    public CreateSubInstitutionRequestSubInstAuthInfo subInstAuthInfo;

    /**
     * <p>子机构基本信息</p>
     */
    @NameInMap("subInstBasicInfo")
    public CreateSubInstitutionRequestSubInstBasicInfo subInstBasicInfo;

    /**
     * <p>子机构认证信息</p>
     */
    @NameInMap("subInstCertifyInfo")
    public CreateSubInstitutionRequestSubInstCertifyInfo subInstCertifyInfo;

    /**
     * <p>子机构编号</p>
     */
    @NameInMap("subInstId")
    public String subInstId;

    /**
     * <p>开票信息</p>
     */
    @NameInMap("subInstInvoiceInfo")
    public CreateSubInstitutionRequestSubInstInvoiceInfo subInstInvoiceInfo;

    /**
     * <p>子机构门店信息</p>
     */
    @NameInMap("subInstShopInfo")
    public CreateSubInstitutionRequestSubInstShopInfo subInstShopInfo;

    public static CreateSubInstitutionRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateSubInstitutionRequest self = new CreateSubInstitutionRequest();
        return TeaModel.build(map, self);
    }

    public CreateSubInstitutionRequest setBindingAlipayLogonId(String bindingAlipayLogonId) {
        this.bindingAlipayLogonId = bindingAlipayLogonId;
        return this;
    }
    public String getBindingAlipayLogonId() {
        return this.bindingAlipayLogonId;
    }

    public CreateSubInstitutionRequest setContactInfo(CreateSubInstitutionRequestContactInfo contactInfo) {
        this.contactInfo = contactInfo;
        return this;
    }
    public CreateSubInstitutionRequestContactInfo getContactInfo() {
        return this.contactInfo;
    }

    public CreateSubInstitutionRequest setInstId(String instId) {
        this.instId = instId;
        return this;
    }
    public String getInstId() {
        return this.instId;
    }

    public CreateSubInstitutionRequest setLegalPersonCertInfo(CreateSubInstitutionRequestLegalPersonCertInfo legalPersonCertInfo) {
        this.legalPersonCertInfo = legalPersonCertInfo;
        return this;
    }
    public CreateSubInstitutionRequestLegalPersonCertInfo getLegalPersonCertInfo() {
        return this.legalPersonCertInfo;
    }

    public CreateSubInstitutionRequest setOutTradeNo(String outTradeNo) {
        this.outTradeNo = outTradeNo;
        return this;
    }
    public String getOutTradeNo() {
        return this.outTradeNo;
    }

    public CreateSubInstitutionRequest setPayChannel(String payChannel) {
        this.payChannel = payChannel;
        return this;
    }
    public String getPayChannel() {
        return this.payChannel;
    }

    public CreateSubInstitutionRequest setQualificationInfos(java.util.List<CreateSubInstitutionRequestQualificationInfos> qualificationInfos) {
        this.qualificationInfos = qualificationInfos;
        return this;
    }
    public java.util.List<CreateSubInstitutionRequestQualificationInfos> getQualificationInfos() {
        return this.qualificationInfos;
    }

    public CreateSubInstitutionRequest setServices(java.util.List<String> services) {
        this.services = services;
        return this;
    }
    public java.util.List<String> getServices() {
        return this.services;
    }

    public CreateSubInstitutionRequest setSettleInfo(CreateSubInstitutionRequestSettleInfo settleInfo) {
        this.settleInfo = settleInfo;
        return this;
    }
    public CreateSubInstitutionRequestSettleInfo getSettleInfo() {
        return this.settleInfo;
    }

    public CreateSubInstitutionRequest setSolution(String solution) {
        this.solution = solution;
        return this;
    }
    public String getSolution() {
        return this.solution;
    }

    public CreateSubInstitutionRequest setSubInstAddressInfo(CreateSubInstitutionRequestSubInstAddressInfo subInstAddressInfo) {
        this.subInstAddressInfo = subInstAddressInfo;
        return this;
    }
    public CreateSubInstitutionRequestSubInstAddressInfo getSubInstAddressInfo() {
        return this.subInstAddressInfo;
    }

    public CreateSubInstitutionRequest setSubInstAuthInfo(CreateSubInstitutionRequestSubInstAuthInfo subInstAuthInfo) {
        this.subInstAuthInfo = subInstAuthInfo;
        return this;
    }
    public CreateSubInstitutionRequestSubInstAuthInfo getSubInstAuthInfo() {
        return this.subInstAuthInfo;
    }

    public CreateSubInstitutionRequest setSubInstBasicInfo(CreateSubInstitutionRequestSubInstBasicInfo subInstBasicInfo) {
        this.subInstBasicInfo = subInstBasicInfo;
        return this;
    }
    public CreateSubInstitutionRequestSubInstBasicInfo getSubInstBasicInfo() {
        return this.subInstBasicInfo;
    }

    public CreateSubInstitutionRequest setSubInstCertifyInfo(CreateSubInstitutionRequestSubInstCertifyInfo subInstCertifyInfo) {
        this.subInstCertifyInfo = subInstCertifyInfo;
        return this;
    }
    public CreateSubInstitutionRequestSubInstCertifyInfo getSubInstCertifyInfo() {
        return this.subInstCertifyInfo;
    }

    public CreateSubInstitutionRequest setSubInstId(String subInstId) {
        this.subInstId = subInstId;
        return this;
    }
    public String getSubInstId() {
        return this.subInstId;
    }

    public CreateSubInstitutionRequest setSubInstInvoiceInfo(CreateSubInstitutionRequestSubInstInvoiceInfo subInstInvoiceInfo) {
        this.subInstInvoiceInfo = subInstInvoiceInfo;
        return this;
    }
    public CreateSubInstitutionRequestSubInstInvoiceInfo getSubInstInvoiceInfo() {
        return this.subInstInvoiceInfo;
    }

    public CreateSubInstitutionRequest setSubInstShopInfo(CreateSubInstitutionRequestSubInstShopInfo subInstShopInfo) {
        this.subInstShopInfo = subInstShopInfo;
        return this;
    }
    public CreateSubInstitutionRequestSubInstShopInfo getSubInstShopInfo() {
        return this.subInstShopInfo;
    }

    public static class CreateSubInstitutionRequestContactInfo extends TeaModel {
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

        public static CreateSubInstitutionRequestContactInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateSubInstitutionRequestContactInfo self = new CreateSubInstitutionRequestContactInfo();
            return TeaModel.build(map, self);
        }

        public CreateSubInstitutionRequestContactInfo setContactName(String contactName) {
            this.contactName = contactName;
            return this;
        }
        public String getContactName() {
            return this.contactName;
        }

        public CreateSubInstitutionRequestContactInfo setMobile(String mobile) {
            this.mobile = mobile;
            return this;
        }
        public String getMobile() {
            return this.mobile;
        }

    }

    public static class CreateSubInstitutionRequestLegalPersonCertInfo extends TeaModel {
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

        public static CreateSubInstitutionRequestLegalPersonCertInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateSubInstitutionRequestLegalPersonCertInfo self = new CreateSubInstitutionRequestLegalPersonCertInfo();
            return TeaModel.build(map, self);
        }

        public CreateSubInstitutionRequestLegalPersonCertInfo setCertBackImage(String certBackImage) {
            this.certBackImage = certBackImage;
            return this;
        }
        public String getCertBackImage() {
            return this.certBackImage;
        }

        public CreateSubInstitutionRequestLegalPersonCertInfo setCertFrontImage(String certFrontImage) {
            this.certFrontImage = certFrontImage;
            return this;
        }
        public String getCertFrontImage() {
            return this.certFrontImage;
        }

        public CreateSubInstitutionRequestLegalPersonCertInfo setCertName(String certName) {
            this.certName = certName;
            return this;
        }
        public String getCertName() {
            return this.certName;
        }

        public CreateSubInstitutionRequestLegalPersonCertInfo setCertType(String certType) {
            this.certType = certType;
            return this;
        }
        public String getCertType() {
            return this.certType;
        }

        public CreateSubInstitutionRequestLegalPersonCertInfo setIdCardNo(String idCardNo) {
            this.idCardNo = idCardNo;
            return this;
        }
        public String getIdCardNo() {
            return this.idCardNo;
        }

    }

    public static class CreateSubInstitutionRequestQualificationInfos extends TeaModel {
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

        public static CreateSubInstitutionRequestQualificationInfos build(java.util.Map<String, ?> map) throws Exception {
            CreateSubInstitutionRequestQualificationInfos self = new CreateSubInstitutionRequestQualificationInfos();
            return TeaModel.build(map, self);
        }

        public CreateSubInstitutionRequestQualificationInfos setQualificationImage(String qualificationImage) {
            this.qualificationImage = qualificationImage;
            return this;
        }
        public String getQualificationImage() {
            return this.qualificationImage;
        }

        public CreateSubInstitutionRequestQualificationInfos setQualificationType(String qualificationType) {
            this.qualificationType = qualificationType;
            return this;
        }
        public String getQualificationType() {
            return this.qualificationType;
        }

    }

    public static class CreateSubInstitutionRequestSettleInfo extends TeaModel {
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
         * <p>卡类型, DEBIT_CARD借记卡，CREDIT_CARD信用卡</p>
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

        public static CreateSubInstitutionRequestSettleInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateSubInstitutionRequestSettleInfo self = new CreateSubInstitutionRequestSettleInfo();
            return TeaModel.build(map, self);
        }

        public CreateSubInstitutionRequestSettleInfo setAccountId(String accountId) {
            this.accountId = accountId;
            return this;
        }
        public String getAccountId() {
            return this.accountId;
        }

        public CreateSubInstitutionRequestSettleInfo setAccountName(String accountName) {
            this.accountName = accountName;
            return this;
        }
        public String getAccountName() {
            return this.accountName;
        }

        public CreateSubInstitutionRequestSettleInfo setAccountType(String accountType) {
            this.accountType = accountType;
            return this;
        }
        public String getAccountType() {
            return this.accountType;
        }

        public CreateSubInstitutionRequestSettleInfo setBankBranchName(String bankBranchName) {
            this.bankBranchName = bankBranchName;
            return this;
        }
        public String getBankBranchName() {
            return this.bankBranchName;
        }

        public CreateSubInstitutionRequestSettleInfo setBankCity(String bankCity) {
            this.bankCity = bankCity;
            return this;
        }
        public String getBankCity() {
            return this.bankCity;
        }

        public CreateSubInstitutionRequestSettleInfo setBankCode(String bankCode) {
            this.bankCode = bankCode;
            return this;
        }
        public String getBankCode() {
            return this.bankCode;
        }

        public CreateSubInstitutionRequestSettleInfo setBankName(String bankName) {
            this.bankName = bankName;
            return this;
        }
        public String getBankName() {
            return this.bankName;
        }

        public CreateSubInstitutionRequestSettleInfo setBankProvince(String bankProvince) {
            this.bankProvince = bankProvince;
            return this;
        }
        public String getBankProvince() {
            return this.bankProvince;
        }

        public CreateSubInstitutionRequestSettleInfo setBankShortNameCode(String bankShortNameCode) {
            this.bankShortNameCode = bankShortNameCode;
            return this;
        }
        public String getBankShortNameCode() {
            return this.bankShortNameCode;
        }

        public CreateSubInstitutionRequestSettleInfo setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public CreateSubInstitutionRequestSettleInfo setUsageType(String usageType) {
            this.usageType = usageType;
            return this;
        }
        public String getUsageType() {
            return this.usageType;
        }

    }

    public static class CreateSubInstitutionRequestSubInstAddressInfo extends TeaModel {
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

        public static CreateSubInstitutionRequestSubInstAddressInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateSubInstitutionRequestSubInstAddressInfo self = new CreateSubInstitutionRequestSubInstAddressInfo();
            return TeaModel.build(map, self);
        }

        public CreateSubInstitutionRequestSubInstAddressInfo setAddress(String address) {
            this.address = address;
            return this;
        }
        public String getAddress() {
            return this.address;
        }

        public CreateSubInstitutionRequestSubInstAddressInfo setCityCode(String cityCode) {
            this.cityCode = cityCode;
            return this;
        }
        public String getCityCode() {
            return this.cityCode;
        }

        public CreateSubInstitutionRequestSubInstAddressInfo setDistrictCode(String districtCode) {
            this.districtCode = districtCode;
            return this;
        }
        public String getDistrictCode() {
            return this.districtCode;
        }

        public CreateSubInstitutionRequestSubInstAddressInfo setProvinceCode(String provinceCode) {
            this.provinceCode = provinceCode;
            return this;
        }
        public String getProvinceCode() {
            return this.provinceCode;
        }

    }

    public static class CreateSubInstitutionRequestSubInstAuthInfo extends TeaModel {
        /**
         * <p>授权函图片url</p>
         */
        @NameInMap("authorizationLetterUrl")
        public String authorizationLetterUrl;

        public static CreateSubInstitutionRequestSubInstAuthInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateSubInstitutionRequestSubInstAuthInfo self = new CreateSubInstitutionRequestSubInstAuthInfo();
            return TeaModel.build(map, self);
        }

        public CreateSubInstitutionRequestSubInstAuthInfo setAuthorizationLetterUrl(String authorizationLetterUrl) {
            this.authorizationLetterUrl = authorizationLetterUrl;
            return this;
        }
        public String getAuthorizationLetterUrl() {
            return this.authorizationLetterUrl;
        }

    }

    public static class CreateSubInstitutionRequestSubInstBasicInfo extends TeaModel {
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

        public static CreateSubInstitutionRequestSubInstBasicInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateSubInstitutionRequestSubInstBasicInfo self = new CreateSubInstitutionRequestSubInstBasicInfo();
            return TeaModel.build(map, self);
        }

        public CreateSubInstitutionRequestSubInstBasicInfo setAliasName(String aliasName) {
            this.aliasName = aliasName;
            return this;
        }
        public String getAliasName() {
            return this.aliasName;
        }

        public CreateSubInstitutionRequestSubInstBasicInfo setMcc(String mcc) {
            this.mcc = mcc;
            return this;
        }
        public String getMcc() {
            return this.mcc;
        }

        public CreateSubInstitutionRequestSubInstBasicInfo setSubInstName(String subInstName) {
            this.subInstName = subInstName;
            return this;
        }
        public String getSubInstName() {
            return this.subInstName;
        }

        public CreateSubInstitutionRequestSubInstBasicInfo setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class CreateSubInstitutionRequestSubInstCertifyInfo extends TeaModel {
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

        public static CreateSubInstitutionRequestSubInstCertifyInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateSubInstitutionRequestSubInstCertifyInfo self = new CreateSubInstitutionRequestSubInstCertifyInfo();
            return TeaModel.build(map, self);
        }

        public CreateSubInstitutionRequestSubInstCertifyInfo setCertImage(String certImage) {
            this.certImage = certImage;
            return this;
        }
        public String getCertImage() {
            return this.certImage;
        }

        public CreateSubInstitutionRequestSubInstCertifyInfo setCertNo(String certNo) {
            this.certNo = certNo;
            return this;
        }
        public String getCertNo() {
            return this.certNo;
        }

        public CreateSubInstitutionRequestSubInstCertifyInfo setCertType(String certType) {
            this.certType = certType;
            return this;
        }
        public String getCertType() {
            return this.certType;
        }

    }

    public static class CreateSubInstitutionRequestSubInstInvoiceInfoMailAddress extends TeaModel {
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

        public static CreateSubInstitutionRequestSubInstInvoiceInfoMailAddress build(java.util.Map<String, ?> map) throws Exception {
            CreateSubInstitutionRequestSubInstInvoiceInfoMailAddress self = new CreateSubInstitutionRequestSubInstInvoiceInfoMailAddress();
            return TeaModel.build(map, self);
        }

        public CreateSubInstitutionRequestSubInstInvoiceInfoMailAddress setAddress(String address) {
            this.address = address;
            return this;
        }
        public String getAddress() {
            return this.address;
        }

        public CreateSubInstitutionRequestSubInstInvoiceInfoMailAddress setCityCode(String cityCode) {
            this.cityCode = cityCode;
            return this;
        }
        public String getCityCode() {
            return this.cityCode;
        }

        public CreateSubInstitutionRequestSubInstInvoiceInfoMailAddress setDistrictCode(String districtCode) {
            this.districtCode = districtCode;
            return this;
        }
        public String getDistrictCode() {
            return this.districtCode;
        }

        public CreateSubInstitutionRequestSubInstInvoiceInfoMailAddress setProvinceCode(String provinceCode) {
            this.provinceCode = provinceCode;
            return this;
        }
        public String getProvinceCode() {
            return this.provinceCode;
        }

    }

    public static class CreateSubInstitutionRequestSubInstInvoiceInfo extends TeaModel {
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
        public CreateSubInstitutionRequestSubInstInvoiceInfoMailAddress mailAddress;

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

        public static CreateSubInstitutionRequestSubInstInvoiceInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateSubInstitutionRequestSubInstInvoiceInfo self = new CreateSubInstitutionRequestSubInstInvoiceInfo();
            return TeaModel.build(map, self);
        }

        public CreateSubInstitutionRequestSubInstInvoiceInfo setAcceptElectronic(Boolean acceptElectronic) {
            this.acceptElectronic = acceptElectronic;
            return this;
        }
        public Boolean getAcceptElectronic() {
            return this.acceptElectronic;
        }

        public CreateSubInstitutionRequestSubInstInvoiceInfo setAddress(String address) {
            this.address = address;
            return this;
        }
        public String getAddress() {
            return this.address;
        }

        public CreateSubInstitutionRequestSubInstInvoiceInfo setAutoInvoice(Boolean autoInvoice) {
            this.autoInvoice = autoInvoice;
            return this;
        }
        public Boolean getAutoInvoice() {
            return this.autoInvoice;
        }

        public CreateSubInstitutionRequestSubInstInvoiceInfo setBankAccount(String bankAccount) {
            this.bankAccount = bankAccount;
            return this;
        }
        public String getBankAccount() {
            return this.bankAccount;
        }

        public CreateSubInstitutionRequestSubInstInvoiceInfo setBankName(String bankName) {
            this.bankName = bankName;
            return this;
        }
        public String getBankName() {
            return this.bankName;
        }

        public CreateSubInstitutionRequestSubInstInvoiceInfo setMailAddress(CreateSubInstitutionRequestSubInstInvoiceInfoMailAddress mailAddress) {
            this.mailAddress = mailAddress;
            return this;
        }
        public CreateSubInstitutionRequestSubInstInvoiceInfoMailAddress getMailAddress() {
            return this.mailAddress;
        }

        public CreateSubInstitutionRequestSubInstInvoiceInfo setMailName(String mailName) {
            this.mailName = mailName;
            return this;
        }
        public String getMailName() {
            return this.mailName;
        }

        public CreateSubInstitutionRequestSubInstInvoiceInfo setMailPhone(String mailPhone) {
            this.mailPhone = mailPhone;
            return this;
        }
        public String getMailPhone() {
            return this.mailPhone;
        }

        public CreateSubInstitutionRequestSubInstInvoiceInfo setTaxNo(String taxNo) {
            this.taxNo = taxNo;
            return this;
        }
        public String getTaxNo() {
            return this.taxNo;
        }

        public CreateSubInstitutionRequestSubInstInvoiceInfo setTaxPayerQualification(String taxPayerQualification) {
            this.taxPayerQualification = taxPayerQualification;
            return this;
        }
        public String getTaxPayerQualification() {
            return this.taxPayerQualification;
        }

        public CreateSubInstitutionRequestSubInstInvoiceInfo setTaxPayerValidDate(String taxPayerValidDate) {
            this.taxPayerValidDate = taxPayerValidDate;
            return this;
        }
        public String getTaxPayerValidDate() {
            return this.taxPayerValidDate;
        }

        public CreateSubInstitutionRequestSubInstInvoiceInfo setTelephone(String telephone) {
            this.telephone = telephone;
            return this;
        }
        public String getTelephone() {
            return this.telephone;
        }

        public CreateSubInstitutionRequestSubInstInvoiceInfo setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class CreateSubInstitutionRequestSubInstShopInfo extends TeaModel {
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

        public static CreateSubInstitutionRequestSubInstShopInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateSubInstitutionRequestSubInstShopInfo self = new CreateSubInstitutionRequestSubInstShopInfo();
            return TeaModel.build(map, self);
        }

        public CreateSubInstitutionRequestSubInstShopInfo setInDoorImages(java.util.List<String> inDoorImages) {
            this.inDoorImages = inDoorImages;
            return this;
        }
        public java.util.List<String> getInDoorImages() {
            return this.inDoorImages;
        }

        public CreateSubInstitutionRequestSubInstShopInfo setOutDoorImages(java.util.List<String> outDoorImages) {
            this.outDoorImages = outDoorImages;
            return this;
        }
        public java.util.List<String> getOutDoorImages() {
            return this.outDoorImages;
        }

    }

}
