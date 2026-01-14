// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkding_one_1_0.models;

import com.aliyun.tea.*;

public class PushFeedResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public PushFeedResponseBodyResult result;

    public static PushFeedResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PushFeedResponseBody self = new PushFeedResponseBody();
        return TeaModel.build(map, self);
    }

    public PushFeedResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public PushFeedResponseBody setResult(PushFeedResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public PushFeedResponseBodyResult getResult() {
        return this.result;
    }

    public static class PushFeedResponseBodyResult extends TeaModel {
        @NameInMap("feedId")
        public String feedId;

        public static PushFeedResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            PushFeedResponseBodyResult self = new PushFeedResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public PushFeedResponseBodyResult setFeedId(String feedId) {
            this.feedId = feedId;
            return this;
        }
        public String getFeedId() {
            return this.feedId;
        }

    }

}
