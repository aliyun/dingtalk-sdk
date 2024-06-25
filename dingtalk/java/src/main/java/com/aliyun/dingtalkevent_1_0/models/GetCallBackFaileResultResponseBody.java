// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkevent_1_0.models;

import com.aliyun.tea.*;

public class GetCallBackFaileResultResponseBody extends TeaModel {
    @NameInMap("failedList")
    public java.util.List<GetCallBackFaileResultResponseBodyFailedList> failedList;

    @NameInMap("hasMore")
    public Boolean hasMore;

    public static GetCallBackFaileResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCallBackFaileResultResponseBody self = new GetCallBackFaileResultResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCallBackFaileResultResponseBody setFailedList(java.util.List<GetCallBackFaileResultResponseBodyFailedList> failedList) {
        this.failedList = failedList;
        return this;
    }
    public java.util.List<GetCallBackFaileResultResponseBodyFailedList> getFailedList() {
        return this.failedList;
    }

    public GetCallBackFaileResultResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public static class GetCallBackFaileResultResponseBodyFailedList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>{&quot;CalendarEventUpdateTime&quot;:1668735924619,&quot;CorpId&quot;:&quot;ding9<strong>cd16741&quot;,&quot;ChangeType&quot;:&quot;updated&quot;,&quot;EventType&quot;:&quot;calendar_event_change&quot;,&quot;CalendarId&quot;:&quot;NzE3MjU0NEB1c2V</strong><em>5jb218MTQwMDE2&quot;,&quot;EventTime&quot;:1668735924640,&quot;LegacyCalendarEventId&quot;:&quot;1C1BB56076</em><strong>8A338&quot;,&quot;BizId&quot;:&quot;1668</strong>4640&quot;,&quot;CalendarEventId&quot;:&quot;RVNUZllHK<strong>elEydz09&quot;,&quot;operator&quot;:{&quot;type&quot;:&quot;user&quot;},&quot;UnionIdList&quot;:[&quot;QQa</strong>mYiE&quot;]}</p>
         */
        @NameInMap("callBackData")
        public String callBackData;

        /**
         * <strong>example:</strong>
         * <p>calendar_event_change</p>
         */
        @NameInMap("callBackTag")
        public String callBackTag;

        /**
         * <strong>example:</strong>
         * <p>ding9f50b15b*****41</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <strong>example:</strong>
         * <p>166***39184</p>
         */
        @NameInMap("eventTime")
        public Long eventTime;

        public static GetCallBackFaileResultResponseBodyFailedList build(java.util.Map<String, ?> map) throws Exception {
            GetCallBackFaileResultResponseBodyFailedList self = new GetCallBackFaileResultResponseBodyFailedList();
            return TeaModel.build(map, self);
        }

        public GetCallBackFaileResultResponseBodyFailedList setCallBackData(String callBackData) {
            this.callBackData = callBackData;
            return this;
        }
        public String getCallBackData() {
            return this.callBackData;
        }

        public GetCallBackFaileResultResponseBodyFailedList setCallBackTag(String callBackTag) {
            this.callBackTag = callBackTag;
            return this;
        }
        public String getCallBackTag() {
            return this.callBackTag;
        }

        public GetCallBackFaileResultResponseBodyFailedList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetCallBackFaileResultResponseBodyFailedList setEventTime(Long eventTime) {
            this.eventTime = eventTime;
            return this;
        }
        public Long getEventTime() {
            return this.eventTime;
        }

    }

}
