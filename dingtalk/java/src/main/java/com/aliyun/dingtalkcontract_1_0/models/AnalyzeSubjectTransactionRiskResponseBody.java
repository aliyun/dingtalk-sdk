// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class AnalyzeSubjectTransactionRiskResponseBody extends TeaModel {
    @NameInMap("result")
    public AnalyzeSubjectTransactionRiskResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static AnalyzeSubjectTransactionRiskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AnalyzeSubjectTransactionRiskResponseBody self = new AnalyzeSubjectTransactionRiskResponseBody();
        return TeaModel.build(map, self);
    }

    public AnalyzeSubjectTransactionRiskResponseBody setResult(AnalyzeSubjectTransactionRiskResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public AnalyzeSubjectTransactionRiskResponseBodyResult getResult() {
        return this.result;
    }

    public AnalyzeSubjectTransactionRiskResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class AnalyzeSubjectTransactionRiskResponseBodyResultAiAnalysisKeyRisks extends TeaModel {
        @NameInMap("evidence")
        public String evidence;

        @NameInMap("impact")
        public String impact;

        @NameInMap("riskName")
        public String riskName;

        @NameInMap("suggestion")
        public String suggestion;

        public static AnalyzeSubjectTransactionRiskResponseBodyResultAiAnalysisKeyRisks build(java.util.Map<String, ?> map) throws Exception {
            AnalyzeSubjectTransactionRiskResponseBodyResultAiAnalysisKeyRisks self = new AnalyzeSubjectTransactionRiskResponseBodyResultAiAnalysisKeyRisks();
            return TeaModel.build(map, self);
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultAiAnalysisKeyRisks setEvidence(String evidence) {
            this.evidence = evidence;
            return this;
        }
        public String getEvidence() {
            return this.evidence;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultAiAnalysisKeyRisks setImpact(String impact) {
            this.impact = impact;
            return this;
        }
        public String getImpact() {
            return this.impact;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultAiAnalysisKeyRisks setRiskName(String riskName) {
            this.riskName = riskName;
            return this;
        }
        public String getRiskName() {
            return this.riskName;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultAiAnalysisKeyRisks setSuggestion(String suggestion) {
            this.suggestion = suggestion;
            return this;
        }
        public String getSuggestion() {
            return this.suggestion;
        }

    }

    public static class AnalyzeSubjectTransactionRiskResponseBodyResultAiAnalysis extends TeaModel {
        @NameInMap("keyRisks")
        public java.util.List<AnalyzeSubjectTransactionRiskResponseBodyResultAiAnalysisKeyRisks> keyRisks;

        @NameInMap("limitations")
        public java.util.List<String> limitations;

        @NameInMap("status")
        public String status;

        @NameInMap("summary")
        public String summary;

        public static AnalyzeSubjectTransactionRiskResponseBodyResultAiAnalysis build(java.util.Map<String, ?> map) throws Exception {
            AnalyzeSubjectTransactionRiskResponseBodyResultAiAnalysis self = new AnalyzeSubjectTransactionRiskResponseBodyResultAiAnalysis();
            return TeaModel.build(map, self);
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultAiAnalysis setKeyRisks(java.util.List<AnalyzeSubjectTransactionRiskResponseBodyResultAiAnalysisKeyRisks> keyRisks) {
            this.keyRisks = keyRisks;
            return this;
        }
        public java.util.List<AnalyzeSubjectTransactionRiskResponseBodyResultAiAnalysisKeyRisks> getKeyRisks() {
            return this.keyRisks;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultAiAnalysis setLimitations(java.util.List<String> limitations) {
            this.limitations = limitations;
            return this;
        }
        public java.util.List<String> getLimitations() {
            return this.limitations;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultAiAnalysis setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultAiAnalysis setSummary(String summary) {
            this.summary = summary;
            return this;
        }
        public String getSummary() {
            return this.summary;
        }

    }

    public static class AnalyzeSubjectTransactionRiskResponseBodyResultCurrentContract extends TeaModel {
        @NameInMap("acceptanceTerms")
        public String acceptanceTerms;

        @NameInMap("breachLiability")
        public String breachLiability;

        @NameInMap("contractAmount")
        public String contractAmount;

        @NameInMap("contractId")
        public Long contractId;

        @NameInMap("contractName")
        public String contractName;

        @NameInMap("contractSubject")
        public String contractSubject;

        @NameInMap("contractType")
        public String contractType;

        @NameInMap("contractVersion")
        public Long contractVersion;

        @NameInMap("currency")
        public String currency;

        @NameInMap("dataStatus")
        public String dataStatus;

        @NameInMap("deliveryTerms")
        public String deliveryTerms;

        @NameInMap("disputeResolution")
        public String disputeResolution;

        @NameInMap("guaranteeTerms")
        public String guaranteeTerms;

        @NameInMap("missingFields")
        public java.util.List<String> missingFields;

        @NameInMap("paymentTerms")
        public String paymentTerms;

        @NameInMap("performancePeriod")
        public String performancePeriod;

        @NameInMap("terminationTerms")
        public String terminationTerms;

        @NameInMap("transactionDirection")
        public String transactionDirection;

        public static AnalyzeSubjectTransactionRiskResponseBodyResultCurrentContract build(java.util.Map<String, ?> map) throws Exception {
            AnalyzeSubjectTransactionRiskResponseBodyResultCurrentContract self = new AnalyzeSubjectTransactionRiskResponseBodyResultCurrentContract();
            return TeaModel.build(map, self);
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultCurrentContract setAcceptanceTerms(String acceptanceTerms) {
            this.acceptanceTerms = acceptanceTerms;
            return this;
        }
        public String getAcceptanceTerms() {
            return this.acceptanceTerms;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultCurrentContract setBreachLiability(String breachLiability) {
            this.breachLiability = breachLiability;
            return this;
        }
        public String getBreachLiability() {
            return this.breachLiability;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultCurrentContract setContractAmount(String contractAmount) {
            this.contractAmount = contractAmount;
            return this;
        }
        public String getContractAmount() {
            return this.contractAmount;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultCurrentContract setContractId(Long contractId) {
            this.contractId = contractId;
            return this;
        }
        public Long getContractId() {
            return this.contractId;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultCurrentContract setContractName(String contractName) {
            this.contractName = contractName;
            return this;
        }
        public String getContractName() {
            return this.contractName;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultCurrentContract setContractSubject(String contractSubject) {
            this.contractSubject = contractSubject;
            return this;
        }
        public String getContractSubject() {
            return this.contractSubject;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultCurrentContract setContractType(String contractType) {
            this.contractType = contractType;
            return this;
        }
        public String getContractType() {
            return this.contractType;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultCurrentContract setContractVersion(Long contractVersion) {
            this.contractVersion = contractVersion;
            return this;
        }
        public Long getContractVersion() {
            return this.contractVersion;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultCurrentContract setCurrency(String currency) {
            this.currency = currency;
            return this;
        }
        public String getCurrency() {
            return this.currency;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultCurrentContract setDataStatus(String dataStatus) {
            this.dataStatus = dataStatus;
            return this;
        }
        public String getDataStatus() {
            return this.dataStatus;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultCurrentContract setDeliveryTerms(String deliveryTerms) {
            this.deliveryTerms = deliveryTerms;
            return this;
        }
        public String getDeliveryTerms() {
            return this.deliveryTerms;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultCurrentContract setDisputeResolution(String disputeResolution) {
            this.disputeResolution = disputeResolution;
            return this;
        }
        public String getDisputeResolution() {
            return this.disputeResolution;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultCurrentContract setGuaranteeTerms(String guaranteeTerms) {
            this.guaranteeTerms = guaranteeTerms;
            return this;
        }
        public String getGuaranteeTerms() {
            return this.guaranteeTerms;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultCurrentContract setMissingFields(java.util.List<String> missingFields) {
            this.missingFields = missingFields;
            return this;
        }
        public java.util.List<String> getMissingFields() {
            return this.missingFields;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultCurrentContract setPaymentTerms(String paymentTerms) {
            this.paymentTerms = paymentTerms;
            return this;
        }
        public String getPaymentTerms() {
            return this.paymentTerms;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultCurrentContract setPerformancePeriod(String performancePeriod) {
            this.performancePeriod = performancePeriod;
            return this;
        }
        public String getPerformancePeriod() {
            return this.performancePeriod;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultCurrentContract setTerminationTerms(String terminationTerms) {
            this.terminationTerms = terminationTerms;
            return this;
        }
        public String getTerminationTerms() {
            return this.terminationTerms;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultCurrentContract setTransactionDirection(String transactionDirection) {
            this.transactionDirection = transactionDirection;
            return this;
        }
        public String getTransactionDirection() {
            return this.transactionDirection;
        }

    }

    public static class AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationExpenseAmounts extends TeaModel {
        @NameInMap("cNY")
        public String cNY;

        @NameInMap("uSD")
        public String uSD;

        public static AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationExpenseAmounts build(java.util.Map<String, ?> map) throws Exception {
            AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationExpenseAmounts self = new AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationExpenseAmounts();
            return TeaModel.build(map, self);
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationExpenseAmounts setCNY(String cNY) {
            this.cNY = cNY;
            return this;
        }
        public String getCNY() {
            return this.cNY;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationExpenseAmounts setUSD(String uSD) {
            this.uSD = uSD;
            return this;
        }
        public String getUSD() {
            return this.uSD;
        }

    }

    public static class AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationIncomeAmounts extends TeaModel {
        @NameInMap("cNY")
        public String cNY;

        @NameInMap("uSD")
        public String uSD;

        public static AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationIncomeAmounts build(java.util.Map<String, ?> map) throws Exception {
            AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationIncomeAmounts self = new AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationIncomeAmounts();
            return TeaModel.build(map, self);
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationIncomeAmounts setCNY(String cNY) {
            this.cNY = cNY;
            return this;
        }
        public String getCNY() {
            return this.cNY;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationIncomeAmounts setUSD(String uSD) {
            this.uSD = uSD;
            return this;
        }
        public String getUSD() {
            return this.uSD;
        }

    }

    public static class AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationRelatedContracts extends TeaModel {
        @NameInMap("contractAmount")
        public String contractAmount;

        @NameInMap("contractId")
        public Long contractId;

        @NameInMap("contractName")
        public String contractName;

        @NameInMap("contractType")
        public String contractType;

        @NameInMap("currency")
        public String currency;

        @NameInMap("endDate")
        public Long endDate;

        @NameInMap("startDate")
        public Long startDate;

        @NameInMap("transactionDirection")
        public String transactionDirection;

        public static AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationRelatedContracts build(java.util.Map<String, ?> map) throws Exception {
            AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationRelatedContracts self = new AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationRelatedContracts();
            return TeaModel.build(map, self);
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationRelatedContracts setContractAmount(String contractAmount) {
            this.contractAmount = contractAmount;
            return this;
        }
        public String getContractAmount() {
            return this.contractAmount;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationRelatedContracts setContractId(Long contractId) {
            this.contractId = contractId;
            return this;
        }
        public Long getContractId() {
            return this.contractId;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationRelatedContracts setContractName(String contractName) {
            this.contractName = contractName;
            return this;
        }
        public String getContractName() {
            return this.contractName;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationRelatedContracts setContractType(String contractType) {
            this.contractType = contractType;
            return this;
        }
        public String getContractType() {
            return this.contractType;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationRelatedContracts setCurrency(String currency) {
            this.currency = currency;
            return this;
        }
        public String getCurrency() {
            return this.currency;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationRelatedContracts setEndDate(Long endDate) {
            this.endDate = endDate;
            return this;
        }
        public Long getEndDate() {
            return this.endDate;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationRelatedContracts setStartDate(Long startDate) {
            this.startDate = startDate;
            return this;
        }
        public Long getStartDate() {
            return this.startDate;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationRelatedContracts setTransactionDirection(String transactionDirection) {
            this.transactionDirection = transactionDirection;
            return this;
        }
        public String getTransactionDirection() {
            return this.transactionDirection;
        }

    }

    public static class AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperation extends TeaModel {
        @NameInMap("expenseAmounts")
        public AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationExpenseAmounts expenseAmounts;

        @NameInMap("historyDataStatus")
        public String historyDataStatus;

        @NameInMap("historyEndTime")
        public Long historyEndTime;

        @NameInMap("historyStartTime")
        public Long historyStartTime;

        @NameInMap("incomeAmounts")
        public AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationIncomeAmounts incomeAmounts;

        @NameInMap("performanceAnomalies")
        public java.util.List<String> performanceAnomalies;

        @NameInMap("performanceDataStatus")
        public String performanceDataStatus;

        @NameInMap("periodContractCount")
        public Long periodContractCount;

        @NameInMap("relatedContracts")
        public java.util.List<AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationRelatedContracts> relatedContracts;

        @NameInMap("totalRelatedContractCount")
        public Long totalRelatedContractCount;

        public static AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperation build(java.util.Map<String, ?> map) throws Exception {
            AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperation self = new AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperation();
            return TeaModel.build(map, self);
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperation setExpenseAmounts(AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationExpenseAmounts expenseAmounts) {
            this.expenseAmounts = expenseAmounts;
            return this;
        }
        public AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationExpenseAmounts getExpenseAmounts() {
            return this.expenseAmounts;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperation setHistoryDataStatus(String historyDataStatus) {
            this.historyDataStatus = historyDataStatus;
            return this;
        }
        public String getHistoryDataStatus() {
            return this.historyDataStatus;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperation setHistoryEndTime(Long historyEndTime) {
            this.historyEndTime = historyEndTime;
            return this;
        }
        public Long getHistoryEndTime() {
            return this.historyEndTime;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperation setHistoryStartTime(Long historyStartTime) {
            this.historyStartTime = historyStartTime;
            return this;
        }
        public Long getHistoryStartTime() {
            return this.historyStartTime;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperation setIncomeAmounts(AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationIncomeAmounts incomeAmounts) {
            this.incomeAmounts = incomeAmounts;
            return this;
        }
        public AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationIncomeAmounts getIncomeAmounts() {
            return this.incomeAmounts;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperation setPerformanceAnomalies(java.util.List<String> performanceAnomalies) {
            this.performanceAnomalies = performanceAnomalies;
            return this;
        }
        public java.util.List<String> getPerformanceAnomalies() {
            return this.performanceAnomalies;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperation setPerformanceDataStatus(String performanceDataStatus) {
            this.performanceDataStatus = performanceDataStatus;
            return this;
        }
        public String getPerformanceDataStatus() {
            return this.performanceDataStatus;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperation setPeriodContractCount(Long periodContractCount) {
            this.periodContractCount = periodContractCount;
            return this;
        }
        public Long getPeriodContractCount() {
            return this.periodContractCount;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperation setRelatedContracts(java.util.List<AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationRelatedContracts> relatedContracts) {
            this.relatedContracts = relatedContracts;
            return this;
        }
        public java.util.List<AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperationRelatedContracts> getRelatedContracts() {
            return this.relatedContracts;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperation setTotalRelatedContractCount(Long totalRelatedContractCount) {
            this.totalRelatedContractCount = totalRelatedContractCount;
            return this;
        }
        public Long getTotalRelatedContractCount() {
            return this.totalRelatedContractCount;
        }

    }

    public static class AnalyzeSubjectTransactionRiskResponseBodyResultSubjectInfo extends TeaModel {
        @NameInMap("creditCode")
        public String creditCode;

        @NameInMap("relatedOwnSubjects")
        public java.util.List<String> relatedOwnSubjects;

        @NameInMap("subjectName")
        public String subjectName;

        @NameInMap("subjectTags")
        public java.util.List<String> subjectTags;

        @NameInMap("uniqueCode")
        public String uniqueCode;

        public static AnalyzeSubjectTransactionRiskResponseBodyResultSubjectInfo build(java.util.Map<String, ?> map) throws Exception {
            AnalyzeSubjectTransactionRiskResponseBodyResultSubjectInfo self = new AnalyzeSubjectTransactionRiskResponseBodyResultSubjectInfo();
            return TeaModel.build(map, self);
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultSubjectInfo setCreditCode(String creditCode) {
            this.creditCode = creditCode;
            return this;
        }
        public String getCreditCode() {
            return this.creditCode;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultSubjectInfo setRelatedOwnSubjects(java.util.List<String> relatedOwnSubjects) {
            this.relatedOwnSubjects = relatedOwnSubjects;
            return this;
        }
        public java.util.List<String> getRelatedOwnSubjects() {
            return this.relatedOwnSubjects;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultSubjectInfo setSubjectName(String subjectName) {
            this.subjectName = subjectName;
            return this;
        }
        public String getSubjectName() {
            return this.subjectName;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultSubjectInfo setSubjectTags(java.util.List<String> subjectTags) {
            this.subjectTags = subjectTags;
            return this;
        }
        public java.util.List<String> getSubjectTags() {
            return this.subjectTags;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResultSubjectInfo setUniqueCode(String uniqueCode) {
            this.uniqueCode = uniqueCode;
            return this;
        }
        public String getUniqueCode() {
            return this.uniqueCode;
        }

    }

    public static class AnalyzeSubjectTransactionRiskResponseBodyResult extends TeaModel {
        @NameInMap("aiAnalysis")
        public AnalyzeSubjectTransactionRiskResponseBodyResultAiAnalysis aiAnalysis;

        @NameInMap("currentContract")
        public AnalyzeSubjectTransactionRiskResponseBodyResultCurrentContract currentContract;

        @NameInMap("dataStatus")
        public String dataStatus;

        @NameInMap("historyCooperation")
        public AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperation historyCooperation;

        @NameInMap("subjectInfo")
        public AnalyzeSubjectTransactionRiskResponseBodyResultSubjectInfo subjectInfo;

        public static AnalyzeSubjectTransactionRiskResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            AnalyzeSubjectTransactionRiskResponseBodyResult self = new AnalyzeSubjectTransactionRiskResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResult setAiAnalysis(AnalyzeSubjectTransactionRiskResponseBodyResultAiAnalysis aiAnalysis) {
            this.aiAnalysis = aiAnalysis;
            return this;
        }
        public AnalyzeSubjectTransactionRiskResponseBodyResultAiAnalysis getAiAnalysis() {
            return this.aiAnalysis;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResult setCurrentContract(AnalyzeSubjectTransactionRiskResponseBodyResultCurrentContract currentContract) {
            this.currentContract = currentContract;
            return this;
        }
        public AnalyzeSubjectTransactionRiskResponseBodyResultCurrentContract getCurrentContract() {
            return this.currentContract;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResult setDataStatus(String dataStatus) {
            this.dataStatus = dataStatus;
            return this;
        }
        public String getDataStatus() {
            return this.dataStatus;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResult setHistoryCooperation(AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperation historyCooperation) {
            this.historyCooperation = historyCooperation;
            return this;
        }
        public AnalyzeSubjectTransactionRiskResponseBodyResultHistoryCooperation getHistoryCooperation() {
            return this.historyCooperation;
        }

        public AnalyzeSubjectTransactionRiskResponseBodyResult setSubjectInfo(AnalyzeSubjectTransactionRiskResponseBodyResultSubjectInfo subjectInfo) {
            this.subjectInfo = subjectInfo;
            return this;
        }
        public AnalyzeSubjectTransactionRiskResponseBodyResultSubjectInfo getSubjectInfo() {
            return this.subjectInfo;
        }

    }

}
