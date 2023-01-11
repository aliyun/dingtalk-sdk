// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class AnnualCertificationAuditRequest extends TeaModel {
    /**
     * <p>申请人手机号。</p>
     */
    @NameInMap("applicantMobile")
    public String applicantMobile;

    /**
     * <p>申请人姓名。</p>
     */
    @NameInMap("applicantName")
    public String applicantName;

    /**
     * <p>认证/修改认证授权函</p>
     */
    @NameInMap("applicationLetter")
    public String applicationLetter;

    /**
     * <p>结果状态  </p>
     * <p>1: 认证中预警 和 认证中需要补充材料 合并，通过code区分 </p>
     * <p>2:认证失败 </p>
     * <p>3:审核通过</p>
     */
    @NameInMap("authStatus")
    public Integer authStatus;

    /**
     * <p>证书类型：</p>
     * <br>
     * <p>0：社会统一信用代码</p>
     * <br>
     * <p>1：其它</p>
     */
    @NameInMap("certificateType")
    public Integer certificateType;

    /**
     * <p>用户提交的企业名称</p>
     */
    @NameInMap("corpName")
    public String corpName;

    /**
     * <p>开户行。</p>
     */
    @NameInMap("depositaryBank")
    public String depositaryBank;

    /**
     * <p>扩展字段，json格式传递，传递上面字段的额外字段。</p>
     */
    @NameInMap("extension")
    public String extension;

    /**
     * <p>法人姓名。</p>
     */
    @NameInMap("legalPerson")
    public String legalPerson;

    /**
     * <p>证件号：</p>
     * <br>
     * <p>营业执照注册号（一般15位）</p>
     * <br>
     * <p>社会统一信用代码（固定18位）</p>
     * <br>
     * <p>组织机构代码证号（格式11111111-1）</p>
     */
    @NameInMap("licenseNumber")
    public String licenseNumber;

    /**
     * <p>企业证件照片url。</p>
     */
    @NameInMap("licenseUrl")
    public String licenseUrl;

    /**
     * <p>订单ID</p>
     */
    @NameInMap("orderId")
    public String orderId;

    /**
     * <p>对公账号。</p>
     */
    @NameInMap("publicAccount")
    public String publicAccount;

    /**
     * <p>失败原因，认证中预警 和 认证中需要补充材料以及认证失败时需要提供。</p>
     */
    @NameInMap("reasonCode")
    public String reasonCode;

    @NameInMap("reasonMsg")
    public String reasonMsg;

    /**
     * <p>送审打标类型：</p>
     * <br>
     * <p>"V":四要素通过</p>
     * <br>
     * <p>"AV"：四要素未通过</p>
     */
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
