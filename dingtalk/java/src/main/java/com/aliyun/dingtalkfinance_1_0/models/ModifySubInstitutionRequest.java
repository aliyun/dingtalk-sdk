// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class ModifySubInstitutionRequest extends TeaModel {
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
    public ModifySubInstitutionRequestContactInfo contactInfo;

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
    public ModifySubInstitutionRequestLegalPersonCertInfo legalPersonCertInfo;

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
    public java.util.List<ModifySubInstitutionRequestQualificationInfos> qualificationInfos;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("services")
    public java.util.List<String> services;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("settleInfo")
    public ModifySubInstitutionRequestSettleInfo settleInfo;

    @NameInMap("subInstAddressInfo")
    public ModifySubInstitutionRequestSubInstAddressInfo subInstAddressInfo;

    @NameInMap("subInstAuthInfo")
    public ModifySubInstitutionRequestSubInstAuthInfo subInstAuthInfo;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("subInstBasicInfo")
    public ModifySubInstitutionRequestSubInstBasicInfo subInstBasicInfo;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("subInstCertifyInfo")
    public ModifySubInstitutionRequestSubInstCertifyInfo subInstCertifyInfo;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1001</p>
     */
    @NameInMap("subInstId")
    public String subInstId;

    @NameInMap("subInstInvoiceInfo")
    public ModifySubInstitutionRequestSubInstInvoiceInfo subInstInvoiceInfo;

    @NameInMap("subInstShopInfo")
    public ModifySubInstitutionRequestSubInstShopInfo subInstShopInfo;

    public static ModifySubInstitutionRequest build(java.util.Map<String, ?> map) throws Exception {
        ModifySubInstitutionRequest self = new ModifySubInstitutionRequest();
        return TeaModel.build(map, self);
    }

    public ModifySubInstitutionRequest setBindingAlipayLogonId(String bindingAlipayLogonId) {
        this.bindingAlipayLogonId = bindingAlipayLogonId;
        return this;
    }
    public String getBindingAlipayLogonId() {
        return this.bindingAlipayLogonId;
    }

    public ModifySubInstitutionRequest setContactInfo(ModifySubInstitutionRequestContactInfo contactInfo) {
        this.contactInfo = contactInfo;
        return this;
    }
    public ModifySubInstitutionRequestContactInfo getContactInfo() {
        return this.contactInfo;
    }

    public ModifySubInstitutionRequest setInstId(String instId) {
        this.instId = instId;
        return this;
    }
    public String getInstId() {
        return this.instId;
    }

    public ModifySubInstitutionRequest setLegalPersonCertInfo(ModifySubInstitutionRequestLegalPersonCertInfo legalPersonCertInfo) {
        this.legalPersonCertInfo = legalPersonCertInfo;
        return this;
    }
    public ModifySubInstitutionRequestLegalPersonCertInfo getLegalPersonCertInfo() {
        return this.legalPersonCertInfo;
    }

    public ModifySubInstitutionRequest setOutTradeNo(String outTradeNo) {
        this.outTradeNo = outTradeNo;
        return this;
    }
    public String getOutTradeNo() {
        return this.outTradeNo;
    }

    public ModifySubInstitutionRequest setPayChannel(String payChannel) {
        this.payChannel = payChannel;
        return this;
    }
    public String getPayChannel() {
        return this.payChannel;
    }

    public ModifySubInstitutionRequest setQualificationInfos(java.util.List<ModifySubInstitutionRequestQualificationInfos> qualificationInfos) {
        this.qualificationInfos = qualificationInfos;
        return this;
    }
    public java.util.List<ModifySubInstitutionRequestQualificationInfos> getQualificationInfos() {
        return this.qualificationInfos;
    }

    public ModifySubInstitutionRequest setServices(java.util.List<String> services) {
        this.services = services;
        return this;
    }
    public java.util.List<String> getServices() {
        return this.services;
    }

    public ModifySubInstitutionRequest setSettleInfo(ModifySubInstitutionRequestSettleInfo settleInfo) {
        this.settleInfo = settleInfo;
        return this;
    }
    public ModifySubInstitutionRequestSettleInfo getSettleInfo() {
        return this.settleInfo;
    }

    public ModifySubInstitutionRequest setSubInstAddressInfo(ModifySubInstitutionRequestSubInstAddressInfo subInstAddressInfo) {
        this.subInstAddressInfo = subInstAddressInfo;
        return this;
    }
    public ModifySubInstitutionRequestSubInstAddressInfo getSubInstAddressInfo() {
        return this.subInstAddressInfo;
    }

    public ModifySubInstitutionRequest setSubInstAuthInfo(ModifySubInstitutionRequestSubInstAuthInfo subInstAuthInfo) {
        this.subInstAuthInfo = subInstAuthInfo;
        return this;
    }
    public ModifySubInstitutionRequestSubInstAuthInfo getSubInstAuthInfo() {
        return this.subInstAuthInfo;
    }

    public ModifySubInstitutionRequest setSubInstBasicInfo(ModifySubInstitutionRequestSubInstBasicInfo subInstBasicInfo) {
        this.subInstBasicInfo = subInstBasicInfo;
        return this;
    }
    public ModifySubInstitutionRequestSubInstBasicInfo getSubInstBasicInfo() {
        return this.subInstBasicInfo;
    }

    public ModifySubInstitutionRequest setSubInstCertifyInfo(ModifySubInstitutionRequestSubInstCertifyInfo subInstCertifyInfo) {
        this.subInstCertifyInfo = subInstCertifyInfo;
        return this;
    }
    public ModifySubInstitutionRequestSubInstCertifyInfo getSubInstCertifyInfo() {
        return this.subInstCertifyInfo;
    }

    public ModifySubInstitutionRequest setSubInstId(String subInstId) {
        this.subInstId = subInstId;
        return this;
    }
    public String getSubInstId() {
        return this.subInstId;
    }

    public ModifySubInstitutionRequest setSubInstInvoiceInfo(ModifySubInstitutionRequestSubInstInvoiceInfo subInstInvoiceInfo) {
        this.subInstInvoiceInfo = subInstInvoiceInfo;
        return this;
    }
    public ModifySubInstitutionRequestSubInstInvoiceInfo getSubInstInvoiceInfo() {
        return this.subInstInvoiceInfo;
    }

    public ModifySubInstitutionRequest setSubInstShopInfo(ModifySubInstitutionRequestSubInstShopInfo subInstShopInfo) {
        this.subInstShopInfo = subInstShopInfo;
        return this;
    }
    public ModifySubInstitutionRequestSubInstShopInfo getSubInstShopInfo() {
        return this.subInstShopInfo;
    }

    public static class ModifySubInstitutionRequestContactInfo extends TeaModel {
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

        public static ModifySubInstitutionRequestContactInfo build(java.util.Map<String, ?> map) throws Exception {
            ModifySubInstitutionRequestContactInfo self = new ModifySubInstitutionRequestContactInfo();
            return TeaModel.build(map, self);
        }

        public ModifySubInstitutionRequestContactInfo setContactName(String contactName) {
            this.contactName = contactName;
            return this;
        }
        public String getContactName() {
            return this.contactName;
        }

        public ModifySubInstitutionRequestContactInfo setMobile(String mobile) {
            this.mobile = mobile;
            return this;
        }
        public String getMobile() {
            return this.mobile;
        }

    }

    public static class ModifySubInstitutionRequestLegalPersonCertInfo extends TeaModel {
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

        public static ModifySubInstitutionRequestLegalPersonCertInfo build(java.util.Map<String, ?> map) throws Exception {
            ModifySubInstitutionRequestLegalPersonCertInfo self = new ModifySubInstitutionRequestLegalPersonCertInfo();
            return TeaModel.build(map, self);
        }

        public ModifySubInstitutionRequestLegalPersonCertInfo setCertBackImage(String certBackImage) {
            this.certBackImage = certBackImage;
            return this;
        }
        public String getCertBackImage() {
            return this.certBackImage;
        }

        public ModifySubInstitutionRequestLegalPersonCertInfo setCertFrontImage(String certFrontImage) {
            this.certFrontImage = certFrontImage;
            return this;
        }
        public String getCertFrontImage() {
            return this.certFrontImage;
        }

        public ModifySubInstitutionRequestLegalPersonCertInfo setCertName(String certName) {
            this.certName = certName;
            return this;
        }
        public String getCertName() {
            return this.certName;
        }

        public ModifySubInstitutionRequestLegalPersonCertInfo setCertType(String certType) {
            this.certType = certType;
            return this;
        }
        public String getCertType() {
            return this.certType;
        }

        public ModifySubInstitutionRequestLegalPersonCertInfo setIdCardNo(String idCardNo) {
            this.idCardNo = idCardNo;
            return this;
        }
        public String getIdCardNo() {
            return this.idCardNo;
        }

    }

    public static class ModifySubInstitutionRequestQualificationInfos extends TeaModel {
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

        public static ModifySubInstitutionRequestQualificationInfos build(java.util.Map<String, ?> map) throws Exception {
            ModifySubInstitutionRequestQualificationInfos self = new ModifySubInstitutionRequestQualificationInfos();
            return TeaModel.build(map, self);
        }

        public ModifySubInstitutionRequestQualificationInfos setQualificationImage(String qualificationImage) {
            this.qualificationImage = qualificationImage;
            return this;
        }
        public String getQualificationImage() {
            return this.qualificationImage;
        }

        public ModifySubInstitutionRequestQualificationInfos setQualificationType(String qualificationType) {
            this.qualificationType = qualificationType;
            return this;
        }
        public String getQualificationType() {
            return this.qualificationType;
        }

    }

    public static class ModifySubInstitutionRequestSettleInfo extends TeaModel {
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

        public static ModifySubInstitutionRequestSettleInfo build(java.util.Map<String, ?> map) throws Exception {
            ModifySubInstitutionRequestSettleInfo self = new ModifySubInstitutionRequestSettleInfo();
            return TeaModel.build(map, self);
        }

        public ModifySubInstitutionRequestSettleInfo setAccountId(String accountId) {
            this.accountId = accountId;
            return this;
        }
        public String getAccountId() {
            return this.accountId;
        }

        public ModifySubInstitutionRequestSettleInfo setAccountName(String accountName) {
            this.accountName = accountName;
            return this;
        }
        public String getAccountName() {
            return this.accountName;
        }

        public ModifySubInstitutionRequestSettleInfo setAccountType(String accountType) {
            this.accountType = accountType;
            return this;
        }
        public String getAccountType() {
            return this.accountType;
        }

        public ModifySubInstitutionRequestSettleInfo setBankBranchName(String bankBranchName) {
            this.bankBranchName = bankBranchName;
            return this;
        }
        public String getBankBranchName() {
            return this.bankBranchName;
        }

        public ModifySubInstitutionRequestSettleInfo setBankCity(String bankCity) {
            this.bankCity = bankCity;
            return this;
        }
        public String getBankCity() {
            return this.bankCity;
        }

        public ModifySubInstitutionRequestSettleInfo setBankCode(String bankCode) {
            this.bankCode = bankCode;
            return this;
        }
        public String getBankCode() {
            return this.bankCode;
        }

        public ModifySubInstitutionRequestSettleInfo setBankName(String bankName) {
            this.bankName = bankName;
            return this;
        }
        public String getBankName() {
            return this.bankName;
        }

        public ModifySubInstitutionRequestSettleInfo setBankProvince(String bankProvince) {
            this.bankProvince = bankProvince;
            return this;
        }
        public String getBankProvince() {
            return this.bankProvince;
        }

        public ModifySubInstitutionRequestSettleInfo setBankShortNameCode(String bankShortNameCode) {
            this.bankShortNameCode = bankShortNameCode;
            return this;
        }
        public String getBankShortNameCode() {
            return this.bankShortNameCode;
        }

        public ModifySubInstitutionRequestSettleInfo setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public ModifySubInstitutionRequestSettleInfo setUsageType(String usageType) {
            this.usageType = usageType;
            return this;
        }
        public String getUsageType() {
            return this.usageType;
        }

    }

    public static class ModifySubInstitutionRequestSubInstAddressInfo extends TeaModel {
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

        public static ModifySubInstitutionRequestSubInstAddressInfo build(java.util.Map<String, ?> map) throws Exception {
            ModifySubInstitutionRequestSubInstAddressInfo self = new ModifySubInstitutionRequestSubInstAddressInfo();
            return TeaModel.build(map, self);
        }

        public ModifySubInstitutionRequestSubInstAddressInfo setAddress(String address) {
            this.address = address;
            return this;
        }
        public String getAddress() {
            return this.address;
        }

        public ModifySubInstitutionRequestSubInstAddressInfo setCityCode(String cityCode) {
            this.cityCode = cityCode;
            return this;
        }
        public String getCityCode() {
            return this.cityCode;
        }

        public ModifySubInstitutionRequestSubInstAddressInfo setDistrictCode(String districtCode) {
            this.districtCode = districtCode;
            return this;
        }
        public String getDistrictCode() {
            return this.districtCode;
        }

        public ModifySubInstitutionRequestSubInstAddressInfo setProvinceCode(String provinceCode) {
            this.provinceCode = provinceCode;
            return this;
        }
        public String getProvinceCode() {
            return this.provinceCode;
        }

    }

    public static class ModifySubInstitutionRequestSubInstAuthInfo extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>ossUrl</p>
         */
        @NameInMap("authorizationLetterUrl")
        public String authorizationLetterUrl;

        public static ModifySubInstitutionRequestSubInstAuthInfo build(java.util.Map<String, ?> map) throws Exception {
            ModifySubInstitutionRequestSubInstAuthInfo self = new ModifySubInstitutionRequestSubInstAuthInfo();
            return TeaModel.build(map, self);
        }

        public ModifySubInstitutionRequestSubInstAuthInfo setAuthorizationLetterUrl(String authorizationLetterUrl) {
            this.authorizationLetterUrl = authorizationLetterUrl;
            return this;
        }
        public String getAuthorizationLetterUrl() {
            return this.authorizationLetterUrl;
        }

    }

    public static class ModifySubInstitutionRequestSubInstBasicInfo extends TeaModel {
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

        public static ModifySubInstitutionRequestSubInstBasicInfo build(java.util.Map<String, ?> map) throws Exception {
            ModifySubInstitutionRequestSubInstBasicInfo self = new ModifySubInstitutionRequestSubInstBasicInfo();
            return TeaModel.build(map, self);
        }

        public ModifySubInstitutionRequestSubInstBasicInfo setAliasName(String aliasName) {
            this.aliasName = aliasName;
            return this;
        }
        public String getAliasName() {
            return this.aliasName;
        }

        public ModifySubInstitutionRequestSubInstBasicInfo setMcc(String mcc) {
            this.mcc = mcc;
            return this;
        }
        public String getMcc() {
            return this.mcc;
        }

        public ModifySubInstitutionRequestSubInstBasicInfo setSubInstName(String subInstName) {
            this.subInstName = subInstName;
            return this;
        }
        public String getSubInstName() {
            return this.subInstName;
        }

        public ModifySubInstitutionRequestSubInstBasicInfo setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class ModifySubInstitutionRequestSubInstCertifyInfo extends TeaModel {
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

        public static ModifySubInstitutionRequestSubInstCertifyInfo build(java.util.Map<String, ?> map) throws Exception {
            ModifySubInstitutionRequestSubInstCertifyInfo self = new ModifySubInstitutionRequestSubInstCertifyInfo();
            return TeaModel.build(map, self);
        }

        public ModifySubInstitutionRequestSubInstCertifyInfo setCertImage(String certImage) {
            this.certImage = certImage;
            return this;
        }
        public String getCertImage() {
            return this.certImage;
        }

        public ModifySubInstitutionRequestSubInstCertifyInfo setCertNo(String certNo) {
            this.certNo = certNo;
            return this;
        }
        public String getCertNo() {
            return this.certNo;
        }

        public ModifySubInstitutionRequestSubInstCertifyInfo setCertType(String certType) {
            this.certType = certType;
            return this;
        }
        public String getCertType() {
            return this.certType;
        }

    }

    public static class ModifySubInstitutionRequestSubInstInvoiceInfoMailAddress extends TeaModel {
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

        public static ModifySubInstitutionRequestSubInstInvoiceInfoMailAddress build(java.util.Map<String, ?> map) throws Exception {
            ModifySubInstitutionRequestSubInstInvoiceInfoMailAddress self = new ModifySubInstitutionRequestSubInstInvoiceInfoMailAddress();
            return TeaModel.build(map, self);
        }

        public ModifySubInstitutionRequestSubInstInvoiceInfoMailAddress setAddress(String address) {
            this.address = address;
            return this;
        }
        public String getAddress() {
            return this.address;
        }

        public ModifySubInstitutionRequestSubInstInvoiceInfoMailAddress setCityCode(String cityCode) {
            this.cityCode = cityCode;
            return this;
        }
        public String getCityCode() {
            return this.cityCode;
        }

        public ModifySubInstitutionRequestSubInstInvoiceInfoMailAddress setDistrictCode(String districtCode) {
            this.districtCode = districtCode;
            return this;
        }
        public String getDistrictCode() {
            return this.districtCode;
        }

        public ModifySubInstitutionRequestSubInstInvoiceInfoMailAddress setProvinceCode(String provinceCode) {
            this.provinceCode = provinceCode;
            return this;
        }
        public String getProvinceCode() {
            return this.provinceCode;
        }

    }

    public static class ModifySubInstitutionRequestSubInstInvoiceInfo extends TeaModel {
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
        public ModifySubInstitutionRequestSubInstInvoiceInfoMailAddress mailAddress;

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

        public static ModifySubInstitutionRequestSubInstInvoiceInfo build(java.util.Map<String, ?> map) throws Exception {
            ModifySubInstitutionRequestSubInstInvoiceInfo self = new ModifySubInstitutionRequestSubInstInvoiceInfo();
            return TeaModel.build(map, self);
        }

        public ModifySubInstitutionRequestSubInstInvoiceInfo setAcceptElectronic(Boolean acceptElectronic) {
            this.acceptElectronic = acceptElectronic;
            return this;
        }
        public Boolean getAcceptElectronic() {
            return this.acceptElectronic;
        }

        public ModifySubInstitutionRequestSubInstInvoiceInfo setAddress(String address) {
            this.address = address;
            return this;
        }
        public String getAddress() {
            return this.address;
        }

        public ModifySubInstitutionRequestSubInstInvoiceInfo setAutoInvoice(Boolean autoInvoice) {
            this.autoInvoice = autoInvoice;
            return this;
        }
        public Boolean getAutoInvoice() {
            return this.autoInvoice;
        }

        public ModifySubInstitutionRequestSubInstInvoiceInfo setBankAccount(String bankAccount) {
            this.bankAccount = bankAccount;
            return this;
        }
        public String getBankAccount() {
            return this.bankAccount;
        }

        public ModifySubInstitutionRequestSubInstInvoiceInfo setBankName(String bankName) {
            this.bankName = bankName;
            return this;
        }
        public String getBankName() {
            return this.bankName;
        }

        public ModifySubInstitutionRequestSubInstInvoiceInfo setMailAddress(ModifySubInstitutionRequestSubInstInvoiceInfoMailAddress mailAddress) {
            this.mailAddress = mailAddress;
            return this;
        }
        public ModifySubInstitutionRequestSubInstInvoiceInfoMailAddress getMailAddress() {
            return this.mailAddress;
        }

        public ModifySubInstitutionRequestSubInstInvoiceInfo setMailName(String mailName) {
            this.mailName = mailName;
            return this;
        }
        public String getMailName() {
            return this.mailName;
        }

        public ModifySubInstitutionRequestSubInstInvoiceInfo setMailPhone(String mailPhone) {
            this.mailPhone = mailPhone;
            return this;
        }
        public String getMailPhone() {
            return this.mailPhone;
        }

        public ModifySubInstitutionRequestSubInstInvoiceInfo setTaxNo(String taxNo) {
            this.taxNo = taxNo;
            return this;
        }
        public String getTaxNo() {
            return this.taxNo;
        }

        public ModifySubInstitutionRequestSubInstInvoiceInfo setTaxPayerQualification(String taxPayerQualification) {
            this.taxPayerQualification = taxPayerQualification;
            return this;
        }
        public String getTaxPayerQualification() {
            return this.taxPayerQualification;
        }

        public ModifySubInstitutionRequestSubInstInvoiceInfo setTaxPayerValidDate(String taxPayerValidDate) {
            this.taxPayerValidDate = taxPayerValidDate;
            return this;
        }
        public String getTaxPayerValidDate() {
            return this.taxPayerValidDate;
        }

        public ModifySubInstitutionRequestSubInstInvoiceInfo setTelephone(String telephone) {
            this.telephone = telephone;
            return this;
        }
        public String getTelephone() {
            return this.telephone;
        }

        public ModifySubInstitutionRequestSubInstInvoiceInfo setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class ModifySubInstitutionRequestSubInstShopInfo extends TeaModel {
        @NameInMap("inDoorImages")
        public java.util.List<String> inDoorImages;

        @NameInMap("outDoorImages")
        public java.util.List<String> outDoorImages;

        public static ModifySubInstitutionRequestSubInstShopInfo build(java.util.Map<String, ?> map) throws Exception {
            ModifySubInstitutionRequestSubInstShopInfo self = new ModifySubInstitutionRequestSubInstShopInfo();
            return TeaModel.build(map, self);
        }

        public ModifySubInstitutionRequestSubInstShopInfo setInDoorImages(java.util.List<String> inDoorImages) {
            this.inDoorImages = inDoorImages;
            return this;
        }
        public java.util.List<String> getInDoorImages() {
            return this.inDoorImages;
        }

        public ModifySubInstitutionRequestSubInstShopInfo setOutDoorImages(java.util.List<String> outDoorImages) {
            this.outDoorImages = outDoorImages;
            return this;
        }
        public java.util.List<String> getOutDoorImages() {
            return this.outDoorImages;
        }

    }

}
