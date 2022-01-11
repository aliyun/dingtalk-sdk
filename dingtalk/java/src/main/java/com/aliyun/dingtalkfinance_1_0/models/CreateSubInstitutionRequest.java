// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class CreateSubInstitutionRequest extends TeaModel {
    // 签约支付宝账户，用于协议确认
    @NameInMap("bindingAlipayLogonId")
    public String bindingAlipayLogonId;

    // 联系人
    @NameInMap("contractInfo")
    public CreateSubInstitutionRequestContractInfo contractInfo;

    // 主机构编号
    @NameInMap("instId")
    public String instId;

    @NameInMap("legalPersonCertInfo")
    public CreateSubInstitutionRequestLegalPersonCertInfo legalPersonCertInfo;

    // 进件创建外部流水号
    @NameInMap("outTradeNo")
    public String outTradeNo;

    // 进件渠道
    @NameInMap("payChannel")
    public String payChannel;

    // 资质信息
    @NameInMap("qualificationInfos")
    public java.util.List<CreateSubInstitutionRequestQualificationInfos> qualificationInfos;

    // 开通的服务类型
    @NameInMap("services")
    public java.util.List<String> services;

    // 资金账户信息
    @NameInMap("settleInfo")
    public CreateSubInstitutionRequestSettleInfo settleInfo;

    // 解决方案，包含费率、清算规则等
    @NameInMap("solution")
    public String solution;

    // 子机构地址信息
    @NameInMap("subInstAddressInfo")
    public CreateSubInstitutionRequestSubInstAddressInfo subInstAddressInfo;

    // 授权信息
    @NameInMap("subInstAuthInfo")
    public CreateSubInstitutionRequestSubInstAuthInfo subInstAuthInfo;

    // 子机构基本信息
    @NameInMap("subInstBasicInfo")
    public CreateSubInstitutionRequestSubInstBasicInfo subInstBasicInfo;

    // 子机构认证信息
    @NameInMap("subInstCertifyInfo")
    public CreateSubInstitutionRequestSubInstCertifyInfo subInstCertifyInfo;

    // 子机构编号
    @NameInMap("subInstId")
    public String subInstId;

    // 开票信息
    @NameInMap("subInstInvoiceInfo")
    public CreateSubInstitutionRequestSubInstInvoiceInfo subInstInvoiceInfo;

    // 子机构门店信息
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

    public CreateSubInstitutionRequest setContractInfo(CreateSubInstitutionRequestContractInfo contractInfo) {
        this.contractInfo = contractInfo;
        return this;
    }
    public CreateSubInstitutionRequestContractInfo getContractInfo() {
        return this.contractInfo;
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

    public static class ConsultCreateSubInstitutionRequestContractInfo extends TeaModel {
        // 联系人姓名
        @NameInMap("contractName")
        public String contractName;

        // 联系人手机号
        @NameInMap("mobile")
        public String mobile;

        public static ConsultCreateSubInstitutionRequestContractInfo build(java.util.Map<String, ?> map) throws Exception {
            ConsultCreateSubInstitutionRequestContractInfo self = new ConsultCreateSubInstitutionRequestContractInfo();
            return TeaModel.build(map, self);
        }

        public ConsultCreateSubInstitutionRequestContractInfo setContractName(String contractName) {
            this.contractName = contractName;
            return this;
        }
        public String getContractName() {
            return this.contractName;
        }

        public ConsultCreateSubInstitutionRequestContractInfo setMobile(String mobile) {
            this.mobile = mobile;
            return this;
        }
        public String getMobile() {
            return this.mobile;
        }

    }

    public static class ConsultCreateSubInstitutionRequestLegalPersonCertInfo extends TeaModel {
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
        // 子机构行业资质图片
        @NameInMap("qualificationImage")
        public String qualificationImage;

        // 子机构行业资质类型
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
        // 授权函图片url
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
        // 证件图片, 如果是特殊行业必填
        @NameInMap("certImage")
        public String certImage;

        // 证件号码
        @NameInMap("certNo")
        public String certNo;

        // 证件类型
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
        public ConsultCreateSubInstitutionRequestSubInstInvoiceInfoMailAddress mailAddress;

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
        // 内景照
        @NameInMap("inDoorImages")
        public java.util.List<String> inDoorImages;

        // 外景照
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

    public static class CreateSubInstitutionRequestContractInfo extends TeaModel {
        // 联系人姓名
        @NameInMap("contractName")
        public String contractName;

        // 联系人手机号
        @NameInMap("mobile")
        public String mobile;

        public static CreateSubInstitutionRequestContractInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateSubInstitutionRequestContractInfo self = new CreateSubInstitutionRequestContractInfo();
            return TeaModel.build(map, self);
        }

        public CreateSubInstitutionRequestContractInfo setContractName(String contractName) {
            this.contractName = contractName;
            return this;
        }
        public String getContractName() {
            return this.contractName;
        }

        public CreateSubInstitutionRequestContractInfo setMobile(String mobile) {
            this.mobile = mobile;
            return this;
        }
        public String getMobile() {
            return this.mobile;
        }

    }

    public static class CreateSubInstitutionRequestLegalPersonCertInfo extends TeaModel {
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
        // 子机构行业资质图片
        @NameInMap("qualificationImage")
        public String qualificationImage;

        // 子机构行业资质类型
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
        // 账户账号
        @NameInMap("accountId")
        public String accountId;

        // 账户名称 账号类型银行卡时为卡户名
        @NameInMap("accountName")
        public String accountName;

        // 卡类型, DEBIT_CARD借记卡，CREDIT_CARD信用卡
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
        // 授权函图片url
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
        // 证件图片, 如果是特殊行业必填
        @NameInMap("certImage")
        public String certImage;

        // 证件号码
        @NameInMap("certNo")
        public String certNo;

        // 证件类型
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
        public CreateSubInstitutionRequestSubInstInvoiceInfoMailAddress mailAddress;

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
        // 内景照
        @NameInMap("inDoorImages")
        public java.util.List<String> inDoorImages;

        // 外景照
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
