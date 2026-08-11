// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QuerySubjectPublicRiskRequest extends TeaModel {
    @NameInMap("bizId")
    public String bizId;

    @NameInMap("companyId")
    public String companyId;

    @NameInMap("contractAmount")
    public Long contractAmount;

    @NameInMap("contractType")
    public String contractType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("creditCode")
    public String creditCode;

    @NameInMap("from")
    public String from;

    @NameInMap("registrationNumber")
    public String registrationNumber;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("staffId")
    public String staffId;

    @NameInMap("subjectName")
    public String subjectName;

    public static QuerySubjectPublicRiskRequest build(java.util.Map<String, ?> map) throws Exception {
        QuerySubjectPublicRiskRequest self = new QuerySubjectPublicRiskRequest();
        return TeaModel.build(map, self);
    }

    public QuerySubjectPublicRiskRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public QuerySubjectPublicRiskRequest setCompanyId(String companyId) {
        this.companyId = companyId;
        return this;
    }
    public String getCompanyId() {
        return this.companyId;
    }

    public QuerySubjectPublicRiskRequest setContractAmount(Long contractAmount) {
        this.contractAmount = contractAmount;
        return this;
    }
    public Long getContractAmount() {
        return this.contractAmount;
    }

    public QuerySubjectPublicRiskRequest setContractType(String contractType) {
        this.contractType = contractType;
        return this;
    }
    public String getContractType() {
        return this.contractType;
    }

    public QuerySubjectPublicRiskRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public QuerySubjectPublicRiskRequest setCreditCode(String creditCode) {
        this.creditCode = creditCode;
        return this;
    }
    public String getCreditCode() {
        return this.creditCode;
    }

    public QuerySubjectPublicRiskRequest setFrom(String from) {
        this.from = from;
        return this;
    }
    public String getFrom() {
        return this.from;
    }

    public QuerySubjectPublicRiskRequest setRegistrationNumber(String registrationNumber) {
        this.registrationNumber = registrationNumber;
        return this;
    }
    public String getRegistrationNumber() {
        return this.registrationNumber;
    }

    public QuerySubjectPublicRiskRequest setStaffId(String staffId) {
        this.staffId = staffId;
        return this;
    }
    public String getStaffId() {
        return this.staffId;
    }

    public QuerySubjectPublicRiskRequest setSubjectName(String subjectName) {
        this.subjectName = subjectName;
        return this;
    }
    public String getSubjectName() {
        return this.subjectName;
    }

}
