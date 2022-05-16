// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SaveAndSubmitAuthInfoRequest extends TeaModel {
    // 申请说明
    @NameInMap("applyRemark")
    public String applyRemark;

    // 认证书图片mediaId
    @NameInMap("authorizeMediaId")
    public String authorizeMediaId;

    // 行业
    @NameInMap("industry")
    public String industry;

    // 企业法人
    @NameInMap("legalPerson")
    public String legalPerson;

    // 企业法人身份证
    @NameInMap("legalPersonIdCard")
    public String legalPersonIdCard;

    // 营业执照图片mediaId
    @NameInMap("licenseMediaId")
    public String licenseMediaId;

    // 城市编码
    @NameInMap("locCity")
    public Long locCity;

    // 城市名字
    @NameInMap("locCityName")
    public String locCityName;

    // 省份编码
    @NameInMap("locProvince")
    public Long locProvince;

    // 省份名字
    @NameInMap("locProvinceName")
    public String locProvinceName;

    // 申请人手机号（需要实名认证）
    @NameInMap("mobileNum")
    public String mobileNum;

    // 组织名，提交认证的时候可以修改
    @NameInMap("orgName")
    public String orgName;

    // 组织机构代码证号（格式11111111-1）
    @NameInMap("organizationCode")
    public String organizationCode;

    // 组织机构代码证图片mediaId
    @NameInMap("organizationCodeMediaId")
    public String organizationCodeMediaId;

    // 认证企业详细地址
    @NameInMap("registLocation")
    public String registLocation;

    // 营业执照注册号（一般15位）
    @NameInMap("registNum")
    public String registNum;

    // 企业id
    @NameInMap("targetCorpId")
    public String targetCorpId;

    // 社会统一信用代码（固定18位）
    @NameInMap("unifiedSocialCredit")
    public String unifiedSocialCredit;

    public static SaveAndSubmitAuthInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        SaveAndSubmitAuthInfoRequest self = new SaveAndSubmitAuthInfoRequest();
        return TeaModel.build(map, self);
    }

    public SaveAndSubmitAuthInfoRequest setApplyRemark(String applyRemark) {
        this.applyRemark = applyRemark;
        return this;
    }
    public String getApplyRemark() {
        return this.applyRemark;
    }

    public SaveAndSubmitAuthInfoRequest setAuthorizeMediaId(String authorizeMediaId) {
        this.authorizeMediaId = authorizeMediaId;
        return this;
    }
    public String getAuthorizeMediaId() {
        return this.authorizeMediaId;
    }

    public SaveAndSubmitAuthInfoRequest setIndustry(String industry) {
        this.industry = industry;
        return this;
    }
    public String getIndustry() {
        return this.industry;
    }

    public SaveAndSubmitAuthInfoRequest setLegalPerson(String legalPerson) {
        this.legalPerson = legalPerson;
        return this;
    }
    public String getLegalPerson() {
        return this.legalPerson;
    }

    public SaveAndSubmitAuthInfoRequest setLegalPersonIdCard(String legalPersonIdCard) {
        this.legalPersonIdCard = legalPersonIdCard;
        return this;
    }
    public String getLegalPersonIdCard() {
        return this.legalPersonIdCard;
    }

    public SaveAndSubmitAuthInfoRequest setLicenseMediaId(String licenseMediaId) {
        this.licenseMediaId = licenseMediaId;
        return this;
    }
    public String getLicenseMediaId() {
        return this.licenseMediaId;
    }

    public SaveAndSubmitAuthInfoRequest setLocCity(Long locCity) {
        this.locCity = locCity;
        return this;
    }
    public Long getLocCity() {
        return this.locCity;
    }

    public SaveAndSubmitAuthInfoRequest setLocCityName(String locCityName) {
        this.locCityName = locCityName;
        return this;
    }
    public String getLocCityName() {
        return this.locCityName;
    }

    public SaveAndSubmitAuthInfoRequest setLocProvince(Long locProvince) {
        this.locProvince = locProvince;
        return this;
    }
    public Long getLocProvince() {
        return this.locProvince;
    }

    public SaveAndSubmitAuthInfoRequest setLocProvinceName(String locProvinceName) {
        this.locProvinceName = locProvinceName;
        return this;
    }
    public String getLocProvinceName() {
        return this.locProvinceName;
    }

    public SaveAndSubmitAuthInfoRequest setMobileNum(String mobileNum) {
        this.mobileNum = mobileNum;
        return this;
    }
    public String getMobileNum() {
        return this.mobileNum;
    }

    public SaveAndSubmitAuthInfoRequest setOrgName(String orgName) {
        this.orgName = orgName;
        return this;
    }
    public String getOrgName() {
        return this.orgName;
    }

    public SaveAndSubmitAuthInfoRequest setOrganizationCode(String organizationCode) {
        this.organizationCode = organizationCode;
        return this;
    }
    public String getOrganizationCode() {
        return this.organizationCode;
    }

    public SaveAndSubmitAuthInfoRequest setOrganizationCodeMediaId(String organizationCodeMediaId) {
        this.organizationCodeMediaId = organizationCodeMediaId;
        return this;
    }
    public String getOrganizationCodeMediaId() {
        return this.organizationCodeMediaId;
    }

    public SaveAndSubmitAuthInfoRequest setRegistLocation(String registLocation) {
        this.registLocation = registLocation;
        return this;
    }
    public String getRegistLocation() {
        return this.registLocation;
    }

    public SaveAndSubmitAuthInfoRequest setRegistNum(String registNum) {
        this.registNum = registNum;
        return this;
    }
    public String getRegistNum() {
        return this.registNum;
    }

    public SaveAndSubmitAuthInfoRequest setTargetCorpId(String targetCorpId) {
        this.targetCorpId = targetCorpId;
        return this;
    }
    public String getTargetCorpId() {
        return this.targetCorpId;
    }

    public SaveAndSubmitAuthInfoRequest setUnifiedSocialCredit(String unifiedSocialCredit) {
        this.unifiedSocialCredit = unifiedSocialCredit;
        return this;
    }
    public String getUnifiedSocialCredit() {
        return this.unifiedSocialCredit;
    }

}
