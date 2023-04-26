// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class SubscribeLiveResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public SubscribeLiveResponseBody body;

    public static SubscribeLiveResponse build(java.util.Map<String, ?> map) throws Exception {
        SubscribeLiveResponse self = new SubscribeLiveResponse();
        return TeaModel.build(map, self);
    }

    public SubscribeLiveResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SubscribeLiveResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SubscribeLiveResponse setBody(SubscribeLiveResponseBody body) {
        this.body = body;
        return this;
    }
    public SubscribeLiveResponseBody getBody() {
        return this.body;
    }

}
