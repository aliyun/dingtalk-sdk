// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SaveAndSubmitAuthInfoRequest extends TeaModel {
    /**
     * <p>申请说明</p>
     */
    @NameInMap("applyRemark")
    public String applyRemark;

    /**
     * <p>认证书图片mediaId</p>
     */
    @NameInMap("authorizeMediaId")
    public String authorizeMediaId;

    /**
     * <p>行业</p>
     */
    @NameInMap("industry")
    public String industry;

    /**
     * <p>企业法人</p>
     */
    @NameInMap("legalPerson")
    public String legalPerson;

    /**
     * <p>企业法人身份证</p>
     */
    @NameInMap("legalPersonIdCard")
    public String legalPersonIdCard;

    /**
     * <p>营业执照图片mediaId</p>
     */
    @NameInMap("licenseMediaId")
    public String licenseMediaId;

    /**
     * <p>城市编码</p>
     */
    @NameInMap("locCity")
    public Long locCity;

    /**
     * <p>城市名字</p>
     */
    @NameInMap("locCityName")
    public String locCityName;

    /**
     * <p>省份编码</p>
     */
    @NameInMap("locProvince")
    public Long locProvince;

    /**
     * <p>省份名字</p>
     */
    @NameInMap("locProvinceName")
    public String locProvinceName;

    /**
     * <p>申请人手机号（需要实名认证）</p>
     */
    @NameInMap("mobileNum")
    public String mobileNum;

    /**
     * <p>组织名，提交认证的时候可以修改</p>
     */
    @NameInMap("orgName")
    public String orgName;

    /**
     * <p>组织机构代码证号（格式11111111-1）</p>
     */
    @NameInMap("organizationCode")
    public String organizationCode;

    /**
     * <p>组织机构代码证图片mediaId</p>
     */
    @NameInMap("organizationCodeMediaId")
    public String organizationCodeMediaId;

    /**
     * <p>认证企业详细地址</p>
     */
    @NameInMap("registLocation")
    public String registLocation;

    /**
     * <p>营业执照注册号（一般15位）</p>
     */
    @NameInMap("registNum")
    public String registNum;

    /**
     * <p>企业id</p>
     */
    @NameInMap("targetCorpId")
    public String targetCorpId;

    /**
     * <p>社会统一信用代码（固定18位）</p>
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
