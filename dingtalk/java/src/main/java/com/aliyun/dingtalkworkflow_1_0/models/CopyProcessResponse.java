// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class CopyProcessResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CopyProcessResponseBody body;

    public static CopyProcessResponse build(java.util.Map<String, ?> map) throws Exception {
        CopyProcessResponse self = new CopyProcessResponse();
        return TeaModel.build(map, self);
    }

    public CopyProcessResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CopyProcessResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CopyProcessResponse setBody(CopyProcessResponseBody body) {
        this.body = body;
        return this;
    }
    public CopyProcessResponseBody getBody() {
        return this.body;
    }

}
