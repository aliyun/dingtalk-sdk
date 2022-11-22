// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkevent_1_0.models;

import com.aliyun.tea.*;

public class GetCallBackFaileResultResponseBody extends TeaModel {
    // 推送失败的事件列表，一次最多200个。
    @NameInMap("failedList")
    public java.util.List<GetCallBackFaileResultResponseBodyFailedList> failedList;

    // 是否还有推送失败的变更事件，若为true，则表示还有未回调的事件，或传入时间时范围内还有未回调的事件。
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
        // 返回的事件内容
        @NameInMap("callBackData")
        public String callBackData;

        // 事件类型
        @NameInMap("callBackTag")
        public String callBackTag;

        // 事件所属的corpId
        @NameInMap("corpId")
        public String corpId;

        // 事件的时间戳。
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
