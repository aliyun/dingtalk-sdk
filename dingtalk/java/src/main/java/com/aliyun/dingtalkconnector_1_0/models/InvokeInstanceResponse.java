// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class InvokeInstanceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public InvokeInstanceResponseBody body;

    public static InvokeInstanceResponse build(java.util.Map<String, ?> map) throws Exception {
        InvokeInstanceResponse self = new InvokeInstanceResponse();
        return TeaModel.build(map, self);
    }

    public InvokeInstanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public InvokeInstanceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public InvokeInstanceResponse setBody(InvokeInstanceResponseBody body) {
        this.body = body;
        return this;
    }
    public InvokeInstanceResponseBody getBody() {
        return this.body;
    }

}
