// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class CreateSubInstitutionRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p><a href="mailto:asdf@163.com">asdf@163.com</a></p>
     */
    @NameInMap("bindingAlipayLogonId")
    public String bindingAlipayLogonId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("contactInfo")
    public CreateSubInstitutionRequestContactInfo contactInfo;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>202111090001</p>
     */
    @NameInMap("instId")
    public String instId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("legalPersonCertInfo")
    public CreateSubInstitutionRequestLegalPersonCertInfo legalPersonCertInfo;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2021000001</p>
     */
    @NameInMap("outTradeNo")
    public String outTradeNo;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ALIPAY</p>
     */
    @NameInMap("payChannel")
    public String payChannel;

    @NameInMap("qualificationInfos")
    public java.util.List<CreateSubInstitutionRequestQualificationInfos> qualificationInfos;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("services")
    public java.util.List<String> services;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("settleInfo")
    public CreateSubInstitutionRequestSettleInfo settleInfo;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>S001</p>
     */
    @NameInMap("solution")
    public String solution;

    @NameInMap("subInstAddressInfo")
    public CreateSubInstitutionRequestSubInstAddressInfo subInstAddressInfo;

    @NameInMap("subInstAuthInfo")
    public CreateSubInstitutionRequestSubInstAuthInfo subInstAuthInfo;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("subInstBasicInfo")
    public CreateSubInstitutionRequestSubInstBasicInfo subInstBasicInfo;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("subInstCertifyInfo")
    public CreateSubInstitutionRequestSubInstCertifyInfo subInstCertifyInfo;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1001</p>
     */
    @NameInMap("subInstId")
    public String subInstId;

    @NameInMap("subInstInvoiceInfo")
    public CreateSubInstitutionRequestSubInstInvoiceInfo subInstInvoiceInfo;

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
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>李某某</p>
         */
        @NameInMap("contactName")
        public String contactName;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>13900000000</p>
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
         * <strong>example:</strong>
         * <p>ossUrl</p>
         */
        @NameInMap("certBackImage")
        public String certBackImage;

        /**
         * <strong>example:</strong>
         * <p>ossUrl</p>
         */
        @NameInMap("certFrontImage")
        public String certFrontImage;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>李某某</p>
         */
        @NameInMap("certName")
        public String certName;

        /**
         * <strong>example:</strong>
         * <p>100</p>
         */
        @NameInMap("certType")
        public String certType;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>330104200010109999</p>
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
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>ossUrl</p>
         */
        @NameInMap("qualificationImage")
        public String qualificationImage;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>301</p>
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
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>622202120200000000</p>
         */
        @NameInMap("accountId")
        public String accountId;

        /**
         * <strong>example:</strong>
         * <p>李某某</p>
         */
        @NameInMap("accountName")
        public String accountName;

        /**
         * <strong>example:</strong>
         * <p>DEBIT_CARD</p>
         */
        @NameInMap("accountType")
        public String accountType;

        /**
         * <strong>example:</strong>
         * <p>城东支行</p>
         */
        @NameInMap("bankBranchName")
        public String bankBranchName;

        /**
         * <strong>example:</strong>
         * <p>杭州市</p>
         */
        @NameInMap("bankCity")
        public String bankCity;

        /**
         * <strong>example:</strong>
         * <p>313791000023</p>
         */
        @NameInMap("bankCode")
        public String bankCode;

        /**
         * <strong>example:</strong>
         * <p>工商银行</p>
         */
        @NameInMap("bankName")
        public String bankName;

        /**
         * <strong>example:</strong>
         * <p>浙江省</p>
         */
        @NameInMap("bankProvince")
        public String bankProvince;

        /**
         * <strong>example:</strong>
         * <p>ICBC</p>
         */
        @NameInMap("bankShortNameCode")
        public String bankShortNameCode;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>ALIPAY</p>
         */
        @NameInMap("type")
        public String type;

        /**
         * <strong>example:</strong>
         * <p>TO_PRI</p>
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
         * <strong>example:</strong>
         * <p>未来park</p>
         */
        @NameInMap("address")
        public String address;

        /**
         * <strong>example:</strong>
         * <p>330100</p>
         */
        @NameInMap("cityCode")
        public String cityCode;

        /**
         * <strong>example:</strong>
         * <p>330104</p>
         */
        @NameInMap("districtCode")
        public String districtCode;

        /**
         * <strong>example:</strong>
         * <p>330000</p>
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
         * <strong>example:</strong>
         * <p>ossUrl</p>
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
         * <strong>example:</strong>
         * <p>一食堂</p>
         */
        @NameInMap("aliasName")
        public String aliasName;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>5812</p>
         */
        @NameInMap("mcc")
        public String mcc;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>食堂</p>
         */
        @NameInMap("subInstName")
        public String subInstName;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>01</p>
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
         * <strong>example:</strong>
         * <p>ossUrl</p>
         */
        @NameInMap("certImage")
        public String certImage;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>331081198611111111</p>
         */
        @NameInMap("certNo")
        public String certNo;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>201</p>
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
         * <strong>example:</strong>
         * <p>未来park</p>
         */
        @NameInMap("address")
        public String address;

        /**
         * <strong>example:</strong>
         * <p>330100</p>
         */
        @NameInMap("cityCode")
        public String cityCode;

        /**
         * <strong>example:</strong>
         * <p>330104</p>
         */
        @NameInMap("districtCode")
        public String districtCode;

        /**
         * <strong>example:</strong>
         * <p>330000</p>
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
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("acceptElectronic")
        public Boolean acceptElectronic;

        /**
         * <strong>example:</strong>
         * <p>浙江省杭州市西湖区西溪路蚂蚁金服</p>
         */
        @NameInMap("address")
        public String address;

        /**
         * <strong>example:</strong>
         * <p>false</p>
         */
        @NameInMap("autoInvoice")
        public Boolean autoInvoice;

        /**
         * <strong>example:</strong>
         * <p>1234567812345678123</p>
         */
        @NameInMap("bankAccount")
        public String bankAccount;

        /**
         * <strong>example:</strong>
         * <p>中国银行</p>
         */
        @NameInMap("bankName")
        public String bankName;

        @NameInMap("mailAddress")
        public CreateSubInstitutionRequestSubInstInvoiceInfoMailAddress mailAddress;

        /**
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("mailName")
        public String mailName;

        /**
         * <strong>example:</strong>
         * <p>057162288888</p>
         */
        @NameInMap("mailPhone")
        public String mailPhone;

        /**
         * <strong>example:</strong>
         * <p>51010482542598631219</p>
         */
        @NameInMap("taxNo")
        public String taxNo;

        /**
         * <strong>example:</strong>
         * <p>01</p>
         */
        @NameInMap("taxPayerQualification")
        public String taxPayerQualification;

        /**
         * <strong>example:</strong>
         * <p>19981011</p>
         */
        @NameInMap("taxPayerValidDate")
        public String taxPayerValidDate;

        /**
         * <strong>example:</strong>
         * <p>057162288888</p>
         */
        @NameInMap("telephone")
        public String telephone;

        /**
         * <strong>example:</strong>
         * <p>**有限公司</p>
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
        @NameInMap("inDoorImages")
        public java.util.List<String> inDoorImages;

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
