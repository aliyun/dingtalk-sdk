// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmeeting_1_0.models;

import com.aliyun.tea.*;

public class GetShanhuiByShanhuiKeyResponseBody extends TeaModel {
    @NameInMap("result")
    public GetShanhuiByShanhuiKeyResponseBodyResult result;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static GetShanhuiByShanhuiKeyResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetShanhuiByShanhuiKeyResponseBody self = new GetShanhuiByShanhuiKeyResponseBody();
        return TeaModel.build(map, self);
    }

    public GetShanhuiByShanhuiKeyResponseBody setResult(GetShanhuiByShanhuiKeyResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetShanhuiByShanhuiKeyResponseBodyResult getResult() {
        return this.result;
    }

    public GetShanhuiByShanhuiKeyResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetShanhuiByShanhuiKeyResponseBodyResultTopics extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>27Hio9BV23Ghj8LkRe34QzSdP94UtMkju</p>
         */
        @NameInMap("docKey")
        public String docKey;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>会议1</p>
         */
        @NameInMap("title")
        public String title;

        public static GetShanhuiByShanhuiKeyResponseBodyResultTopics build(java.util.Map<String, ?> map) throws Exception {
            GetShanhuiByShanhuiKeyResponseBodyResultTopics self = new GetShanhuiByShanhuiKeyResponseBodyResultTopics();
            return TeaModel.build(map, self);
        }

        public GetShanhuiByShanhuiKeyResponseBodyResultTopics setDocKey(String docKey) {
            this.docKey = docKey;
            return this;
        }
        public String getDocKey() {
            return this.docKey;
        }

        public GetShanhuiByShanhuiKeyResponseBodyResultTopics setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class GetShanhuiByShanhuiKeyResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>1685332800000</p>
         */
        @NameInMap("endTime")
        public Long endTime;

        /**
         * <strong>example:</strong>
         * <p>2kms47sjhb882</p>
         */
        @NameInMap("eventId")
        public String eventId;

        /**
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
        public java.util.List<GetShanhuiByShanhuiKeyResponseBodyResultTopics> topics;

        public static GetShanhuiByShanhuiKeyResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetShanhuiByShanhuiKeyResponseBodyResult self = new GetShanhuiByShanhuiKeyResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetShanhuiByShanhuiKeyResponseBodyResult setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public GetShanhuiByShanhuiKeyResponseBodyResult setEventId(String eventId) {
            this.eventId = eventId;
            return this;
        }
        public String getEventId() {
            return this.eventId;
        }

        public GetShanhuiByShanhuiKeyResponseBodyResult setFlashmeetingKey(String flashmeetingKey) {
            this.flashmeetingKey = flashmeetingKey;
            return this;
        }
        public String getFlashmeetingKey() {
            return this.flashmeetingKey;
        }

        public GetShanhuiByShanhuiKeyResponseBodyResult setHasSummary(Boolean hasSummary) {
            this.hasSummary = hasSummary;
            return this;
        }
        public Boolean getHasSummary() {
            return this.hasSummary;
        }

        public GetShanhuiByShanhuiKeyResponseBodyResult setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public GetShanhuiByShanhuiKeyResponseBodyResult setSummaryDocKey(String summaryDocKey) {
            this.summaryDocKey = summaryDocKey;
            return this;
        }
        public String getSummaryDocKey() {
            return this.summaryDocKey;
        }

        public GetShanhuiByShanhuiKeyResponseBodyResult setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public GetShanhuiByShanhuiKeyResponseBodyResult setTopics(java.util.List<GetShanhuiByShanhuiKeyResponseBodyResultTopics> topics) {
            this.topics = topics;
            return this;
        }
        public java.util.List<GetShanhuiByShanhuiKeyResponseBodyResultTopics> getTopics() {
            return this.topics;
        }

    }

}
