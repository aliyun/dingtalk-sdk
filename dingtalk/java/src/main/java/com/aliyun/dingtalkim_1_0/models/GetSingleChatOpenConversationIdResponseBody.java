// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetSingleChatOpenConversationIdResponseBody extends TeaModel {
    @NameInMap("result")
    public GetSingleChatOpenConversationIdResponseBodyResult result;

    @NameInMap("success")
    public String success;

    public static GetSingleChatOpenConversationIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSingleChatOpenConversationIdResponseBody self = new GetSingleChatOpenConversationIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSingleChatOpenConversationIdResponseBody setResult(GetSingleChatOpenConversationIdResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetSingleChatOpenConversationIdResponseBodyResult getResult() {
        return this.result;
    }

    public GetSingleChatOpenConversationIdResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

    public static class GetSingleChatOpenConversationIdResponseBodyResult extends TeaModel {
        @NameInMap("openConversationId")
        public String openConversationId;

        public static GetSingleChatOpenConversationIdResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetSingleChatOpenConversationIdResponseBodyResult self = new GetSingleChatOpenConversationIdResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetSingleChatOpenConversationIdResponseBodyResult setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

    }

}
