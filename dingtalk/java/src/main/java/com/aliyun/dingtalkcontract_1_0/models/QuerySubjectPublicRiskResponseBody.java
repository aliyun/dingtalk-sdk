// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QuerySubjectPublicRiskResponseBody extends TeaModel {
    @NameInMap("result")
    public QuerySubjectPublicRiskResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QuerySubjectPublicRiskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QuerySubjectPublicRiskResponseBody self = new QuerySubjectPublicRiskResponseBody();
        return TeaModel.build(map, self);
    }

    public QuerySubjectPublicRiskResponseBody setResult(QuerySubjectPublicRiskResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QuerySubjectPublicRiskResponseBodyResult getResult() {
        return this.result;
    }

    public QuerySubjectPublicRiskResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QuerySubjectPublicRiskResponseBodyResultCompanyInfo extends TeaModel {
        @NameInMap("bankAccountName")
        public String bankAccountName;

        @NameInMap("bankAccountNumber")
        public String bankAccountNumber;

        @NameInMap("bankName")
        public String bankName;

        @NameInMap("companyName")
        public String companyName;

        @NameInMap("creditCode")
        public String creditCode;

        @NameInMap("legalPersonName")
        public String legalPersonName;

        @NameInMap("phoneNumber")
        public String phoneNumber;

        @NameInMap("regLocation")
        public String regLocation;

        @NameInMap("remark")
        public String remark;

        @NameInMap("taxNumber")
        public String taxNumber;

        public static QuerySubjectPublicRiskResponseBodyResultCompanyInfo build(java.util.Map<String, ?> map) throws Exception {
            QuerySubjectPublicRiskResponseBodyResultCompanyInfo self = new QuerySubjectPublicRiskResponseBodyResultCompanyInfo();
            return TeaModel.build(map, self);
        }

        public QuerySubjectPublicRiskResponseBodyResultCompanyInfo setBankAccountName(String bankAccountName) {
            this.bankAccountName = bankAccountName;
            return this;
        }
        public String getBankAccountName() {
            return this.bankAccountName;
        }

        public QuerySubjectPublicRiskResponseBodyResultCompanyInfo setBankAccountNumber(String bankAccountNumber) {
            this.bankAccountNumber = bankAccountNumber;
            return this;
        }
        public String getBankAccountNumber() {
            return this.bankAccountNumber;
        }

        public QuerySubjectPublicRiskResponseBodyResultCompanyInfo setBankName(String bankName) {
            this.bankName = bankName;
            return this;
        }
        public String getBankName() {
            return this.bankName;
        }

        public QuerySubjectPublicRiskResponseBodyResultCompanyInfo setCompanyName(String companyName) {
            this.companyName = companyName;
            return this;
        }
        public String getCompanyName() {
            return this.companyName;
        }

        public QuerySubjectPublicRiskResponseBodyResultCompanyInfo setCreditCode(String creditCode) {
            this.creditCode = creditCode;
            return this;
        }
        public String getCreditCode() {
            return this.creditCode;
        }

        public QuerySubjectPublicRiskResponseBodyResultCompanyInfo setLegalPersonName(String legalPersonName) {
            this.legalPersonName = legalPersonName;
            return this;
        }
        public String getLegalPersonName() {
            return this.legalPersonName;
        }

        public QuerySubjectPublicRiskResponseBodyResultCompanyInfo setPhoneNumber(String phoneNumber) {
            this.phoneNumber = phoneNumber;
            return this;
        }
        public String getPhoneNumber() {
            return this.phoneNumber;
        }

        public QuerySubjectPublicRiskResponseBodyResultCompanyInfo setRegLocation(String regLocation) {
            this.regLocation = regLocation;
            return this;
        }
        public String getRegLocation() {
            return this.regLocation;
        }

        public QuerySubjectPublicRiskResponseBodyResultCompanyInfo setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public QuerySubjectPublicRiskResponseBodyResultCompanyInfo setTaxNumber(String taxNumber) {
            this.taxNumber = taxNumber;
            return this;
        }
        public String getTaxNumber() {
            return this.taxNumber;
        }

    }

    public static class QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishmentColumns extends TeaModel {
        @NameInMap("columnName")
        public String columnName;

        @NameInMap("columnType")
        public String columnType;

        @NameInMap("isDate")
        public Boolean isDate;

        public static QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishmentColumns build(java.util.Map<String, ?> map) throws Exception {
            QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishmentColumns self = new QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishmentColumns();
            return TeaModel.build(map, self);
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishmentColumns setColumnName(String columnName) {
            this.columnName = columnName;
            return this;
        }
        public String getColumnName() {
            return this.columnName;
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishmentColumns setColumnType(String columnType) {
            this.columnType = columnType;
            return this;
        }
        public String getColumnType() {
            return this.columnType;
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishmentColumns setIsDate(Boolean isDate) {
            this.isDate = isDate;
            return this;
        }
        public Boolean getIsDate() {
            return this.isDate;
        }

    }

    public static class QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishmentItems extends TeaModel {
        @NameInMap("content")
        public String content;

        @NameInMap("decisionDate")
        public String decisionDate;

        @NameInMap("departmentName")
        public String departmentName;

        @NameInMap("punishNumber")
        public String punishNumber;

        @NameInMap("reason")
        public String reason;

        public static QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishmentItems build(java.util.Map<String, ?> map) throws Exception {
            QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishmentItems self = new QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishmentItems();
            return TeaModel.build(map, self);
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishmentItems setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishmentItems setDecisionDate(String decisionDate) {
            this.decisionDate = decisionDate;
            return this;
        }
        public String getDecisionDate() {
            return this.decisionDate;
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishmentItems setDepartmentName(String departmentName) {
            this.departmentName = departmentName;
            return this;
        }
        public String getDepartmentName() {
            return this.departmentName;
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishmentItems setPunishNumber(String punishNumber) {
            this.punishNumber = punishNumber;
            return this;
        }
        public String getPunishNumber() {
            return this.punishNumber;
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishmentItems setReason(String reason) {
            this.reason = reason;
            return this;
        }
        public String getReason() {
            return this.reason;
        }

    }

    public static class QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishment extends TeaModel {
        @NameInMap("columns")
        public java.util.List<QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishmentColumns> columns;

        @NameInMap("items")
        public java.util.List<QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishmentItems> items;

        @NameInMap("noticeText")
        public String noticeText;

        @NameInMap("subRiskName")
        public String subRiskName;

        @NameInMap("subRiskNumber")
        public Long subRiskNumber;

        @NameInMap("subRiskType")
        public String subRiskType;

        public static QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishment build(java.util.Map<String, ?> map) throws Exception {
            QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishment self = new QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishment();
            return TeaModel.build(map, self);
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishment setColumns(java.util.List<QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishmentColumns> columns) {
            this.columns = columns;
            return this;
        }
        public java.util.List<QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishmentColumns> getColumns() {
            return this.columns;
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishment setItems(java.util.List<QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishmentItems> items) {
            this.items = items;
            return this;
        }
        public java.util.List<QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishmentItems> getItems() {
            return this.items;
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishment setNoticeText(String noticeText) {
            this.noticeText = noticeText;
            return this;
        }
        public String getNoticeText() {
            return this.noticeText;
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishment setSubRiskName(String subRiskName) {
            this.subRiskName = subRiskName;
            return this;
        }
        public String getSubRiskName() {
            return this.subRiskName;
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishment setSubRiskNumber(Long subRiskNumber) {
            this.subRiskNumber = subRiskNumber;
            return this;
        }
        public Long getSubRiskNumber() {
            return this.subRiskNumber;
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishment setSubRiskType(String subRiskType) {
            this.subRiskType = subRiskType;
            return this;
        }
        public String getSubRiskType() {
            return this.subRiskType;
        }

    }

    public static class QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisks extends TeaModel {
        @NameInMap("administrative_punishment")
        public QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishment administrativePunishment;

        public static QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisks build(java.util.Map<String, ?> map) throws Exception {
            QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisks self = new QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisks();
            return TeaModel.build(map, self);
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisks setAdministrativePunishment(QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishment administrativePunishment) {
            this.administrativePunishment = administrativePunishment;
            return this;
        }
        public QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisksAdministrativePunishment getAdministrativePunishment() {
            return this.administrativePunishment;
        }

    }

    public static class QuerySubjectPublicRiskResponseBodyResultRisksBusinessRisk extends TeaModel {
        @NameInMap("riskName")
        public String riskName;

        @NameInMap("riskNumber")
        public Long riskNumber;

        @NameInMap("riskType")
        public String riskType;

        @NameInMap("subRiskTypes")
        public java.util.List<String> subRiskTypes;

        @NameInMap("subRisks")
        public QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisks subRisks;

        public static QuerySubjectPublicRiskResponseBodyResultRisksBusinessRisk build(java.util.Map<String, ?> map) throws Exception {
            QuerySubjectPublicRiskResponseBodyResultRisksBusinessRisk self = new QuerySubjectPublicRiskResponseBodyResultRisksBusinessRisk();
            return TeaModel.build(map, self);
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksBusinessRisk setRiskName(String riskName) {
            this.riskName = riskName;
            return this;
        }
        public String getRiskName() {
            return this.riskName;
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksBusinessRisk setRiskNumber(Long riskNumber) {
            this.riskNumber = riskNumber;
            return this;
        }
        public Long getRiskNumber() {
            return this.riskNumber;
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksBusinessRisk setRiskType(String riskType) {
            this.riskType = riskType;
            return this;
        }
        public String getRiskType() {
            return this.riskType;
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksBusinessRisk setSubRiskTypes(java.util.List<String> subRiskTypes) {
            this.subRiskTypes = subRiskTypes;
            return this;
        }
        public java.util.List<String> getSubRiskTypes() {
            return this.subRiskTypes;
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksBusinessRisk setSubRisks(QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisks subRisks) {
            this.subRisks = subRisks;
            return this;
        }
        public QuerySubjectPublicRiskResponseBodyResultRisksBusinessRiskSubRisks getSubRisks() {
            return this.subRisks;
        }

    }

    public static class QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncementColumns extends TeaModel {
        @NameInMap("columnName")
        public String columnName;

        @NameInMap("columnType")
        public String columnType;

        @NameInMap("isDate")
        public Boolean isDate;

        public static QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncementColumns build(java.util.Map<String, ?> map) throws Exception {
            QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncementColumns self = new QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncementColumns();
            return TeaModel.build(map, self);
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncementColumns setColumnName(String columnName) {
            this.columnName = columnName;
            return this;
        }
        public String getColumnName() {
            return this.columnName;
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncementColumns setColumnType(String columnType) {
            this.columnType = columnType;
            return this;
        }
        public String getColumnType() {
            return this.columnType;
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncementColumns setIsDate(Boolean isDate) {
            this.isDate = isDate;
            return this;
        }
        public Boolean getIsDate() {
            return this.isDate;
        }

    }

    public static class QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncementItems extends TeaModel {
        @NameInMap("caseNo")
        public String caseNo;

        @NameInMap("caseReason")
        public String caseReason;

        @NameInMap("court")
        public String court;

        @NameInMap("startDate")
        public String startDate;

        public static QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncementItems build(java.util.Map<String, ?> map) throws Exception {
            QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncementItems self = new QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncementItems();
            return TeaModel.build(map, self);
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncementItems setCaseNo(String caseNo) {
            this.caseNo = caseNo;
            return this;
        }
        public String getCaseNo() {
            return this.caseNo;
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncementItems setCaseReason(String caseReason) {
            this.caseReason = caseReason;
            return this;
        }
        public String getCaseReason() {
            return this.caseReason;
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncementItems setCourt(String court) {
            this.court = court;
            return this;
        }
        public String getCourt() {
            return this.court;
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncementItems setStartDate(String startDate) {
            this.startDate = startDate;
            return this;
        }
        public String getStartDate() {
            return this.startDate;
        }

    }

    public static class QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncement extends TeaModel {
        @NameInMap("columns")
        public java.util.List<QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncementColumns> columns;

        @NameInMap("items")
        public java.util.List<QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncementItems> items;

        @NameInMap("noticeText")
        public String noticeText;

        @NameInMap("subRiskName")
        public String subRiskName;

        @NameInMap("subRiskNumber")
        public Long subRiskNumber;

        @NameInMap("subRiskType")
        public String subRiskType;

        public static QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncement build(java.util.Map<String, ?> map) throws Exception {
            QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncement self = new QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncement();
            return TeaModel.build(map, self);
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncement setColumns(java.util.List<QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncementColumns> columns) {
            this.columns = columns;
            return this;
        }
        public java.util.List<QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncementColumns> getColumns() {
            return this.columns;
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncement setItems(java.util.List<QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncementItems> items) {
            this.items = items;
            return this;
        }
        public java.util.List<QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncementItems> getItems() {
            return this.items;
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncement setNoticeText(String noticeText) {
            this.noticeText = noticeText;
            return this;
        }
        public String getNoticeText() {
            return this.noticeText;
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncement setSubRiskName(String subRiskName) {
            this.subRiskName = subRiskName;
            return this;
        }
        public String getSubRiskName() {
            return this.subRiskName;
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncement setSubRiskNumber(Long subRiskNumber) {
            this.subRiskNumber = subRiskNumber;
            return this;
        }
        public Long getSubRiskNumber() {
            return this.subRiskNumber;
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncement setSubRiskType(String subRiskType) {
            this.subRiskType = subRiskType;
            return this;
        }
        public String getSubRiskType() {
            return this.subRiskType;
        }

    }

    public static class QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisks extends TeaModel {
        @NameInMap("court_opening_announcement")
        public QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncement courtOpeningAnnouncement;

        public static QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisks build(java.util.Map<String, ?> map) throws Exception {
            QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisks self = new QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisks();
            return TeaModel.build(map, self);
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisks setCourtOpeningAnnouncement(QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncement courtOpeningAnnouncement) {
            this.courtOpeningAnnouncement = courtOpeningAnnouncement;
            return this;
        }
        public QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisksCourtOpeningAnnouncement getCourtOpeningAnnouncement() {
            return this.courtOpeningAnnouncement;
        }

    }

    public static class QuerySubjectPublicRiskResponseBodyResultRisksJusticeRisk extends TeaModel {
        @NameInMap("riskName")
        public String riskName;

        @NameInMap("riskNumber")
        public Long riskNumber;

        @NameInMap("riskType")
        public String riskType;

        @NameInMap("subRiskTypes")
        public java.util.List<String> subRiskTypes;

        @NameInMap("subRisks")
        public QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisks subRisks;

        public static QuerySubjectPublicRiskResponseBodyResultRisksJusticeRisk build(java.util.Map<String, ?> map) throws Exception {
            QuerySubjectPublicRiskResponseBodyResultRisksJusticeRisk self = new QuerySubjectPublicRiskResponseBodyResultRisksJusticeRisk();
            return TeaModel.build(map, self);
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksJusticeRisk setRiskName(String riskName) {
            this.riskName = riskName;
            return this;
        }
        public String getRiskName() {
            return this.riskName;
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksJusticeRisk setRiskNumber(Long riskNumber) {
            this.riskNumber = riskNumber;
            return this;
        }
        public Long getRiskNumber() {
            return this.riskNumber;
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksJusticeRisk setRiskType(String riskType) {
            this.riskType = riskType;
            return this;
        }
        public String getRiskType() {
            return this.riskType;
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksJusticeRisk setSubRiskTypes(java.util.List<String> subRiskTypes) {
            this.subRiskTypes = subRiskTypes;
            return this;
        }
        public java.util.List<String> getSubRiskTypes() {
            return this.subRiskTypes;
        }

        public QuerySubjectPublicRiskResponseBodyResultRisksJusticeRisk setSubRisks(QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisks subRisks) {
            this.subRisks = subRisks;
            return this;
        }
        public QuerySubjectPublicRiskResponseBodyResultRisksJusticeRiskSubRisks getSubRisks() {
            return this.subRisks;
        }

    }

    public static class QuerySubjectPublicRiskResponseBodyResultRisks extends TeaModel {
        @NameInMap("business_risk")
        public QuerySubjectPublicRiskResponseBodyResultRisksBusinessRisk businessRisk;

        @NameInMap("justice_risk")
        public QuerySubjectPublicRiskResponseBodyResultRisksJusticeRisk justiceRisk;

        public static QuerySubjectPublicRiskResponseBodyResultRisks build(java.util.Map<String, ?> map) throws Exception {
            QuerySubjectPublicRiskResponseBodyResultRisks self = new QuerySubjectPublicRiskResponseBodyResultRisks();
            return TeaModel.build(map, self);
        }

        public QuerySubjectPublicRiskResponseBodyResultRisks setBusinessRisk(QuerySubjectPublicRiskResponseBodyResultRisksBusinessRisk businessRisk) {
            this.businessRisk = businessRisk;
            return this;
        }
        public QuerySubjectPublicRiskResponseBodyResultRisksBusinessRisk getBusinessRisk() {
            return this.businessRisk;
        }

        public QuerySubjectPublicRiskResponseBodyResultRisks setJusticeRisk(QuerySubjectPublicRiskResponseBodyResultRisksJusticeRisk justiceRisk) {
            this.justiceRisk = justiceRisk;
            return this;
        }
        public QuerySubjectPublicRiskResponseBodyResultRisksJusticeRisk getJusticeRisk() {
            return this.justiceRisk;
        }

    }

    public static class QuerySubjectPublicRiskResponseBodyResult extends TeaModel {
        @NameInMap("aiRiskSummary")
        public String aiRiskSummary;

        @NameInMap("aiSampleRiskCount")
        public Long aiSampleRiskCount;

        @NameInMap("aiSummaryStatus")
        public String aiSummaryStatus;

        @NameInMap("bizId")
        public String bizId;

        @NameInMap("companyInfo")
        public QuerySubjectPublicRiskResponseBodyResultCompanyInfo companyInfo;

        @NameInMap("dataStatus")
        public String dataStatus;

        @NameInMap("dataUpdatedAt")
        public Long dataUpdatedAt;

        @NameInMap("freeBenefitRestEnough")
        public Boolean freeBenefitRestEnough;

        @NameInMap("riskTypes")
        public java.util.List<String> riskTypes;

        @NameInMap("risks")
        public QuerySubjectPublicRiskResponseBodyResultRisks risks;

        @NameInMap("subjectExist")
        public Boolean subjectExist;

        @NameInMap("totalRiskNumber")
        public Long totalRiskNumber;

        public static QuerySubjectPublicRiskResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QuerySubjectPublicRiskResponseBodyResult self = new QuerySubjectPublicRiskResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QuerySubjectPublicRiskResponseBodyResult setAiRiskSummary(String aiRiskSummary) {
            this.aiRiskSummary = aiRiskSummary;
            return this;
        }
        public String getAiRiskSummary() {
            return this.aiRiskSummary;
        }

        public QuerySubjectPublicRiskResponseBodyResult setAiSampleRiskCount(Long aiSampleRiskCount) {
            this.aiSampleRiskCount = aiSampleRiskCount;
            return this;
        }
        public Long getAiSampleRiskCount() {
            return this.aiSampleRiskCount;
        }

        public QuerySubjectPublicRiskResponseBodyResult setAiSummaryStatus(String aiSummaryStatus) {
            this.aiSummaryStatus = aiSummaryStatus;
            return this;
        }
        public String getAiSummaryStatus() {
            return this.aiSummaryStatus;
        }

        public QuerySubjectPublicRiskResponseBodyResult setBizId(String bizId) {
            this.bizId = bizId;
            return this;
        }
        public String getBizId() {
            return this.bizId;
        }

        public QuerySubjectPublicRiskResponseBodyResult setCompanyInfo(QuerySubjectPublicRiskResponseBodyResultCompanyInfo companyInfo) {
            this.companyInfo = companyInfo;
            return this;
        }
        public QuerySubjectPublicRiskResponseBodyResultCompanyInfo getCompanyInfo() {
            return this.companyInfo;
        }

        public QuerySubjectPublicRiskResponseBodyResult setDataStatus(String dataStatus) {
            this.dataStatus = dataStatus;
            return this;
        }
        public String getDataStatus() {
            return this.dataStatus;
        }

        public QuerySubjectPublicRiskResponseBodyResult setDataUpdatedAt(Long dataUpdatedAt) {
            this.dataUpdatedAt = dataUpdatedAt;
            return this;
        }
        public Long getDataUpdatedAt() {
            return this.dataUpdatedAt;
        }

        public QuerySubjectPublicRiskResponseBodyResult setFreeBenefitRestEnough(Boolean freeBenefitRestEnough) {
            this.freeBenefitRestEnough = freeBenefitRestEnough;
            return this;
        }
        public Boolean getFreeBenefitRestEnough() {
            return this.freeBenefitRestEnough;
        }

        public QuerySubjectPublicRiskResponseBodyResult setRiskTypes(java.util.List<String> riskTypes) {
            this.riskTypes = riskTypes;
            return this;
        }
        public java.util.List<String> getRiskTypes() {
            return this.riskTypes;
        }

        public QuerySubjectPublicRiskResponseBodyResult setRisks(QuerySubjectPublicRiskResponseBodyResultRisks risks) {
            this.risks = risks;
            return this;
        }
        public QuerySubjectPublicRiskResponseBodyResultRisks getRisks() {
            return this.risks;
        }

        public QuerySubjectPublicRiskResponseBodyResult setSubjectExist(Boolean subjectExist) {
            this.subjectExist = subjectExist;
            return this;
        }
        public Boolean getSubjectExist() {
            return this.subjectExist;
        }

        public QuerySubjectPublicRiskResponseBodyResult setTotalRiskNumber(Long totalRiskNumber) {
            this.totalRiskNumber = totalRiskNumber;
            return this;
        }
        public Long getTotalRiskNumber() {
            return this.totalRiskNumber;
        }

    }

}
