// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class SubscribeLiveResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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
