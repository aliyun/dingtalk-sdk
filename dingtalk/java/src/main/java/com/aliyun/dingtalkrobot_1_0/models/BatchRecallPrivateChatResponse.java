// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class BatchRecallPrivateChatResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public BatchRecallPrivateChatResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchRecallPrivateChatResponse setBody(BatchRecallPrivateChatResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchRecallPrivateChatResponseBody getBody() {
        return this.body;
    }

}
