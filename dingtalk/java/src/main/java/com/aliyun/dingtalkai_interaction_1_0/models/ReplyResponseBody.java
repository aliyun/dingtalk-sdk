// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_interaction_1_0.models;

import com.aliyun.tea.*;

public class ReplyResponseBody extends TeaModel {
    @NameInMap("result")
    public ReplyResponseBodyResult result;

    public static ReplyResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ReplyResponseBody self = new ReplyResponseBody();
        return TeaModel.build(map, self);
    }

    public ReplyResponseBody setResult(ReplyResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public ReplyResponseBodyResult getResult() {
        return this.result;
    }

    public static class ReplyResponseBodyResult extends TeaModel {
        @NameInMap("success")
        public Boolean success;

        public static ReplyResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ReplyResponseBodyResult self = new ReplyResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ReplyResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
