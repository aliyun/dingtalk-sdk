// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryFlashMinutesSummaryResponseBody extends TeaModel {
    @NameInMap("flashMinutesSummary")
    public QueryFlashMinutesSummaryResponseBodyFlashMinutesSummary flashMinutesSummary;

    public static QueryFlashMinutesSummaryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryFlashMinutesSummaryResponseBody self = new QueryFlashMinutesSummaryResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryFlashMinutesSummaryResponseBody setFlashMinutesSummary(QueryFlashMinutesSummaryResponseBodyFlashMinutesSummary flashMinutesSummary) {
        this.flashMinutesSummary = flashMinutesSummary;
        return this;
    }
    public QueryFlashMinutesSummaryResponseBodyFlashMinutesSummary getFlashMinutesSummary() {
        return this.flashMinutesSummary;
    }

    public static class QueryFlashMinutesSummaryResponseBodyFlashMinutesSummarySummary extends TeaModel {
        @NameInMap("end")
        public Long end;

        @NameInMap("headline")
        public String headline;

        @NameInMap("id")
        public Integer id;

        @NameInMap("start")
        public Long start;

        @NameInMap("summary")
        public String summary;

        public static QueryFlashMinutesSummaryResponseBodyFlashMinutesSummarySummary build(java.util.Map<String, ?> map) throws Exception {
            QueryFlashMinutesSummaryResponseBodyFlashMinutesSummarySummary self = new QueryFlashMinutesSummaryResponseBodyFlashMinutesSummarySummary();
            return TeaModel.build(map, self);
        }

        public QueryFlashMinutesSummaryResponseBodyFlashMinutesSummarySummary setEnd(Long end) {
            this.end = end;
            return this;
        }
        public Long getEnd() {
            return this.end;
        }

        public QueryFlashMinutesSummaryResponseBodyFlashMinutesSummarySummary setHeadline(String headline) {
            this.headline = headline;
            return this;
        }
        public String getHeadline() {
            return this.headline;
        }

        public QueryFlashMinutesSummaryResponseBodyFlashMinutesSummarySummary setId(Integer id) {
            this.id = id;
            return this;
        }
        public Integer getId() {
            return this.id;
        }

        public QueryFlashMinutesSummaryResponseBodyFlashMinutesSummarySummary setStart(Long start) {
            this.start = start;
            return this;
        }
        public Long getStart() {
            return this.start;
        }

        public QueryFlashMinutesSummaryResponseBodyFlashMinutesSummarySummary setSummary(String summary) {
            this.summary = summary;
            return this;
        }
        public String getSummary() {
            return this.summary;
        }

    }

    public static class QueryFlashMinutesSummaryResponseBodyFlashMinutesSummary extends TeaModel {
        @NameInMap("status")
        public Integer status;

        @NameInMap("summary")
        public java.util.List<QueryFlashMinutesSummaryResponseBodyFlashMinutesSummarySummary> summary;

        public static QueryFlashMinutesSummaryResponseBodyFlashMinutesSummary build(java.util.Map<String, ?> map) throws Exception {
            QueryFlashMinutesSummaryResponseBodyFlashMinutesSummary self = new QueryFlashMinutesSummaryResponseBodyFlashMinutesSummary();
            return TeaModel.build(map, self);
        }

        public QueryFlashMinutesSummaryResponseBodyFlashMinutesSummary setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public QueryFlashMinutesSummaryResponseBodyFlashMinutesSummary setSummary(java.util.List<QueryFlashMinutesSummaryResponseBodyFlashMinutesSummarySummary> summary) {
            this.summary = summary;
            return this;
        }
        public java.util.List<QueryFlashMinutesSummaryResponseBodyFlashMinutesSummarySummary> getSummary() {
            return this.summary;
        }

    }

}
