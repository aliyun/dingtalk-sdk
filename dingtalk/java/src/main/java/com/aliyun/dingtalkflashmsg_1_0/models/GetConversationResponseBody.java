// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmsg_1_0.models;

import com.aliyun.tea.*;

public class GetConversationResponseBody extends TeaModel {
    @NameInMap("result")
    public GetConversationResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static GetConversationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetConversationResponseBody self = new GetConversationResponseBody();
        return TeaModel.build(map, self);
    }

    public GetConversationResponseBody setResult(GetConversationResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetConversationResponseBodyResult getResult() {
        return this.result;
    }

    public GetConversationResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetConversationResponseBodyResult extends TeaModel {
        @NameInMap("corpId")
        public String corpId;

        @NameInMap("memberCount")
        public Integer memberCount;

        @NameInMap("title")
        public String title;

        public static GetConversationResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetConversationResponseBodyResult self = new GetConversationResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetConversationResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetConversationResponseBodyResult setMemberCount(Integer memberCount) {
            this.memberCount = memberCount;
            return this;
        }
        public Integer getMemberCount() {
            return this.memberCount;
        }

        public GetConversationResponseBodyResult setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
