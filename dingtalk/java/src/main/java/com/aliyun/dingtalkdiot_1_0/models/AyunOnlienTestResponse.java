// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class AyunOnlienTestResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public AyunOnlienTestResponseBody body;

    public static AyunOnlienTestResponse build(java.util.Map<String, ?> map) throws Exception {
        AyunOnlienTestResponse self = new AyunOnlienTestResponse();
        return TeaModel.build(map, self);
    }

    public AyunOnlienTestResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AyunOnlienTestResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AyunOnlienTestResponse setBody(AyunOnlienTestResponseBody body) {
        this.body = body;
        return this;
    }
    public AyunOnlienTestResponseBody getBody() {
        return this.body;
    }

}
