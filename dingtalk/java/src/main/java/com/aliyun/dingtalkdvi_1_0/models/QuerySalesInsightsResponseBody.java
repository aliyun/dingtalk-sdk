// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class QuerySalesInsightsResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<QuerySalesInsightsResponseBodyResult> result;

    public static QuerySalesInsightsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QuerySalesInsightsResponseBody self = new QuerySalesInsightsResponseBody();
        return TeaModel.build(map, self);
    }

    public QuerySalesInsightsResponseBody setResult(java.util.List<QuerySalesInsightsResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<QuerySalesInsightsResponseBodyResult> getResult() {
        return this.result;
    }

    public static class QuerySalesInsightsResponseBodyResultCapabilityRadarDimensions extends TeaModel {
        @NameInMap("label")
        public String label;

        @NameInMap("score")
        public Float score;

        public static QuerySalesInsightsResponseBodyResultCapabilityRadarDimensions build(java.util.Map<String, ?> map) throws Exception {
            QuerySalesInsightsResponseBodyResultCapabilityRadarDimensions self = new QuerySalesInsightsResponseBodyResultCapabilityRadarDimensions();
            return TeaModel.build(map, self);
        }

        public QuerySalesInsightsResponseBodyResultCapabilityRadarDimensions setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public QuerySalesInsightsResponseBodyResultCapabilityRadarDimensions setScore(Float score) {
            this.score = score;
            return this;
        }
        public Float getScore() {
            return this.score;
        }

    }

    public static class QuerySalesInsightsResponseBodyResultCapabilityRadar extends TeaModel {
        @NameInMap("dimensions")
        public java.util.List<QuerySalesInsightsResponseBodyResultCapabilityRadarDimensions> dimensions;

        public static QuerySalesInsightsResponseBodyResultCapabilityRadar build(java.util.Map<String, ?> map) throws Exception {
            QuerySalesInsightsResponseBodyResultCapabilityRadar self = new QuerySalesInsightsResponseBodyResultCapabilityRadar();
            return TeaModel.build(map, self);
        }

        public QuerySalesInsightsResponseBodyResultCapabilityRadar setDimensions(java.util.List<QuerySalesInsightsResponseBodyResultCapabilityRadarDimensions> dimensions) {
            this.dimensions = dimensions;
            return this;
        }
        public java.util.List<QuerySalesInsightsResponseBodyResultCapabilityRadarDimensions> getDimensions() {
            return this.dimensions;
        }

    }

    public static class QuerySalesInsightsResponseBodyResultInsightListCommonSummary extends TeaModel {
        @NameInMap("content")
        public String content;

        @NameInMap("name")
        public String name;

        @NameInMap("priority")
        public String priority;

        @NameInMap("priorityText")
        public String priorityText;

        public static QuerySalesInsightsResponseBodyResultInsightListCommonSummary build(java.util.Map<String, ?> map) throws Exception {
            QuerySalesInsightsResponseBodyResultInsightListCommonSummary self = new QuerySalesInsightsResponseBodyResultInsightListCommonSummary();
            return TeaModel.build(map, self);
        }

        public QuerySalesInsightsResponseBodyResultInsightListCommonSummary setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public QuerySalesInsightsResponseBodyResultInsightListCommonSummary setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QuerySalesInsightsResponseBodyResultInsightListCommonSummary setPriority(String priority) {
            this.priority = priority;
            return this;
        }
        public String getPriority() {
            return this.priority;
        }

        public QuerySalesInsightsResponseBodyResultInsightListCommonSummary setPriorityText(String priorityText) {
            this.priorityText = priorityText;
            return this;
        }
        public String getPriorityText() {
            return this.priorityText;
        }

    }

    public static class QuerySalesInsightsResponseBodyResultInsightList extends TeaModel {
        @NameInMap("commonSummary")
        public java.util.List<QuerySalesInsightsResponseBodyResultInsightListCommonSummary> commonSummary;

        @NameInMap("name")
        public String name;

        public static QuerySalesInsightsResponseBodyResultInsightList build(java.util.Map<String, ?> map) throws Exception {
            QuerySalesInsightsResponseBodyResultInsightList self = new QuerySalesInsightsResponseBodyResultInsightList();
            return TeaModel.build(map, self);
        }

        public QuerySalesInsightsResponseBodyResultInsightList setCommonSummary(java.util.List<QuerySalesInsightsResponseBodyResultInsightListCommonSummary> commonSummary) {
            this.commonSummary = commonSummary;
            return this;
        }
        public java.util.List<QuerySalesInsightsResponseBodyResultInsightListCommonSummary> getCommonSummary() {
            return this.commonSummary;
        }

        public QuerySalesInsightsResponseBodyResultInsightList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class QuerySalesInsightsResponseBodyResult extends TeaModel {
        @NameInMap("analysisDate")
        public String analysisDate;

        @NameInMap("capabilityRadar")
        public QuerySalesInsightsResponseBodyResultCapabilityRadar capabilityRadar;

        @NameInMap("insightList")
        public java.util.List<QuerySalesInsightsResponseBodyResultInsightList> insightList;

        @NameInMap("teamCode")
        public String teamCode;

        @NameInMap("userId")
        public String userId;

        public static QuerySalesInsightsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QuerySalesInsightsResponseBodyResult self = new QuerySalesInsightsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QuerySalesInsightsResponseBodyResult setAnalysisDate(String analysisDate) {
            this.analysisDate = analysisDate;
            return this;
        }
        public String getAnalysisDate() {
            return this.analysisDate;
        }

        public QuerySalesInsightsResponseBodyResult setCapabilityRadar(QuerySalesInsightsResponseBodyResultCapabilityRadar capabilityRadar) {
            this.capabilityRadar = capabilityRadar;
            return this;
        }
        public QuerySalesInsightsResponseBodyResultCapabilityRadar getCapabilityRadar() {
            return this.capabilityRadar;
        }

        public QuerySalesInsightsResponseBodyResult setInsightList(java.util.List<QuerySalesInsightsResponseBodyResultInsightList> insightList) {
            this.insightList = insightList;
            return this;
        }
        public java.util.List<QuerySalesInsightsResponseBodyResultInsightList> getInsightList() {
            return this.insightList;
        }

        public QuerySalesInsightsResponseBodyResult setTeamCode(String teamCode) {
            this.teamCode = teamCode;
            return this;
        }
        public String getTeamCode() {
            return this.teamCode;
        }

        public QuerySalesInsightsResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
