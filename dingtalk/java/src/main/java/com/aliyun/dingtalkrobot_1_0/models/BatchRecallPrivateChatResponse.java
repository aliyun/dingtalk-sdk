// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class BatchRecallPrivateChatResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public BatchRecallPrivateChatResponseBody body;

    public static BatchRecallPrivateChatResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchRecallPrivateChatResponse self = new BatchRecallPrivateChatResponse();
        return TeaModel.build(map, self);
    }

    public BatchRecallPrivateChatResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchRecallPrivateChatResponse setBody(BatchRecallPrivateChatResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchRecallPrivateChatResponseBody getBody() {
        return this.body;
    }

}
