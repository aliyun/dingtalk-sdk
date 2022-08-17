// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class SubscribeLiveResponseBody extends TeaModel {
    @NameInMap("result")
    public SubscribeLiveResponseBodyResult result;

    public static SubscribeLiveResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SubscribeLiveResponseBody self = new SubscribeLiveResponseBody();
        return TeaModel.build(map, self);
    }

    public SubscribeLiveResponseBody setResult(SubscribeLiveResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SubscribeLiveResponseBodyResult getResult() {
        return this.result;
    }

    public static class SubscribeLiveResponseBodyResult extends TeaModel {
        @NameInMap("success")
        public Boolean success;

        public static SubscribeLiveResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SubscribeLiveResponseBodyResult self = new SubscribeLiveResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SubscribeLiveResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
