// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class GetGroupLiveListRequest extends TeaModel {
    @NameInMap("requestBody")
    public GetGroupLiveListRequestRequestBody requestBody;

    @NameInMap("unionId")
    public String unionId;

    public static GetGroupLiveListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetGroupLiveListRequest self = new GetGroupLiveListRequest();
        return TeaModel.build(map, self);
    }

    public GetGroupLiveListRequest setRequestBody(GetGroupLiveListRequestRequestBody requestBody) {
        this.requestBody = requestBody;
        return this;
    }
    public GetGroupLiveListRequestRequestBody getRequestBody() {
        return this.requestBody;
    }

    public GetGroupLiveListRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class GetGroupLiveListRequestRequestBody extends TeaModel {
        @NameInMap("endTime")
        public Long endTime;

        @NameInMap("openConversationId")
        public String openConversationId;

        @NameInMap("startTime")
        public Long startTime;

        public static GetGroupLiveListRequestRequestBody build(java.util.Map<String, ?> map) throws Exception {
            GetGroupLiveListRequestRequestBody self = new GetGroupLiveListRequestRequestBody();
            return TeaModel.build(map, self);
        }

        public GetGroupLiveListRequestRequestBody setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public GetGroupLiveListRequestRequestBody setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

        public GetGroupLiveListRequestRequestBody setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

    }

}
