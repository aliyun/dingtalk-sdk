// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetOrgAuthInfoResponseBody extends TeaModel {
    // 认证等级 1高级认证 2中级认证
    @NameInMap("authLevel")
    public Long authLevel;

    // 法人
    @NameInMap("legalPerson")
    public String legalPerson;

    // 提交企业认证时营业执照上面的企业名称
    @NameInMap("licenseOrgName")
    public String licenseOrgName;

    // 营业执照url
    @NameInMap("licenseUrl")
    public String licenseUrl;

    // 企业在钉钉通讯录的名称
    @NameInMap("orgName")
    public String orgName;

    // 组织机构代码证号（格式11111111-1）
    @NameInMap("organizationCode")
    public String organizationCode;

    // 营业执照注册号（一般15位）
    @NameInMap("registrationNum")
    public String registrationNum;

    // 社会统一信用代码（固定18位）
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
