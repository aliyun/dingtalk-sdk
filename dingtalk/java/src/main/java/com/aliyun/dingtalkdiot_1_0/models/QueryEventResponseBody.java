// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class QueryEventResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<QueryEventResponseBodyData> data;

    @NameInMap("pageNumber")
    public Long pageNumber;

    @NameInMap("pageSize")
    public Long pageSize;

    @NameInMap("totalCount")
    public Long totalCount;

    public static QueryEventResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryEventResponseBody self = new QueryEventResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryEventResponseBody setData(java.util.List<QueryEventResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<QueryEventResponseBodyData> getData() {
        return this.data;
    }

    public QueryEventResponseBody setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public QueryEventResponseBody setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public QueryEventResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class QueryEventResponseBodyData extends TeaModel {
        @NameInMap("eventId")
        public String eventId;

        @NameInMap("eventName")
        public String eventName;

        @NameInMap("eventStatus")
        public Long eventStatus;

        @NameInMap("eventType")
        public String eventType;

        @NameInMap("msg")
        public String msg;

        @NameInMap("occurrenceTime")
        public Long occurrenceTime;

        @NameInMap("picUrls")
        public java.util.List<String> picUrls;

        public static QueryEventResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            QueryEventResponseBodyData self = new QueryEventResponseBodyData();
            return TeaModel.build(map, self);
        }

        public QueryEventResponseBodyData setEventId(String eventId) {
            this.eventId = eventId;
            return this;
        }
        public String getEventId() {
            return this.eventId;
        }

        public QueryEventResponseBodyData setEventName(String eventName) {
            this.eventName = eventName;
            return this;
        }
        public String getEventName() {
            return this.eventName;
        }

        public QueryEventResponseBodyData setEventStatus(Long eventStatus) {
            this.eventStatus = eventStatus;
            return this;
        }
        public Long getEventStatus() {
            return this.eventStatus;
        }

        public QueryEventResponseBodyData setEventType(String eventType) {
            this.eventType = eventType;
            return this;
        }
        public String getEventType() {
            return this.eventType;
        }

        public QueryEventResponseBodyData setMsg(String msg) {
            this.msg = msg;
            return this;
        }
        public String getMsg() {
            return this.msg;
        }

        public QueryEventResponseBodyData setOccurrenceTime(Long occurrenceTime) {
            this.occurrenceTime = occurrenceTime;
            return this;
        }
        public Long getOccurrenceTime() {
            return this.occurrenceTime;
        }

        public QueryEventResponseBodyData setPicUrls(java.util.List<String> picUrls) {
            this.picUrls = picUrls;
            return this;
        }
        public java.util.List<String> getPicUrls() {
            return this.picUrls;
        }

    }

}
