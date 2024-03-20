// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_interaction_1_0.models;

import com.aliyun.tea.*;

public class PrepareResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PrepareResponseBody body;

    public static PrepareResponse build(java.util.Map<String, ?> map) throws Exception {
        PrepareResponse self = new PrepareResponse();
        return TeaModel.build(map, self);
    }

    public PrepareResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PrepareResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PrepareResponse setBody(PrepareResponseBody body) {
        this.body = body;
        return this;
    }
    public PrepareResponseBody getBody() {
        return this.body;
    }

}
