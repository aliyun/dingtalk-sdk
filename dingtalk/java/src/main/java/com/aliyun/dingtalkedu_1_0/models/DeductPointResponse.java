// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeductPointResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeductPointResponseBody body;

    public static DeductPointResponse build(java.util.Map<String, ?> map) throws Exception {
        DeductPointResponse self = new DeductPointResponse();
        return TeaModel.build(map, self);
    }

    public DeductPointResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeductPointResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeductPointResponse setBody(DeductPointResponseBody body) {
        this.body = body;
        return this;
    }
    public DeductPointResponseBody getBody() {
        return this.body;
    }

}
