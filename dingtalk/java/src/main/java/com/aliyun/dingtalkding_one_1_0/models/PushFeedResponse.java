// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkding_one_1_0.models;

import com.aliyun.tea.*;

public class PushFeedResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PushFeedResponseBody body;

    public static PushFeedResponse build(java.util.Map<String, ?> map) throws Exception {
        PushFeedResponse self = new PushFeedResponse();
        return TeaModel.build(map, self);
    }

    public PushFeedResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PushFeedResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PushFeedResponse setBody(PushFeedResponseBody body) {
        this.body = body;
        return this;
    }
    public PushFeedResponseBody getBody() {
        return this.body;
    }

}
