// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetOrgAuthInfoResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("authLevel")
    public Long authLevel;

    @NameInMap("legalPerson")
    public String legalPerson;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("licenseOrgName")
    public String licenseOrgName;

    @NameInMap("licenseUrl")
    public String licenseUrl;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("orgName")
    public String orgName;

    @NameInMap("organizationCode")
    public String organizationCode;

    @NameInMap("registrationNum")
    public String registrationNum;

    @NameInMap("unifiedSocialCredit")
    public String unifiedSocialCredit;

    public static GetOrgAuthInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetOrgAuthInfoResponseBody self = new GetOrgAuthInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetOrgAuthInfoResponseBody setAuthLevel(Long authLevel) {
        this.authLevel = authLevel;
        return this;
    }
    public Long getAuthLevel() {
        return this.authLevel;
    }

    public GetOrgAuthInfoResponseBody setLegalPerson(String legalPerson) {
        this.legalPerson = legalPerson;
        return this;
    }
    public String getLegalPerson() {
        return this.legalPerson;
    }

    public GetOrgAuthInfoResponseBody setLicenseOrgName(String licenseOrgName) {
        this.licenseOrgName = licenseOrgName;
        return this;
    }
    public String getLicenseOrgName() {
        return this.licenseOrgName;
    }

    public GetOrgAuthInfoResponseBody setLicenseUrl(String licenseUrl) {
        this.licenseUrl = licenseUrl;
        return this;
    }
    public String getLicenseUrl() {
        return this.licenseUrl;
    }

    public GetOrgAuthInfoResponseBody setOrgName(String orgName) {
        this.orgName = orgName;
        return this;
    }
    public String getOrgName() {
        return this.orgName;
    }

    public GetOrgAuthInfoResponseBody setOrganizationCode(String organizationCode) {
        this.organizationCode = organizationCode;
        return this;
    }
    public String getOrganizationCode() {
        return this.organizationCode;
    }

    public GetOrgAuthInfoResponseBody setRegistrationNum(String registrationNum) {
        this.registrationNum = registrationNum;
        return this;
    }
    public String getRegistrationNum() {
        return this.registrationNum;
    }

    public GetOrgAuthInfoResponseBody setUnifiedSocialCredit(String unifiedSocialCredit) {
        this.unifiedSocialCredit = unifiedSocialCredit;
        return this;
    }
    public String getUnifiedSocialCredit() {
        return this.unifiedSocialCredit;
    }

}
