// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class EsignQueryGrantInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public EsignQueryGrantInfoResponseBody body;

    public static EsignQueryGrantInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        EsignQueryGrantInfoResponse self = new EsignQueryGrantInfoResponse();
        return TeaModel.build(map, self);
    }

    public EsignQueryGrantInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EsignQueryGrantInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EsignQueryGrantInfoResponse setBody(EsignQueryGrantInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public EsignQueryGrantInfoResponseBody getBody() {
        return this.body;
    }

}
