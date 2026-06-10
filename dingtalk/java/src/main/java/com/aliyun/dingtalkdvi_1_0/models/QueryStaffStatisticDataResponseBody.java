// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class QueryStaffStatisticDataResponseBody extends TeaModel {
    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("result")
    public java.util.List<QueryStaffStatisticDataResponseBodyResult> result;

    @NameInMap("success")
    public Boolean success;

    @NameInMap("totalCount")
    public Long totalCount;

    public static QueryStaffStatisticDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryStaffStatisticDataResponseBody self = new QueryStaffStatisticDataResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryStaffStatisticDataResponseBody setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public QueryStaffStatisticDataResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryStaffStatisticDataResponseBody setResult(java.util.List<QueryStaffStatisticDataResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<QueryStaffStatisticDataResponseBodyResult> getResult() {
        return this.result;
    }

    public QueryStaffStatisticDataResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public QueryStaffStatisticDataResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class QueryStaffStatisticDataResponseBodyResult extends TeaModel {
        @NameInMap("averageQualityInspectionScorePerService")
        public Double averageQualityInspectionScorePerService;

        @NameInMap("day")
        public String day;

        @NameInMap("highestQualityInspectionScore")
        public Double highestQualityInspectionScore;

        @NameInMap("saleSopPercentage")
        public java.util.Map<String, ?> saleSopPercentage;

        @NameInMap("serviceRecordCount")
        public Long serviceRecordCount;

        @NameInMap("staffName")
        public String staffName;

        @NameInMap("teamCode")
        public String teamCode;

        @NameInMap("teamName")
        public String teamName;

        @NameInMap("totalServiceTime")
        public Long totalServiceTime;

        @NameInMap("userId")
        public String userId;

        public static QueryStaffStatisticDataResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryStaffStatisticDataResponseBodyResult self = new QueryStaffStatisticDataResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryStaffStatisticDataResponseBodyResult setAverageQualityInspectionScorePerService(Double averageQualityInspectionScorePerService) {
            this.averageQualityInspectionScorePerService = averageQualityInspectionScorePerService;
            return this;
        }
        public Double getAverageQualityInspectionScorePerService() {
            return this.averageQualityInspectionScorePerService;
        }

        public QueryStaffStatisticDataResponseBodyResult setDay(String day) {
            this.day = day;
            return this;
        }
        public String getDay() {
            return this.day;
        }

        public QueryStaffStatisticDataResponseBodyResult setHighestQualityInspectionScore(Double highestQualityInspectionScore) {
            this.highestQualityInspectionScore = highestQualityInspectionScore;
            return this;
        }
        public Double getHighestQualityInspectionScore() {
            return this.highestQualityInspectionScore;
        }

        public QueryStaffStatisticDataResponseBodyResult setSaleSopPercentage(java.util.Map<String, ?> saleSopPercentage) {
            this.saleSopPercentage = saleSopPercentage;
            return this;
        }
        public java.util.Map<String, ?> getSaleSopPercentage() {
            return this.saleSopPercentage;
        }

        public QueryStaffStatisticDataResponseBodyResult setServiceRecordCount(Long serviceRecordCount) {
            this.serviceRecordCount = serviceRecordCount;
            return this;
        }
        public Long getServiceRecordCount() {
            return this.serviceRecordCount;
        }

        public QueryStaffStatisticDataResponseBodyResult setStaffName(String staffName) {
            this.staffName = staffName;
            return this;
        }
        public String getStaffName() {
            return this.staffName;
        }

        public QueryStaffStatisticDataResponseBodyResult setTeamCode(String teamCode) {
            this.teamCode = teamCode;
            return this;
        }
        public String getTeamCode() {
            return this.teamCode;
        }

        public QueryStaffStatisticDataResponseBodyResult setTeamName(String teamName) {
            this.teamName = teamName;
            return this;
        }
        public String getTeamName() {
            return this.teamName;
        }

        public QueryStaffStatisticDataResponseBodyResult setTotalServiceTime(Long totalServiceTime) {
            this.totalServiceTime = totalServiceTime;
            return this;
        }
        public Long getTotalServiceTime() {
            return this.totalServiceTime;
        }

        public QueryStaffStatisticDataResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
