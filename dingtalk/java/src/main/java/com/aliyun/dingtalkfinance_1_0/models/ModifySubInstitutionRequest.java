// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class ModifySubInstitutionRequest extends TeaModel {
    // 签约支付宝账户，用于协议确认
    @NameInMap("bindingAlipayLogonId")
    public String bindingAlipayLogonId;

    // 联系人
    @NameInMap("contractInfo")
    public ModifySubInstitutionRequestContractInfo contractInfo;

    // 主机构编号
    @NameInMap("instId")
    public String instId;

    @NameInMap("legalPersonCertInfo")
    public ModifySubInstitutionRequestLegalPersonCertInfo legalPersonCertInfo;

    // 进件创建外部流水号
    @NameInMap("outTradeNo")
    public String outTradeNo;

    // 进件渠道
    @NameInMap("payChannel")
    public String payChannel;

    // 资质信息
    @NameInMap("qualificationInfos")
    public java.util.List<ModifySubInstitutionRequestQualificationInfos> qualificationInfos;

    // 开通的服务类型
    @NameInMap("services")
    public java.util.List<String> services;

    // 资金账户信息
    @NameInMap("settleInfo")
    public ModifySubInstitutionRequestSettleInfo settleInfo;

    // 子机构地址信息
    @NameInMap("subInstAddressInfo")
    public ModifySubInstitutionRequestSubInstAddressInfo subInstAddressInfo;

    // 授权信息
    @NameInMap("subInstAuthInfo")
    public ModifySubInstitutionRequestSubInstAuthInfo subInstAuthInfo;

    // 子机构基本信息
    @NameInMap("subInstBasicInfo")
    public ModifySubInstitutionRequestSubInstBasicInfo subInstBasicInfo;

    // 子机构认证信息
    @NameInMap("subInstCertifyInfo")
    public ModifySubInstitutionRequestSubInstCertifyInfo subInstCertifyInfo;

    // 子机构编号
    @NameInMap("subInstId")
    public String subInstId;

    // 开票信息
    @NameInMap("subInstInvoiceInfo")
    public ModifySubInstitutionRequestSubInstInvoiceInfo subInstInvoiceInfo;

    // 子机构门店信息
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

    public ModifySubInstitutionRequest setContractInfo(ModifySubInstitutionRequestContractInfo contractInfo) {
        this.contractInfo = contractInfo;
        return this;
    }
    public ModifySubInstitutionRequestContractInfo getContractInfo() {
        return this.contractInfo;
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

    public static class ModifySubInstitutionRequestContractInfo extends TeaModel {
        // 联系人姓名
        @NameInMap("contractName")
        public String contractName;

        // 联系人手机号
        @NameInMap("mobile")
        public String mobile;

        public static ModifySubInstitutionRequestContractInfo build(java.util.Map<String, ?> map) throws Exception {
            ModifySubInstitutionRequestContractInfo self = new ModifySubInstitutionRequestContractInfo();
            return TeaModel.build(map, self);
        }

        public ModifySubInstitutionRequestContractInfo setContractName(String contractName) {
            this.contractName = contractName;
            return this;
        }
        public String getContractName() {
            return this.contractName;
        }

        public ModifySubInstitutionRequestContractInfo setMobile(String mobile) {
            this.mobile = mobile;
            return this;
        }
        public String getMobile() {
            return this.mobile;
        }

    }

    public static class ModifySubInstitutionRequestLegalPersonCertInfo extends TeaModel {
        // 法人证件反面url
        @NameInMap("certBackImage")
        public String certBackImage;

        // 法人证件正面url
        @NameInMap("certFrontImage")
        public String certFrontImage;

        // 法人姓名
        @NameInMap("certName")
        public String certName;

        // 法人证件类型 不填默认为身份证
        @NameInMap("certType")
        public String certType;

        // 法人证件号
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
        // 子机构行业资质图片
        @NameInMap("qualificationImage")
        public String qualificationImage;

        // 子机构行业资质类型
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
        // 账户账号
        @NameInMap("accountId")
        public String accountId;

        // 账户名称 账号类型银行卡时为卡户名
        @NameInMap("accountName")
        public String accountName;

        // 卡类型
        @NameInMap("accountType")
        public String accountType;

        // 支行名称
        @NameInMap("bankBranchName")
        public String bankBranchName;

        // 开户行所在地 市
        @NameInMap("bankCity")
        public String bankCity;

        // 联行号
        @NameInMap("bankCode")
        public String bankCode;

        // 银行名称
        @NameInMap("bankName")
        public String bankName;

        // 开户行所在地 省
        @NameInMap("bankProvince")
        public String bankProvince;

        // 开户行简称缩写
        @NameInMap("bankShortNameCode")
        public String bankShortNameCode;

        // 账号类型
        @NameInMap("type")
        public String type;

        // 账户使用类型
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
        // 详细地址
        @NameInMap("address")
        public String address;

        // 市码
        @NameInMap("cityCode")
        public String cityCode;

        // 区码
        @NameInMap("districtCode")
        public String districtCode;

        // 省码
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
        // 授权函图片url
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
        // 别名
        @NameInMap("aliasName")
        public String aliasName;

        // 机构识别码
        @NameInMap("mcc")
        public String mcc;

        // 名称
        @NameInMap("subInstName")
        public String subInstName;

        // 类型
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
        // 证件图片, 如果是特殊行业必填
        @NameInMap("certImage")
        public String certImage;

        // 证件号码
        @NameInMap("certNo")
        public String certNo;

        // 证件类型
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
        // 详细地址
        @NameInMap("address")
        public String address;

        // 市码
        @NameInMap("cityCode")
        public String cityCode;

        // 区码
        @NameInMap("districtCode")
        public String districtCode;

        // 省码
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
        // 是否接受电票
        @NameInMap("acceptElectronic")
        public Boolean acceptElectronic;

        // 开票地址
        @NameInMap("address")
        public String address;

        // 是否自动开票
        @NameInMap("autoInvoice")
        public Boolean autoInvoice;

        // 银行账户
        @NameInMap("bankAccount")
        public String bankAccount;

        // 银行名称
        @NameInMap("bankName")
        public String bankName;

        // 收件地址
        @NameInMap("mailAddress")
        public ModifySubInstitutionRequestSubInstInvoiceInfoMailAddress mailAddress;

        // 收件人名称
        @NameInMap("mailName")
        public String mailName;

        // 收件人号码
        @NameInMap("mailPhone")
        public String mailPhone;

        // 纳税人识别号
        @NameInMap("taxNo")
        public String taxNo;

        // 纳税人资质
        @NameInMap("taxPayerQualification")
        public String taxPayerQualification;

        // 纳税人资格开始时间
        @NameInMap("taxPayerValidDate")
        public String taxPayerValidDate;

        // 开票电话
        @NameInMap("telephone")
        public String telephone;

        // 纳税人抬头
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
        // 内景照
        @NameInMap("inDoorImages")
        public java.util.List<String> inDoorImages;

        // 外景照
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
