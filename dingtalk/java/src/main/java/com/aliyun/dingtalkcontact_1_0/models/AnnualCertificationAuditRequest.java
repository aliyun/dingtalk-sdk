// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class AnnualCertificationAuditRequest extends TeaModel {
    @NameInMap("applicantMobile")
    public String applicantMobile;

    @NameInMap("applicantName")
    public String applicantName;

    @NameInMap("applicationLetter")
    public String applicationLetter;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("authStatus")
    public Integer authStatus;

    @NameInMap("certificateType")
    public Integer certificateType;

    @NameInMap("corpName")
    public String corpName;

    @NameInMap("depositaryBank")
    public String depositaryBank;

    @NameInMap("extension")
    public String extension;

    @NameInMap("legalPerson")
    public String legalPerson;

    @NameInMap("licenseNumber")
    public String licenseNumber;

    @NameInMap("licenseUrl")
    public String licenseUrl;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("orderId")
    public String orderId;

    @NameInMap("publicAccount")
    public String publicAccount;

    @NameInMap("reasonCode")
    public String reasonCode;

    @NameInMap("reasonMsg")
    public String reasonMsg;

    @NameInMap("tag")
    public String tag;

    public static AnnualCertificationAuditRequest build(java.util.Map<String, ?> map) throws Exception {
        AnnualCertificationAuditRequest self = new AnnualCertificationAuditRequest();
        return TeaModel.build(map, self);
    }

    public AnnualCertificationAuditRequest setApplicantMobile(String applicantMobile) {
        this.applicantMobile = applicantMobile;
        return this;
    }
    public String getApplicantMobile() {
        return this.applicantMobile;
    }

    public AnnualCertificationAuditRequest setApplicantName(String applicantName) {
        this.applicantName = applicantName;
        return this;
    }
    public String getApplicantName() {
        return this.applicantName;
    }

    public AnnualCertificationAuditRequest setApplicationLetter(String applicationLetter) {
        this.applicationLetter = applicationLetter;
        return this;
    }
    public String getApplicationLetter() {
        return this.applicationLetter;
    }

    public AnnualCertificationAuditRequest setAuthStatus(Integer authStatus) {
        this.authStatus = authStatus;
        return this;
    }
    public Integer getAuthStatus() {
        return this.authStatus;
    }

    public AnnualCertificationAuditRequest setCertificateType(Integer certificateType) {
        this.certificateType = certificateType;
        return this;
    }
    public Integer getCertificateType() {
        return this.certificateType;
    }

    public AnnualCertificationAuditRequest setCorpName(String corpName) {
        this.corpName = corpName;
        return this;
    }
    public String getCorpName() {
        return this.corpName;
    }

    public AnnualCertificationAuditRequest setDepositaryBank(String depositaryBank) {
        this.depositaryBank = depositaryBank;
        return this;
    }
    public String getDepositaryBank() {
        return this.depositaryBank;
    }

    public AnnualCertificationAuditRequest setExtension(String extension) {
        this.extension = extension;
        return this;
    }
    public String getExtension() {
        return this.extension;
    }

    public AnnualCertificationAuditRequest setLegalPerson(String legalPerson) {
        this.legalPerson = legalPerson;
        return this;
    }
    public String getLegalPerson() {
        return this.legalPerson;
    }

    public AnnualCertificationAuditRequest setLicenseNumber(String licenseNumber) {
        this.licenseNumber = licenseNumber;
        return this;
    }
    public String getLicenseNumber() {
        return this.licenseNumber;
    }

    public AnnualCertificationAuditRequest setLicenseUrl(String licenseUrl) {
        this.licenseUrl = licenseUrl;
        return this;
    }
    public String getLicenseUrl() {
        return this.licenseUrl;
    }

    public AnnualCertificationAuditRequest setOrderId(String orderId) {
        this.orderId = orderId;
        return this;
    }
    public String getOrderId() {
        return this.orderId;
    }

    public AnnualCertificationAuditRequest setPublicAccount(String publicAccount) {
        this.publicAccount = publicAccount;
        return this;
    }
    public String getPublicAccount() {
        return this.publicAccount;
    }

    public AnnualCertificationAuditRequest setReasonCode(String reasonCode) {
        this.reasonCode = reasonCode;
        return this;
    }
    public String getReasonCode() {
        return this.reasonCode;
    }

    public AnnualCertificationAuditRequest setReasonMsg(String reasonMsg) {
        this.reasonMsg = reasonMsg;
        return this;
    }
    public String getReasonMsg() {
        return this.reasonMsg;
    }

    public AnnualCertificationAuditRequest setTag(String tag) {
        this.tag = tag;
        return this;
    }
    public String getTag() {
        return this.tag;
    }

}
