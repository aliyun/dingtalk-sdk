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
        @NameInMap("callBackData")
        public String callBackData;

        @NameInMap("callBackTag")
        public String callBackTag;

        @NameInMap("corpId")
        public String corpId;

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
