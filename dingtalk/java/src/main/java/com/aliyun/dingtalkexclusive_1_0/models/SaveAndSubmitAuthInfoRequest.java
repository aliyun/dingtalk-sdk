// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SaveAndSubmitAuthInfoRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>XXX组织申请高级认证</p>
     */
    @NameInMap("applyRemark")
    public String applyRemark;

    /**
     * <strong>example:</strong>
     * <p>@lQLxxxxxxxxVvjg8zImwm6t1BYIUNv0Cas0x7UA-AA</p>
     */
    @NameInMap("authorizeMediaId")
    public String authorizeMediaId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>计算机</p>
     */
    @NameInMap("industry")
    public String industry;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>钉三多</p>
     */
    @NameInMap("legalPerson")
    public String legalPerson;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>3301XX1997XXXXXXXXX</p>
     */
    @NameInMap("legalPersonIdCard")
    public String legalPersonIdCard;

    /**
     * <strong>example:</strong>
     * <p>@lQLxxxxxxxxVvjg8zImwm6t1BYIUNv0Cas0x7UA-AA</p>
     */
    @NameInMap("licenseMediaId")
    public String licenseMediaId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>330100</p>
     */
    @NameInMap("locCity")
    public Long locCity;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>杭州</p>
     */
    @NameInMap("locCityName")
    public String locCityName;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>330000</p>
     */
    @NameInMap("locProvince")
    public Long locProvince;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>浙江</p>
     */
    @NameInMap("locProvinceName")
    public String locProvinceName;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>15869110714</p>
     */
    @NameInMap("mobileNum")
    public String mobileNum;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>测试组织</p>
     */
    @NameInMap("orgName")
    public String orgName;

    /**
     * <strong>example:</strong>
     * <p>11111111-1</p>
     */
    @NameInMap("organizationCode")
    public String organizationCode;

    /**
     * <strong>example:</strong>
     * <p>@lQLxxxxxxxxVvjg8zImwm6t1BYIUNv0Cas0x7UA-AA</p>
     */
    @NameInMap("organizationCodeMediaId")
    public String organizationCodeMediaId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>余杭区文一西路XX号</p>
     */
    @NameInMap("registLocation")
    public String registLocation;

    /**
     * <strong>example:</strong>
     * <p>1111111111111111</p>
     */
    @NameInMap("registNum")
    public String registNum;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>dingxxxxxxxxxxxx</p>
     */
    @NameInMap("targetCorpId")
    public String targetCorpId;

    /**
     * <strong>example:</strong>
     * <p>9111111XX2957XX4X</p>
     */
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
