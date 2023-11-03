// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwatt_1_0.models;

import com.aliyun.tea.*;

public class RevertPointResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public RevertPointResponseBody body;

    public static RevertPointResponse build(java.util.Map<String, ?> map) throws Exception {
        RevertPointResponse self = new RevertPointResponse();
        return TeaModel.build(map, self);
    }

    public RevertPointResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RevertPointResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RevertPointResponse setBody(RevertPointResponseBody body) {
        this.body = body;
        return this;
    }
    public RevertPointResponseBody getBody() {
        return this.body;
    }

}
