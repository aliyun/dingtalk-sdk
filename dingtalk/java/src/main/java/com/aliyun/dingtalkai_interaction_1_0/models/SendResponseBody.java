// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_interaction_1_0.models;

import com.aliyun.tea.*;

public class SendResponseBody extends TeaModel {
    @NameInMap("result")
    public SendResponseBodyResult result;

    public static SendResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendResponseBody self = new SendResponseBody();
        return TeaModel.build(map, self);
    }

    public SendResponseBody setResult(SendResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SendResponseBodyResult getResult() {
        return this.result;
    }

    public static class SendResponseBodyResult extends TeaModel {
        @NameInMap("success")
        public Boolean success;

        public static SendResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SendResponseBodyResult self = new SendResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SendResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
