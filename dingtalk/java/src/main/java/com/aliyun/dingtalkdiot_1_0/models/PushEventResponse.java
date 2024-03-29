// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class PushEventResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PushEventResponseBody body;

    public static PushEventResponse build(java.util.Map<String, ?> map) throws Exception {
        PushEventResponse self = new PushEventResponse();
        return TeaModel.build(map, self);
    }

    public PushEventResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PushEventResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PushEventResponse setBody(PushEventResponseBody body) {
        this.body = body;
        return this;
    }
    public PushEventResponseBody getBody() {
        return this.body;
    }

}
