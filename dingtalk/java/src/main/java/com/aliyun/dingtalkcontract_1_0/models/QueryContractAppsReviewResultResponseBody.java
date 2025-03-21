// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QueryContractAppsReviewResultResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryContractAppsReviewResultResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryContractAppsReviewResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryContractAppsReviewResultResponseBody self = new QueryContractAppsReviewResultResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryContractAppsReviewResultResponseBody setResult(QueryContractAppsReviewResultResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryContractAppsReviewResultResponseBodyResult getResult() {
        return this.result;
    }

    public QueryContractAppsReviewResultResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryContractAppsReviewResultResponseBodyResultDataReviewRiskDetailSubRisks extends TeaModel {
        @NameInMap("originalContent")
        public String originalContent;

        @NameInMap("resultContent")
        public String resultContent;

        @NameInMap("resultType")
        public String resultType;

        @NameInMap("riskBrief")
        public String riskBrief;

        @NameInMap("riskClause")
        public String riskClause;

        @NameInMap("riskExplain")
        public String riskExplain;

        public static QueryContractAppsReviewResultResponseBodyResultDataReviewRiskDetailSubRisks build(java.util.Map<String, ?> map) throws Exception {
            QueryContractAppsReviewResultResponseBodyResultDataReviewRiskDetailSubRisks self = new QueryContractAppsReviewResultResponseBodyResultDataReviewRiskDetailSubRisks();
            return TeaModel.build(map, self);
        }

        public QueryContractAppsReviewResultResponseBodyResultDataReviewRiskDetailSubRisks setOriginalContent(String originalContent) {
            this.originalContent = originalContent;
            return this;
        }
        public String getOriginalContent() {
            return this.originalContent;
        }

        public QueryContractAppsReviewResultResponseBodyResultDataReviewRiskDetailSubRisks setResultContent(String resultContent) {
            this.resultContent = resultContent;
            return this;
        }
        public String getResultContent() {
            return this.resultContent;
        }

        public QueryContractAppsReviewResultResponseBodyResultDataReviewRiskDetailSubRisks setResultType(String resultType) {
            this.resultType = resultType;
            return this;
        }
        public String getResultType() {
            return this.resultType;
        }

        public QueryContractAppsReviewResultResponseBodyResultDataReviewRiskDetailSubRisks setRiskBrief(String riskBrief) {
            this.riskBrief = riskBrief;
            return this;
        }
        public String getRiskBrief() {
            return this.riskBrief;
        }

        public QueryContractAppsReviewResultResponseBodyResultDataReviewRiskDetailSubRisks setRiskClause(String riskClause) {
            this.riskClause = riskClause;
            return this;
        }
        public String getRiskClause() {
            return this.riskClause;
        }

        public QueryContractAppsReviewResultResponseBodyResultDataReviewRiskDetailSubRisks setRiskExplain(String riskExplain) {
            this.riskExplain = riskExplain;
            return this;
        }
        public String getRiskExplain() {
            return this.riskExplain;
        }

    }

    public static class QueryContractAppsReviewResultResponseBodyResultDataReviewRiskDetail extends TeaModel {
        @NameInMap("examineBrief")
        public String examineBrief;

        @NameInMap("examineResult")
        public String examineResult;

        @NameInMap("examineStatus")
        public String examineStatus;

        @NameInMap("riskLevel")
        public String riskLevel;

        @NameInMap("ruleSequence")
        public String ruleSequence;

        @NameInMap("ruleTag")
        public String ruleTag;

        @NameInMap("ruleTitle")
        public String ruleTitle;

        @NameInMap("subRisks")
        public java.util.List<QueryContractAppsReviewResultResponseBodyResultDataReviewRiskDetailSubRisks> subRisks;

        public static QueryContractAppsReviewResultResponseBodyResultDataReviewRiskDetail build(java.util.Map<String, ?> map) throws Exception {
            QueryContractAppsReviewResultResponseBodyResultDataReviewRiskDetail self = new QueryContractAppsReviewResultResponseBodyResultDataReviewRiskDetail();
            return TeaModel.build(map, self);
        }

        public QueryContractAppsReviewResultResponseBodyResultDataReviewRiskDetail setExamineBrief(String examineBrief) {
            this.examineBrief = examineBrief;
            return this;
        }
        public String getExamineBrief() {
            return this.examineBrief;
        }

        public QueryContractAppsReviewResultResponseBodyResultDataReviewRiskDetail setExamineResult(String examineResult) {
            this.examineResult = examineResult;
            return this;
        }
        public String getExamineResult() {
            return this.examineResult;
        }

        public QueryContractAppsReviewResultResponseBodyResultDataReviewRiskDetail setExamineStatus(String examineStatus) {
            this.examineStatus = examineStatus;
            return this;
        }
        public String getExamineStatus() {
            return this.examineStatus;
        }

        public QueryContractAppsReviewResultResponseBodyResultDataReviewRiskDetail setRiskLevel(String riskLevel) {
            this.riskLevel = riskLevel;
            return this;
        }
        public String getRiskLevel() {
            return this.riskLevel;
        }

        public QueryContractAppsReviewResultResponseBodyResultDataReviewRiskDetail setRuleSequence(String ruleSequence) {
            this.ruleSequence = ruleSequence;
            return this;
        }
        public String getRuleSequence() {
            return this.ruleSequence;
        }

        public QueryContractAppsReviewResultResponseBodyResultDataReviewRiskDetail setRuleTag(String ruleTag) {
            this.ruleTag = ruleTag;
            return this;
        }
        public String getRuleTag() {
            return this.ruleTag;
        }

        public QueryContractAppsReviewResultResponseBodyResultDataReviewRiskDetail setRuleTitle(String ruleTitle) {
            this.ruleTitle = ruleTitle;
            return this;
        }
        public String getRuleTitle() {
            return this.ruleTitle;
        }

        public QueryContractAppsReviewResultResponseBodyResultDataReviewRiskDetail setSubRisks(java.util.List<QueryContractAppsReviewResultResponseBodyResultDataReviewRiskDetailSubRisks> subRisks) {
            this.subRisks = subRisks;
            return this;
        }
        public java.util.List<QueryContractAppsReviewResultResponseBodyResultDataReviewRiskDetailSubRisks> getSubRisks() {
            return this.subRisks;
        }

    }

    public static class QueryContractAppsReviewResultResponseBodyResultDataReviewRiskOverview extends TeaModel {
        @NameInMap("hasRisk")
        public Boolean hasRisk;

        @NameInMap("highRisk")
        public Integer highRisk;

        @NameInMap("lowRisk")
        public Integer lowRisk;

        @NameInMap("mediumRisk")
        public Integer mediumRisk;

        public static QueryContractAppsReviewResultResponseBodyResultDataReviewRiskOverview build(java.util.Map<String, ?> map) throws Exception {
            QueryContractAppsReviewResultResponseBodyResultDataReviewRiskOverview self = new QueryContractAppsReviewResultResponseBodyResultDataReviewRiskOverview();
            return TeaModel.build(map, self);
        }

        public QueryContractAppsReviewResultResponseBodyResultDataReviewRiskOverview setHasRisk(Boolean hasRisk) {
            this.hasRisk = hasRisk;
            return this;
        }
        public Boolean getHasRisk() {
            return this.hasRisk;
        }

        public QueryContractAppsReviewResultResponseBodyResultDataReviewRiskOverview setHighRisk(Integer highRisk) {
            this.highRisk = highRisk;
            return this;
        }
        public Integer getHighRisk() {
            return this.highRisk;
        }

        public QueryContractAppsReviewResultResponseBodyResultDataReviewRiskOverview setLowRisk(Integer lowRisk) {
            this.lowRisk = lowRisk;
            return this;
        }
        public Integer getLowRisk() {
            return this.lowRisk;
        }

        public QueryContractAppsReviewResultResponseBodyResultDataReviewRiskOverview setMediumRisk(Integer mediumRisk) {
            this.mediumRisk = mediumRisk;
            return this;
        }
        public Integer getMediumRisk() {
            return this.mediumRisk;
        }

    }

    public static class QueryContractAppsReviewResultResponseBodyResultDataReviewStatus extends TeaModel {
        @NameInMap("overview")
        public String overview;

        @NameInMap("result")
        public String result;

        @NameInMap("rule")
        public String rule;

        @NameInMap("stage")
        public String stage;

        public static QueryContractAppsReviewResultResponseBodyResultDataReviewStatus build(java.util.Map<String, ?> map) throws Exception {
            QueryContractAppsReviewResultResponseBodyResultDataReviewStatus self = new QueryContractAppsReviewResultResponseBodyResultDataReviewStatus();
            return TeaModel.build(map, self);
        }

        public QueryContractAppsReviewResultResponseBodyResultDataReviewStatus setOverview(String overview) {
            this.overview = overview;
            return this;
        }
        public String getOverview() {
            return this.overview;
        }

        public QueryContractAppsReviewResultResponseBodyResultDataReviewStatus setResult(String result) {
            this.result = result;
            return this;
        }
        public String getResult() {
            return this.result;
        }

        public QueryContractAppsReviewResultResponseBodyResultDataReviewStatus setRule(String rule) {
            this.rule = rule;
            return this;
        }
        public String getRule() {
            return this.rule;
        }

        public QueryContractAppsReviewResultResponseBodyResultDataReviewStatus setStage(String stage) {
            this.stage = stage;
            return this;
        }
        public String getStage() {
            return this.stage;
        }

    }

    public static class QueryContractAppsReviewResultResponseBodyResultData extends TeaModel {
        @NameInMap("reviewRiskDetail")
        public java.util.List<QueryContractAppsReviewResultResponseBodyResultDataReviewRiskDetail> reviewRiskDetail;

        @NameInMap("reviewRiskOverview")
        public QueryContractAppsReviewResultResponseBodyResultDataReviewRiskOverview reviewRiskOverview;

        @NameInMap("reviewStatus")
        public QueryContractAppsReviewResultResponseBodyResultDataReviewStatus reviewStatus;

        public static QueryContractAppsReviewResultResponseBodyResultData build(java.util.Map<String, ?> map) throws Exception {
            QueryContractAppsReviewResultResponseBodyResultData self = new QueryContractAppsReviewResultResponseBodyResultData();
            return TeaModel.build(map, self);
        }

        public QueryContractAppsReviewResultResponseBodyResultData setReviewRiskDetail(java.util.List<QueryContractAppsReviewResultResponseBodyResultDataReviewRiskDetail> reviewRiskDetail) {
            this.reviewRiskDetail = reviewRiskDetail;
            return this;
        }
        public java.util.List<QueryContractAppsReviewResultResponseBodyResultDataReviewRiskDetail> getReviewRiskDetail() {
            return this.reviewRiskDetail;
        }

        public QueryContractAppsReviewResultResponseBodyResultData setReviewRiskOverview(QueryContractAppsReviewResultResponseBodyResultDataReviewRiskOverview reviewRiskOverview) {
            this.reviewRiskOverview = reviewRiskOverview;
            return this;
        }
        public QueryContractAppsReviewResultResponseBodyResultDataReviewRiskOverview getReviewRiskOverview() {
            return this.reviewRiskOverview;
        }

        public QueryContractAppsReviewResultResponseBodyResultData setReviewStatus(QueryContractAppsReviewResultResponseBodyResultDataReviewStatus reviewStatus) {
            this.reviewStatus = reviewStatus;
            return this;
        }
        public QueryContractAppsReviewResultResponseBodyResultDataReviewStatus getReviewStatus() {
            return this.reviewStatus;
        }

    }

    public static class QueryContractAppsReviewResultResponseBodyResult extends TeaModel {
        @NameInMap("data")
        public QueryContractAppsReviewResultResponseBodyResultData data;

        @NameInMap("requestId")
        public String requestId;

        public static QueryContractAppsReviewResultResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryContractAppsReviewResultResponseBodyResult self = new QueryContractAppsReviewResultResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryContractAppsReviewResultResponseBodyResult setData(QueryContractAppsReviewResultResponseBodyResultData data) {
            this.data = data;
            return this;
        }
        public QueryContractAppsReviewResultResponseBodyResultData getData() {
            return this.data;
        }

        public QueryContractAppsReviewResultResponseBodyResult setRequestId(String requestId) {
            this.requestId = requestId;
            return this;
        }
        public String getRequestId() {
            return this.requestId;
        }

    }

}
