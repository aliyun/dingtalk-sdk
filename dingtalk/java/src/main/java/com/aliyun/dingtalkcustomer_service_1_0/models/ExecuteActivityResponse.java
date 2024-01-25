// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcustomer_service_1_0.models;

import com.aliyun.tea.*;

public class ExecuteActivityResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ExecuteActivityResponseBody body;

    public static ExecuteActivityResponse build(java.util.Map<String, ?> map) throws Exception {
        ExecuteActivityResponse self = new ExecuteActivityResponse();
        return TeaModel.build(map, self);
    }

    public ExecuteActivityResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ExecuteActivityResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ExecuteActivityResponse setBody(ExecuteActivityResponseBody body) {
        this.body = body;
        return this;
    }
    public ExecuteActivityResponseBody getBody() {
        return this.body;
    }

}
