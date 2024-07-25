// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class CancelConsumeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CancelConsumeResponseBody body;

    public static CancelConsumeResponse build(java.util.Map<String, ?> map) throws Exception {
        CancelConsumeResponse self = new CancelConsumeResponse();
        return TeaModel.build(map, self);
    }

    public CancelConsumeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CancelConsumeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CancelConsumeResponse setBody(CancelConsumeResponseBody body) {
        this.body = body;
        return this;
    }
    public CancelConsumeResponseBody getBody() {
        return this.body;
    }

}
