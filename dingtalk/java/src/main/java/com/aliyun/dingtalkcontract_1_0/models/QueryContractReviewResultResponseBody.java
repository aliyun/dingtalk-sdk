// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QueryContractReviewResultResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryContractReviewResultResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryContractReviewResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryContractReviewResultResponseBody self = new QueryContractReviewResultResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryContractReviewResultResponseBody setResult(QueryContractReviewResultResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryContractReviewResultResponseBodyResult getResult() {
        return this.result;
    }

    public QueryContractReviewResultResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryContractReviewResultResponseBodyResultDataReviewRiskDetailSubRisks extends TeaModel {
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

        public static QueryContractReviewResultResponseBodyResultDataReviewRiskDetailSubRisks build(java.util.Map<String, ?> map) throws Exception {
            QueryContractReviewResultResponseBodyResultDataReviewRiskDetailSubRisks self = new QueryContractReviewResultResponseBodyResultDataReviewRiskDetailSubRisks();
            return TeaModel.build(map, self);
        }

        public QueryContractReviewResultResponseBodyResultDataReviewRiskDetailSubRisks setOriginalContent(String originalContent) {
            this.originalContent = originalContent;
            return this;
        }
        public String getOriginalContent() {
            return this.originalContent;
        }

        public QueryContractReviewResultResponseBodyResultDataReviewRiskDetailSubRisks setResultContent(String resultContent) {
            this.resultContent = resultContent;
            return this;
        }
        public String getResultContent() {
            return this.resultContent;
        }

        public QueryContractReviewResultResponseBodyResultDataReviewRiskDetailSubRisks setResultType(String resultType) {
            this.resultType = resultType;
            return this;
        }
        public String getResultType() {
            return this.resultType;
        }

        public QueryContractReviewResultResponseBodyResultDataReviewRiskDetailSubRisks setRiskBrief(String riskBrief) {
            this.riskBrief = riskBrief;
            return this;
        }
        public String getRiskBrief() {
            return this.riskBrief;
        }

        public QueryContractReviewResultResponseBodyResultDataReviewRiskDetailSubRisks setRiskClause(String riskClause) {
            this.riskClause = riskClause;
            return this;
        }
        public String getRiskClause() {
            return this.riskClause;
        }

        public QueryContractReviewResultResponseBodyResultDataReviewRiskDetailSubRisks setRiskExplain(String riskExplain) {
            this.riskExplain = riskExplain;
            return this;
        }
        public String getRiskExplain() {
            return this.riskExplain;
        }

    }

    public static class QueryContractReviewResultResponseBodyResultDataReviewRiskDetail extends TeaModel {
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
        public java.util.List<QueryContractReviewResultResponseBodyResultDataReviewRiskDetailSubRisks> subRisks;

        public static QueryContractReviewResultResponseBodyResultDataReviewRiskDetail build(java.util.Map<String, ?> map) throws Exception {
            QueryContractReviewResultResponseBodyResultDataReviewRiskDetail self = new QueryContractReviewResultResponseBodyResultDataReviewRiskDetail();
            return TeaModel.build(map, self);
        }

        public QueryContractReviewResultResponseBodyResultDataReviewRiskDetail setExamineBrief(String examineBrief) {
            this.examineBrief = examineBrief;
            return this;
        }
        public String getExamineBrief() {
            return this.examineBrief;
        }

        public QueryContractReviewResultResponseBodyResultDataReviewRiskDetail setExamineResult(String examineResult) {
            this.examineResult = examineResult;
            return this;
        }
        public String getExamineResult() {
            return this.examineResult;
        }

        public QueryContractReviewResultResponseBodyResultDataReviewRiskDetail setExamineStatus(String examineStatus) {
            this.examineStatus = examineStatus;
            return this;
        }
        public String getExamineStatus() {
            return this.examineStatus;
        }

        public QueryContractReviewResultResponseBodyResultDataReviewRiskDetail setRiskLevel(String riskLevel) {
            this.riskLevel = riskLevel;
            return this;
        }
        public String getRiskLevel() {
            return this.riskLevel;
        }

        public QueryContractReviewResultResponseBodyResultDataReviewRiskDetail setRuleSequence(String ruleSequence) {
            this.ruleSequence = ruleSequence;
            return this;
        }
        public String getRuleSequence() {
            return this.ruleSequence;
        }

        public QueryContractReviewResultResponseBodyResultDataReviewRiskDetail setRuleTag(String ruleTag) {
            this.ruleTag = ruleTag;
            return this;
        }
        public String getRuleTag() {
            return this.ruleTag;
        }

        public QueryContractReviewResultResponseBodyResultDataReviewRiskDetail setRuleTitle(String ruleTitle) {
            this.ruleTitle = ruleTitle;
            return this;
        }
        public String getRuleTitle() {
            return this.ruleTitle;
        }

        public QueryContractReviewResultResponseBodyResultDataReviewRiskDetail setSubRisks(java.util.List<QueryContractReviewResultResponseBodyResultDataReviewRiskDetailSubRisks> subRisks) {
            this.subRisks = subRisks;
            return this;
        }
        public java.util.List<QueryContractReviewResultResponseBodyResultDataReviewRiskDetailSubRisks> getSubRisks() {
            return this.subRisks;
        }

    }

    public static class QueryContractReviewResultResponseBodyResultDataReviewRiskOverview extends TeaModel {
        @NameInMap("hasRisk")
        public Boolean hasRisk;

        @NameInMap("highRisk")
        public Integer highRisk;

        @NameInMap("lowRisk")
        public Integer lowRisk;

        @NameInMap("mediumRisk")
        public Integer mediumRisk;

        public static QueryContractReviewResultResponseBodyResultDataReviewRiskOverview build(java.util.Map<String, ?> map) throws Exception {
            QueryContractReviewResultResponseBodyResultDataReviewRiskOverview self = new QueryContractReviewResultResponseBodyResultDataReviewRiskOverview();
            return TeaModel.build(map, self);
        }

        public QueryContractReviewResultResponseBodyResultDataReviewRiskOverview setHasRisk(Boolean hasRisk) {
            this.hasRisk = hasRisk;
            return this;
        }
        public Boolean getHasRisk() {
            return this.hasRisk;
        }

        public QueryContractReviewResultResponseBodyResultDataReviewRiskOverview setHighRisk(Integer highRisk) {
            this.highRisk = highRisk;
            return this;
        }
        public Integer getHighRisk() {
            return this.highRisk;
        }

        public QueryContractReviewResultResponseBodyResultDataReviewRiskOverview setLowRisk(Integer lowRisk) {
            this.lowRisk = lowRisk;
            return this;
        }
        public Integer getLowRisk() {
            return this.lowRisk;
        }

        public QueryContractReviewResultResponseBodyResultDataReviewRiskOverview setMediumRisk(Integer mediumRisk) {
            this.mediumRisk = mediumRisk;
            return this;
        }
        public Integer getMediumRisk() {
            return this.mediumRisk;
        }

    }

    public static class QueryContractReviewResultResponseBodyResultDataReviewStatus extends TeaModel {
        @NameInMap("overview")
        public String overview;

        @NameInMap("result")
        public String result;

        @NameInMap("rule")
        public String rule;

        @NameInMap("stage")
        public String stage;

        public static QueryContractReviewResultResponseBodyResultDataReviewStatus build(java.util.Map<String, ?> map) throws Exception {
            QueryContractReviewResultResponseBodyResultDataReviewStatus self = new QueryContractReviewResultResponseBodyResultDataReviewStatus();
            return TeaModel.build(map, self);
        }

        public QueryContractReviewResultResponseBodyResultDataReviewStatus setOverview(String overview) {
            this.overview = overview;
            return this;
        }
        public String getOverview() {
            return this.overview;
        }

        public QueryContractReviewResultResponseBodyResultDataReviewStatus setResult(String result) {
            this.result = result;
            return this;
        }
        public String getResult() {
            return this.result;
        }

        public QueryContractReviewResultResponseBodyResultDataReviewStatus setRule(String rule) {
            this.rule = rule;
            return this;
        }
        public String getRule() {
            return this.rule;
        }

        public QueryContractReviewResultResponseBodyResultDataReviewStatus setStage(String stage) {
            this.stage = stage;
            return this;
        }
        public String getStage() {
            return this.stage;
        }

    }

    public static class QueryContractReviewResultResponseBodyResultData extends TeaModel {
        @NameInMap("reviewRiskDetail")
        public java.util.List<QueryContractReviewResultResponseBodyResultDataReviewRiskDetail> reviewRiskDetail;

        @NameInMap("reviewRiskOverview")
        public QueryContractReviewResultResponseBodyResultDataReviewRiskOverview reviewRiskOverview;

        @NameInMap("reviewStatus")
        public QueryContractReviewResultResponseBodyResultDataReviewStatus reviewStatus;

        public static QueryContractReviewResultResponseBodyResultData build(java.util.Map<String, ?> map) throws Exception {
            QueryContractReviewResultResponseBodyResultData self = new QueryContractReviewResultResponseBodyResultData();
            return TeaModel.build(map, self);
        }

        public QueryContractReviewResultResponseBodyResultData setReviewRiskDetail(java.util.List<QueryContractReviewResultResponseBodyResultDataReviewRiskDetail> reviewRiskDetail) {
            this.reviewRiskDetail = reviewRiskDetail;
            return this;
        }
        public java.util.List<QueryContractReviewResultResponseBodyResultDataReviewRiskDetail> getReviewRiskDetail() {
            return this.reviewRiskDetail;
        }

        public QueryContractReviewResultResponseBodyResultData setReviewRiskOverview(QueryContractReviewResultResponseBodyResultDataReviewRiskOverview reviewRiskOverview) {
            this.reviewRiskOverview = reviewRiskOverview;
            return this;
        }
        public QueryContractReviewResultResponseBodyResultDataReviewRiskOverview getReviewRiskOverview() {
            return this.reviewRiskOverview;
        }

        public QueryContractReviewResultResponseBodyResultData setReviewStatus(QueryContractReviewResultResponseBodyResultDataReviewStatus reviewStatus) {
            this.reviewStatus = reviewStatus;
            return this;
        }
        public QueryContractReviewResultResponseBodyResultDataReviewStatus getReviewStatus() {
            return this.reviewStatus;
        }

    }

    public static class QueryContractReviewResultResponseBodyResult extends TeaModel {
        @NameInMap("data")
        public QueryContractReviewResultResponseBodyResultData data;

        @NameInMap("requestId")
        public String requestId;

        public static QueryContractReviewResultResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryContractReviewResultResponseBodyResult self = new QueryContractReviewResultResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryContractReviewResultResponseBodyResult setData(QueryContractReviewResultResponseBodyResultData data) {
            this.data = data;
            return this;
        }
        public QueryContractReviewResultResponseBodyResultData getData() {
            return this.data;
        }

        public QueryContractReviewResultResponseBodyResult setRequestId(String requestId) {
            this.requestId = requestId;
            return this;
        }
        public String getRequestId() {
            return this.requestId;
        }

    }

}
