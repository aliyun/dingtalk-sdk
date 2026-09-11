// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class SetA1DetailPageCustomTabResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SetA1DetailPageCustomTabResponseBody body;

    public static SetA1DetailPageCustomTabResponse build(java.util.Map<String, ?> map) throws Exception {
        SetA1DetailPageCustomTabResponse self = new SetA1DetailPageCustomTabResponse();
        return TeaModel.build(map, self);
    }

    public SetA1DetailPageCustomTabResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SetA1DetailPageCustomTabResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SetA1DetailPageCustomTabResponse setBody(SetA1DetailPageCustomTabResponseBody body) {
        this.body = body;
        return this;
    }
    public SetA1DetailPageCustomTabResponseBody getBody() {
        return this.body;
    }

}
