// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class RevokeTerminationResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public RevokeTerminationResponseBody body;

    public static RevokeTerminationResponse build(java.util.Map<String, ?> map) throws Exception {
        RevokeTerminationResponse self = new RevokeTerminationResponse();
        return TeaModel.build(map, self);
    }

    public RevokeTerminationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RevokeTerminationResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RevokeTerminationResponse setBody(RevokeTerminationResponseBody body) {
        this.body = body;
        return this;
    }
    public RevokeTerminationResponseBody getBody() {
        return this.body;
    }

}
