// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class AnalyzeSubjectTransactionRiskRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("contractId")
    public Long contractId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("historyEndTime")
    public Long historyEndTime;

    @NameInMap("historyStartTime")
    public Long historyStartTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("staffId")
    public String staffId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("subjectUniqueCode")
    public String subjectUniqueCode;

    public static AnalyzeSubjectTransactionRiskRequest build(java.util.Map<String, ?> map) throws Exception {
        AnalyzeSubjectTransactionRiskRequest self = new AnalyzeSubjectTransactionRiskRequest();
        return TeaModel.build(map, self);
    }

    public AnalyzeSubjectTransactionRiskRequest setContractId(Long contractId) {
        this.contractId = contractId;
        return this;
    }
    public Long getContractId() {
        return this.contractId;
    }

    public AnalyzeSubjectTransactionRiskRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public AnalyzeSubjectTransactionRiskRequest setHistoryEndTime(Long historyEndTime) {
        this.historyEndTime = historyEndTime;
        return this;
    }
    public Long getHistoryEndTime() {
        return this.historyEndTime;
    }

    public AnalyzeSubjectTransactionRiskRequest setHistoryStartTime(Long historyStartTime) {
        this.historyStartTime = historyStartTime;
        return this;
    }
    public Long getHistoryStartTime() {
        return this.historyStartTime;
    }

    public AnalyzeSubjectTransactionRiskRequest setStaffId(String staffId) {
        this.staffId = staffId;
        return this;
    }
    public String getStaffId() {
        return this.staffId;
    }

    public AnalyzeSubjectTransactionRiskRequest setSubjectUniqueCode(String subjectUniqueCode) {
        this.subjectUniqueCode = subjectUniqueCode;
        return this;
    }
    public String getSubjectUniqueCode() {
        return this.subjectUniqueCode;
    }

}
