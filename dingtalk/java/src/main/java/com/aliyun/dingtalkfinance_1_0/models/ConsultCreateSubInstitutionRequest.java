// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class ConsultCreateSubInstitutionRequest extends TeaModel {
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
    public ConsultCreateSubInstitutionRequestContactInfo contactInfo;

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
    public ConsultCreateSubInstitutionRequestLegalPersonCertInfo legalPersonCertInfo;

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
    public java.util.List<ConsultCreateSubInstitutionRequestQualificationInfos> qualificationInfos;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("services")
    public java.util.List<String> services;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("settleInfo")
    public ConsultCreateSubInstitutionRequestSettleInfo settleInfo;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>S001</p>
     */
    @NameInMap("solution")
    public String solution;

    @NameInMap("subInstAddressInfo")
    public ConsultCreateSubInstitutionRequestSubInstAddressInfo subInstAddressInfo;

    @NameInMap("subInstAuthInfo")
    public ConsultCreateSubInstitutionRequestSubInstAuthInfo subInstAuthInfo;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("subInstBasicInfo")
    public ConsultCreateSubInstitutionRequestSubInstBasicInfo subInstBasicInfo;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("subInstCertifyInfo")
    public ConsultCreateSubInstitutionRequestSubInstCertifyInfo subInstCertifyInfo;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1001</p>
     */
    @NameInMap("subInstId")
    public String subInstId;

    @NameInMap("subInstInvoiceInfo")
    public ConsultCreateSubInstitutionRequestSubInstInvoiceInfo subInstInvoiceInfo;

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
         * <strong>example:</strong>
         * <p>ossUrl</p>
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
        public ConsultCreateSubInstitutionRequestSubInstInvoiceInfoMailAddress mailAddress;

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
        @NameInMap("inDoorImages")
        public java.util.List<String> inDoorImages;

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
