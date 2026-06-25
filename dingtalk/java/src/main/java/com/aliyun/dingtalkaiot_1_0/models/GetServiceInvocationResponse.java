// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkaiot_1_0.models;

import com.aliyun.tea.*;

public class GetServiceInvocationResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetServiceInvocationResponseBody body;

    public static GetServiceInvocationResponse build(java.util.Map<String, ?> map) throws Exception {
        GetServiceInvocationResponse self = new GetServiceInvocationResponse();
        return TeaModel.build(map, self);
    }

    public GetServiceInvocationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetServiceInvocationResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetServiceInvocationResponse setBody(GetServiceInvocationResponseBody body) {
        this.body = body;
        return this;
    }
    public GetServiceInvocationResponseBody getBody() {
        return this.body;
    }

}
