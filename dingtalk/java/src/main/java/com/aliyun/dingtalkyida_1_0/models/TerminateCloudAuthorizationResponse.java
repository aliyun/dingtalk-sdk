// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class TerminateCloudAuthorizationResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TerminateCloudAuthorizationResponseBody body;

    public static TerminateCloudAuthorizationResponse build(java.util.Map<String, ?> map) throws Exception {
        TerminateCloudAuthorizationResponse self = new TerminateCloudAuthorizationResponse();
        return TeaModel.build(map, self);
    }

    public TerminateCloudAuthorizationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TerminateCloudAuthorizationResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TerminateCloudAuthorizationResponse setBody(TerminateCloudAuthorizationResponseBody body) {
        this.body = body;
        return this;
    }
    public TerminateCloudAuthorizationResponseBody getBody() {
        return this.body;
    }

}
