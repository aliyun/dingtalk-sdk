// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryMedicalEventsResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<QueryMedicalEventsResponseBodyContent> content;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("success")
    public Boolean success;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("totalCount")
    public Long totalCount;

    public static QueryMedicalEventsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryMedicalEventsResponseBody self = new QueryMedicalEventsResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryMedicalEventsResponseBody setContent(java.util.List<QueryMedicalEventsResponseBodyContent> content) {
        this.content = content;
        return this;
    }
    public java.util.List<QueryMedicalEventsResponseBodyContent> getContent() {
        return this.content;
    }

    public QueryMedicalEventsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public QueryMedicalEventsResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class QueryMedicalEventsResponseBodyContent extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("code")
        public String code;

        @NameInMap("content")
        public String content;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("eventId")
        public Long eventId;

        public static QueryMedicalEventsResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryMedicalEventsResponseBodyContent self = new QueryMedicalEventsResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public QueryMedicalEventsResponseBodyContent setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryMedicalEventsResponseBodyContent setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public QueryMedicalEventsResponseBodyContent setEventId(Long eventId) {
            this.eventId = eventId;
            return this;
        }
        public Long getEventId() {
            return this.eventId;
        }

    }

}
