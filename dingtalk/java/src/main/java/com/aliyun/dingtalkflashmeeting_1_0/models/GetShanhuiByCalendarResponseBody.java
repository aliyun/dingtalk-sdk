// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmeeting_1_0.models;

import com.aliyun.tea.*;

public class GetShanhuiByCalendarResponseBody extends TeaModel {
    @NameInMap("result")
    public GetShanhuiByCalendarResponseBodyResult result;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static GetShanhuiByCalendarResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetShanhuiByCalendarResponseBody self = new GetShanhuiByCalendarResponseBody();
        return TeaModel.build(map, self);
    }

    public GetShanhuiByCalendarResponseBody setResult(GetShanhuiByCalendarResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetShanhuiByCalendarResponseBodyResult getResult() {
        return this.result;
    }

    public GetShanhuiByCalendarResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetShanhuiByCalendarResponseBodyResultTopics extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>27Hio9BV23Ghj8LkRe34QzSdP94UtMkju</p>
         */
        @NameInMap("docKey")
        public String docKey;

        /**
         * <strong>example:</strong>
         * <p>会议1</p>
         */
        @NameInMap("title")
        public String title;

        public static GetShanhuiByCalendarResponseBodyResultTopics build(java.util.Map<String, ?> map) throws Exception {
            GetShanhuiByCalendarResponseBodyResultTopics self = new GetShanhuiByCalendarResponseBodyResultTopics();
            return TeaModel.build(map, self);
        }

        public GetShanhuiByCalendarResponseBodyResultTopics setDocKey(String docKey) {
            this.docKey = docKey;
            return this;
        }
        public String getDocKey() {
            return this.docKey;
        }

        public GetShanhuiByCalendarResponseBodyResultTopics setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class GetShanhuiByCalendarResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>1685332800000</p>
         */
        @NameInMap("endTime")
        public Long endTime;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>8K4ny9P9No06sjhk</p>
         */
        @NameInMap("flashmeetingKey")
        public String flashmeetingKey;

        /**
         * <strong>example:</strong>
         * <p>false</p>
         */
        @NameInMap("hasSummary")
        public Boolean hasSummary;

        /**
         * <strong>example:</strong>
         * <p>1685318400000</p>
         */
        @NameInMap("startTime")
        public Long startTime;

        /**
         * <strong>example:</strong>
         * <p>2Hj32Uio28fjmMiu9Klsk</p>
         */
        @NameInMap("summaryDocKey")
        public String summaryDocKey;

        /**
         * <strong>example:</strong>
         * <p>测试闪会</p>
         */
        @NameInMap("title")
        public String title;

        @NameInMap("topics")
        public java.util.List<GetShanhuiByCalendarResponseBodyResultTopics> topics;

        public static GetShanhuiByCalendarResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetShanhuiByCalendarResponseBodyResult self = new GetShanhuiByCalendarResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetShanhuiByCalendarResponseBodyResult setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public GetShanhuiByCalendarResponseBodyResult setFlashmeetingKey(String flashmeetingKey) {
            this.flashmeetingKey = flashmeetingKey;
            return this;
        }
        public String getFlashmeetingKey() {
            return this.flashmeetingKey;
        }

        public GetShanhuiByCalendarResponseBodyResult setHasSummary(Boolean hasSummary) {
            this.hasSummary = hasSummary;
            return this;
        }
        public Boolean getHasSummary() {
            return this.hasSummary;
        }

        public GetShanhuiByCalendarResponseBodyResult setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public GetShanhuiByCalendarResponseBodyResult setSummaryDocKey(String summaryDocKey) {
            this.summaryDocKey = summaryDocKey;
            return this;
        }
        public String getSummaryDocKey() {
            return this.summaryDocKey;
        }

        public GetShanhuiByCalendarResponseBodyResult setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public GetShanhuiByCalendarResponseBodyResult setTopics(java.util.List<GetShanhuiByCalendarResponseBodyResultTopics> topics) {
            this.topics = topics;
            return this;
        }
        public java.util.List<GetShanhuiByCalendarResponseBodyResultTopics> getTopics() {
            return this.topics;
        }

    }

}
