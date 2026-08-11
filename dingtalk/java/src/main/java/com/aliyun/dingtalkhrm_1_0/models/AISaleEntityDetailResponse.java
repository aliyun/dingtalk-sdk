// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AISaleEntityDetailResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AISaleEntityDetailResponseBody body;

    public static AISaleEntityDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        AISaleEntityDetailResponse self = new AISaleEntityDetailResponse();
        return TeaModel.build(map, self);
    }

    public AISaleEntityDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AISaleEntityDetailResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AISaleEntityDetailResponse setBody(AISaleEntityDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public AISaleEntityDetailResponseBody getBody() {
        return this.body;
    }

}
