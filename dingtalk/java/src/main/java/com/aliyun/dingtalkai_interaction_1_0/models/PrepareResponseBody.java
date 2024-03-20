// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_interaction_1_0.models;

import com.aliyun.tea.*;

public class PrepareResponseBody extends TeaModel {
    @NameInMap("result")
    public PrepareResponseBodyResult result;

    public static PrepareResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PrepareResponseBody self = new PrepareResponseBody();
        return TeaModel.build(map, self);
    }

    public PrepareResponseBody setResult(PrepareResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public PrepareResponseBodyResult getResult() {
        return this.result;
    }

    public static class PrepareResponseBodyResult extends TeaModel {
        @NameInMap("conversationToken")
        public String conversationToken;

        public static PrepareResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            PrepareResponseBodyResult self = new PrepareResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public PrepareResponseBodyResult setConversationToken(String conversationToken) {
            this.conversationToken = conversationToken;
            return this;
        }
        public String getConversationToken() {
            return this.conversationToken;
        }

    }

}
