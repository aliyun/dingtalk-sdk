// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AISaleTaskResultResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AISaleTaskResultResponseBody body;

    public static AISaleTaskResultResponse build(java.util.Map<String, ?> map) throws Exception {
        AISaleTaskResultResponse self = new AISaleTaskResultResponse();
        return TeaModel.build(map, self);
    }

    public AISaleTaskResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AISaleTaskResultResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AISaleTaskResultResponse setBody(AISaleTaskResultResponseBody body) {
        this.body = body;
        return this;
    }
    public AISaleTaskResultResponseBody getBody() {
        return this.body;
    }

}
