// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ExecuteCustomApiResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ExecuteCustomApiResponseBody body;

    public static ExecuteCustomApiResponse build(java.util.Map<String, ?> map) throws Exception {
        ExecuteCustomApiResponse self = new ExecuteCustomApiResponse();
        return TeaModel.build(map, self);
    }

    public ExecuteCustomApiResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ExecuteCustomApiResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ExecuteCustomApiResponse setBody(ExecuteCustomApiResponseBody body) {
        this.body = body;
        return this;
    }
    public ExecuteCustomApiResponseBody getBody() {
        return this.body;
    }

}
