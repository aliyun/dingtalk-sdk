// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcarbon_1_0.models;

import com.aliyun.tea.*;

public class WriteIsvStateResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public WriteIsvStateResponseBody body;

    public static WriteIsvStateResponse build(java.util.Map<String, ?> map) throws Exception {
        WriteIsvStateResponse self = new WriteIsvStateResponse();
        return TeaModel.build(map, self);
    }

    public WriteIsvStateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public WriteIsvStateResponse setBody(WriteIsvStateResponseBody body) {
        this.body = body;
        return this;
    }
    public WriteIsvStateResponseBody getBody() {
        return this.body;
    }

}
