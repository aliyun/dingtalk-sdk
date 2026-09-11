// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class GetContractReviewResultsResponseBody extends TeaModel {
    @NameInMap("data")
    public GetContractReviewResultsResponseBodyData data;

    public static GetContractReviewResultsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetContractReviewResultsResponseBody self = new GetContractReviewResultsResponseBody();
        return TeaModel.build(map, self);
    }

    public GetContractReviewResultsResponseBody setData(GetContractReviewResultsResponseBodyData data) {
        this.data = data;
        return this;
    }
    public GetContractReviewResultsResponseBodyData getData() {
        return this.data;
    }

    public static class GetContractReviewResultsResponseBodyDataReportAllIssues extends TeaModel {
        @NameInMap("builtin")
        public Boolean builtin;

        @NameInMap("check_type")
        public String checkType;

        @NameInMap("clause_location")
        public String clauseLocation;

        @NameInMap("clause_quote")
        public String clauseQuote;

        @NameInMap("custom")
        public Boolean custom;

        @NameInMap("fallback")
        public String fallback;

        @NameInMap("id")
        public String id;

        @NameInMap("impact")
        public String impact;

        @NameInMap("legal_basis")
        public String legalBasis;

        @NameInMap("pack")
        public String pack;

        @NameInMap("practice_reference")
        public String practiceReference;

        @NameInMap("problem")
        public String problem;

        @NameInMap("revision_text")
        public String revisionText;

        @NameInMap("riskLevel")
        public String riskLevel;

        @NameInMap("rule_name")
        public String ruleName;

        @NameInMap("source")
        public String source;

        @NameInMap("suggestion")
        public String suggestion;

        @NameInMap("tier")
        public String tier;

        public static GetContractReviewResultsResponseBodyDataReportAllIssues build(java.util.Map<String, ?> map) throws Exception {
            GetContractReviewResultsResponseBodyDataReportAllIssues self = new GetContractReviewResultsResponseBodyDataReportAllIssues();
            return TeaModel.build(map, self);
        }

        public GetContractReviewResultsResponseBodyDataReportAllIssues setBuiltin(Boolean builtin) {
            this.builtin = builtin;
            return this;
        }
        public Boolean getBuiltin() {
            return this.builtin;
        }

        public GetContractReviewResultsResponseBodyDataReportAllIssues setCheckType(String checkType) {
            this.checkType = checkType;
            return this;
        }
        public String getCheckType() {
            return this.checkType;
        }

        public GetContractReviewResultsResponseBodyDataReportAllIssues setClauseLocation(String clauseLocation) {
            this.clauseLocation = clauseLocation;
            return this;
        }
        public String getClauseLocation() {
            return this.clauseLocation;
        }

        public GetContractReviewResultsResponseBodyDataReportAllIssues setClauseQuote(String clauseQuote) {
            this.clauseQuote = clauseQuote;
            return this;
        }
        public String getClauseQuote() {
            return this.clauseQuote;
        }

        public GetContractReviewResultsResponseBodyDataReportAllIssues setCustom(Boolean custom) {
            this.custom = custom;
            return this;
        }
        public Boolean getCustom() {
            return this.custom;
        }

        public GetContractReviewResultsResponseBodyDataReportAllIssues setFallback(String fallback) {
            this.fallback = fallback;
            return this;
        }
        public String getFallback() {
            return this.fallback;
        }

        public GetContractReviewResultsResponseBodyDataReportAllIssues setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetContractReviewResultsResponseBodyDataReportAllIssues setImpact(String impact) {
            this.impact = impact;
            return this;
        }
        public String getImpact() {
            return this.impact;
        }

        public GetContractReviewResultsResponseBodyDataReportAllIssues setLegalBasis(String legalBasis) {
            this.legalBasis = legalBasis;
            return this;
        }
        public String getLegalBasis() {
            return this.legalBasis;
        }

        public GetContractReviewResultsResponseBodyDataReportAllIssues setPack(String pack) {
            this.pack = pack;
            return this;
        }
        public String getPack() {
            return this.pack;
        }

        public GetContractReviewResultsResponseBodyDataReportAllIssues setPracticeReference(String practiceReference) {
            this.practiceReference = practiceReference;
            return this;
        }
        public String getPracticeReference() {
            return this.practiceReference;
        }

        public GetContractReviewResultsResponseBodyDataReportAllIssues setProblem(String problem) {
            this.problem = problem;
            return this;
        }
        public String getProblem() {
            return this.problem;
        }

        public GetContractReviewResultsResponseBodyDataReportAllIssues setRevisionText(String revisionText) {
            this.revisionText = revisionText;
            return this;
        }
        public String getRevisionText() {
            return this.revisionText;
        }

        public GetContractReviewResultsResponseBodyDataReportAllIssues setRiskLevel(String riskLevel) {
            this.riskLevel = riskLevel;
            return this;
        }
        public String getRiskLevel() {
            return this.riskLevel;
        }

        public GetContractReviewResultsResponseBodyDataReportAllIssues setRuleName(String ruleName) {
            this.ruleName = ruleName;
            return this;
        }
        public String getRuleName() {
            return this.ruleName;
        }

        public GetContractReviewResultsResponseBodyDataReportAllIssues setSource(String source) {
            this.source = source;
            return this;
        }
        public String getSource() {
            return this.source;
        }

        public GetContractReviewResultsResponseBodyDataReportAllIssues setSuggestion(String suggestion) {
            this.suggestion = suggestion;
            return this;
        }
        public String getSuggestion() {
            return this.suggestion;
        }

        public GetContractReviewResultsResponseBodyDataReportAllIssues setTier(String tier) {
            this.tier = tier;
            return this;
        }
        public String getTier() {
            return this.tier;
        }

    }

    public static class GetContractReviewResultsResponseBodyDataReportSummary extends TeaModel {
        @NameInMap("contract_type")
        public String contractType;

        @NameInMap("cross_clause_count")
        public Long crossClauseCount;

        @NameInMap("deterministic_count")
        public Long deterministicCount;

        @NameInMap("formal_hint_count")
        public Long formalHintCount;

        @NameInMap("hard_issue_count")
        public Long hardIssueCount;

        @NameInMap("high")
        public Long high;

        @NameInMap("issue_count")
        public Long issueCount;

        @NameInMap("low")
        public Long low;

        @NameInMap("medium")
        public Long medium;

        @NameInMap("missing_clause_count")
        public Long missingClauseCount;

        @NameInMap("overall_risk_level")
        public String overallRiskLevel;

        @NameInMap("risk_issue_count")
        public Long riskIssueCount;

        @NameInMap("scale")
        public String scale;

        @NameInMap("standpoint")
        public String standpoint;

        public static GetContractReviewResultsResponseBodyDataReportSummary build(java.util.Map<String, ?> map) throws Exception {
            GetContractReviewResultsResponseBodyDataReportSummary self = new GetContractReviewResultsResponseBodyDataReportSummary();
            return TeaModel.build(map, self);
        }

        public GetContractReviewResultsResponseBodyDataReportSummary setContractType(String contractType) {
            this.contractType = contractType;
            return this;
        }
        public String getContractType() {
            return this.contractType;
        }

        public GetContractReviewResultsResponseBodyDataReportSummary setCrossClauseCount(Long crossClauseCount) {
            this.crossClauseCount = crossClauseCount;
            return this;
        }
        public Long getCrossClauseCount() {
            return this.crossClauseCount;
        }

        public GetContractReviewResultsResponseBodyDataReportSummary setDeterministicCount(Long deterministicCount) {
            this.deterministicCount = deterministicCount;
            return this;
        }
        public Long getDeterministicCount() {
            return this.deterministicCount;
        }

        public GetContractReviewResultsResponseBodyDataReportSummary setFormalHintCount(Long formalHintCount) {
            this.formalHintCount = formalHintCount;
            return this;
        }
        public Long getFormalHintCount() {
            return this.formalHintCount;
        }

        public GetContractReviewResultsResponseBodyDataReportSummary setHardIssueCount(Long hardIssueCount) {
            this.hardIssueCount = hardIssueCount;
            return this;
        }
        public Long getHardIssueCount() {
            return this.hardIssueCount;
        }

        public GetContractReviewResultsResponseBodyDataReportSummary setHigh(Long high) {
            this.high = high;
            return this;
        }
        public Long getHigh() {
            return this.high;
        }

        public GetContractReviewResultsResponseBodyDataReportSummary setIssueCount(Long issueCount) {
            this.issueCount = issueCount;
            return this;
        }
        public Long getIssueCount() {
            return this.issueCount;
        }

        public GetContractReviewResultsResponseBodyDataReportSummary setLow(Long low) {
            this.low = low;
            return this;
        }
        public Long getLow() {
            return this.low;
        }

        public GetContractReviewResultsResponseBodyDataReportSummary setMedium(Long medium) {
            this.medium = medium;
            return this;
        }
        public Long getMedium() {
            return this.medium;
        }

        public GetContractReviewResultsResponseBodyDataReportSummary setMissingClauseCount(Long missingClauseCount) {
            this.missingClauseCount = missingClauseCount;
            return this;
        }
        public Long getMissingClauseCount() {
            return this.missingClauseCount;
        }

        public GetContractReviewResultsResponseBodyDataReportSummary setOverallRiskLevel(String overallRiskLevel) {
            this.overallRiskLevel = overallRiskLevel;
            return this;
        }
        public String getOverallRiskLevel() {
            return this.overallRiskLevel;
        }

        public GetContractReviewResultsResponseBodyDataReportSummary setRiskIssueCount(Long riskIssueCount) {
            this.riskIssueCount = riskIssueCount;
            return this;
        }
        public Long getRiskIssueCount() {
            return this.riskIssueCount;
        }

        public GetContractReviewResultsResponseBodyDataReportSummary setScale(String scale) {
            this.scale = scale;
            return this;
        }
        public String getScale() {
            return this.scale;
        }

        public GetContractReviewResultsResponseBodyDataReportSummary setStandpoint(String standpoint) {
            this.standpoint = standpoint;
            return this;
        }
        public String getStandpoint() {
            return this.standpoint;
        }

    }

    public static class GetContractReviewResultsResponseBodyDataReport extends TeaModel {
        @NameInMap("all_issues")
        public java.util.List<GetContractReviewResultsResponseBodyDataReportAllIssues> allIssues;

        @NameInMap("conclusion")
        public String conclusion;

        @NameInMap("cross_clause_findings")
        public java.util.List<String> crossClauseFindings;

        @NameInMap("deterministic_findings")
        public java.util.List<String> deterministicFindings;

        @NameInMap("file_name")
        public String fileName;

        @NameInMap("generated_at")
        public String generatedAt;

        @NameInMap("missing_clauses")
        public java.util.List<String> missingClauses;

        @NameInMap("review_id")
        public String reviewId;

        @NameInMap("risk_issues")
        public java.util.List<String> riskIssues;

        @NameInMap("summary")
        public GetContractReviewResultsResponseBodyDataReportSummary summary;

        @NameInMap("version")
        public String version;

        public static GetContractReviewResultsResponseBodyDataReport build(java.util.Map<String, ?> map) throws Exception {
            GetContractReviewResultsResponseBodyDataReport self = new GetContractReviewResultsResponseBodyDataReport();
            return TeaModel.build(map, self);
        }

        public GetContractReviewResultsResponseBodyDataReport setAllIssues(java.util.List<GetContractReviewResultsResponseBodyDataReportAllIssues> allIssues) {
            this.allIssues = allIssues;
            return this;
        }
        public java.util.List<GetContractReviewResultsResponseBodyDataReportAllIssues> getAllIssues() {
            return this.allIssues;
        }

        public GetContractReviewResultsResponseBodyDataReport setConclusion(String conclusion) {
            this.conclusion = conclusion;
            return this;
        }
        public String getConclusion() {
            return this.conclusion;
        }

        public GetContractReviewResultsResponseBodyDataReport setCrossClauseFindings(java.util.List<String> crossClauseFindings) {
            this.crossClauseFindings = crossClauseFindings;
            return this;
        }
        public java.util.List<String> getCrossClauseFindings() {
            return this.crossClauseFindings;
        }

        public GetContractReviewResultsResponseBodyDataReport setDeterministicFindings(java.util.List<String> deterministicFindings) {
            this.deterministicFindings = deterministicFindings;
            return this;
        }
        public java.util.List<String> getDeterministicFindings() {
            return this.deterministicFindings;
        }

        public GetContractReviewResultsResponseBodyDataReport setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public GetContractReviewResultsResponseBodyDataReport setGeneratedAt(String generatedAt) {
            this.generatedAt = generatedAt;
            return this;
        }
        public String getGeneratedAt() {
            return this.generatedAt;
        }

        public GetContractReviewResultsResponseBodyDataReport setMissingClauses(java.util.List<String> missingClauses) {
            this.missingClauses = missingClauses;
            return this;
        }
        public java.util.List<String> getMissingClauses() {
            return this.missingClauses;
        }

        public GetContractReviewResultsResponseBodyDataReport setReviewId(String reviewId) {
            this.reviewId = reviewId;
            return this;
        }
        public String getReviewId() {
            return this.reviewId;
        }

        public GetContractReviewResultsResponseBodyDataReport setRiskIssues(java.util.List<String> riskIssues) {
            this.riskIssues = riskIssues;
            return this;
        }
        public java.util.List<String> getRiskIssues() {
            return this.riskIssues;
        }

        public GetContractReviewResultsResponseBodyDataReport setSummary(GetContractReviewResultsResponseBodyDataReportSummary summary) {
            this.summary = summary;
            return this;
        }
        public GetContractReviewResultsResponseBodyDataReportSummary getSummary() {
            return this.summary;
        }

        public GetContractReviewResultsResponseBodyDataReport setVersion(String version) {
            this.version = version;
            return this;
        }
        public String getVersion() {
            return this.version;
        }

    }

    public static class GetContractReviewResultsResponseBodyDataRiskCounts extends TeaModel {
        @NameInMap("high")
        public Long high;

        @NameInMap("low")
        public Long low;

        @NameInMap("medium")
        public Long medium;

        public static GetContractReviewResultsResponseBodyDataRiskCounts build(java.util.Map<String, ?> map) throws Exception {
            GetContractReviewResultsResponseBodyDataRiskCounts self = new GetContractReviewResultsResponseBodyDataRiskCounts();
            return TeaModel.build(map, self);
        }

        public GetContractReviewResultsResponseBodyDataRiskCounts setHigh(Long high) {
            this.high = high;
            return this;
        }
        public Long getHigh() {
            return this.high;
        }

        public GetContractReviewResultsResponseBodyDataRiskCounts setLow(Long low) {
            this.low = low;
            return this;
        }
        public Long getLow() {
            return this.low;
        }

        public GetContractReviewResultsResponseBodyDataRiskCounts setMedium(Long medium) {
            this.medium = medium;
            return this;
        }
        public Long getMedium() {
            return this.medium;
        }

    }

    public static class GetContractReviewResultsResponseBodyData extends TeaModel {
        @NameInMap("annotated_export_url")
        public String annotatedExportUrl;

        @NameInMap("message")
        public String message;

        @NameInMap("report")
        public GetContractReviewResultsResponseBodyDataReport report;

        @NameInMap("report_export_url")
        public String reportExportUrl;

        @NameInMap("review_id")
        public String reviewId;

        @NameInMap("risk_counts")
        public GetContractReviewResultsResponseBodyDataRiskCounts riskCounts;

        @NameInMap("status")
        public String status;

        @NameInMap("total_risks")
        public Long totalRisks;

        @NameInMap("weboffice_url")
        public String webofficeUrl;

        public static GetContractReviewResultsResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetContractReviewResultsResponseBodyData self = new GetContractReviewResultsResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetContractReviewResultsResponseBodyData setAnnotatedExportUrl(String annotatedExportUrl) {
            this.annotatedExportUrl = annotatedExportUrl;
            return this;
        }
        public String getAnnotatedExportUrl() {
            return this.annotatedExportUrl;
        }

        public GetContractReviewResultsResponseBodyData setMessage(String message) {
            this.message = message;
            return this;
        }
        public String getMessage() {
            return this.message;
        }

        public GetContractReviewResultsResponseBodyData setReport(GetContractReviewResultsResponseBodyDataReport report) {
            this.report = report;
            return this;
        }
        public GetContractReviewResultsResponseBodyDataReport getReport() {
            return this.report;
        }

        public GetContractReviewResultsResponseBodyData setReportExportUrl(String reportExportUrl) {
            this.reportExportUrl = reportExportUrl;
            return this;
        }
        public String getReportExportUrl() {
            return this.reportExportUrl;
        }

        public GetContractReviewResultsResponseBodyData setReviewId(String reviewId) {
            this.reviewId = reviewId;
            return this;
        }
        public String getReviewId() {
            return this.reviewId;
        }

        public GetContractReviewResultsResponseBodyData setRiskCounts(GetContractReviewResultsResponseBodyDataRiskCounts riskCounts) {
            this.riskCounts = riskCounts;
            return this;
        }
        public GetContractReviewResultsResponseBodyDataRiskCounts getRiskCounts() {
            return this.riskCounts;
        }

        public GetContractReviewResultsResponseBodyData setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public GetContractReviewResultsResponseBodyData setTotalRisks(Long totalRisks) {
            this.totalRisks = totalRisks;
            return this;
        }
        public Long getTotalRisks() {
            return this.totalRisks;
        }

        public GetContractReviewResultsResponseBodyData setWebofficeUrl(String webofficeUrl) {
            this.webofficeUrl = webofficeUrl;
            return this;
        }
        public String getWebofficeUrl() {
            return this.webofficeUrl;
        }

    }

}
