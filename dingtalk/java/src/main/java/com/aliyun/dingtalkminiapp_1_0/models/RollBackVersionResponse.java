// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class RollBackVersionResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public RollBackVersionResponseBody body;

    public static RollBackVersionResponse build(java.util.Map<String, ?> map) throws Exception {
        RollBackVersionResponse self = new RollBackVersionResponse();
        return TeaModel.build(map, self);
    }

    public RollBackVersionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RollBackVersionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RollBackVersionResponse setBody(RollBackVersionResponseBody body) {
        this.body = body;
        return this;
    }
    public RollBackVersionResponseBody getBody() {
        return this.body;
    }

}
