// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class EsignUserVerifyResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public EsignUserVerifyResponseBody body;

    public static EsignUserVerifyResponse build(java.util.Map<String, ?> map) throws Exception {
        EsignUserVerifyResponse self = new EsignUserVerifyResponse();
        return TeaModel.build(map, self);
    }

    public EsignUserVerifyResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EsignUserVerifyResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EsignUserVerifyResponse setBody(EsignUserVerifyResponseBody body) {
        this.body = body;
        return this;
    }
    public EsignUserVerifyResponseBody getBody() {
        return this.body;
    }

}
