// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoccupationauth_1_0.models;

import com.aliyun.tea.*;

public class CheckUserTaskStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CheckUserTaskStatusResponseBody body;

    public static CheckUserTaskStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        CheckUserTaskStatusResponse self = new CheckUserTaskStatusResponse();
        return TeaModel.build(map, self);
    }

    public CheckUserTaskStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CheckUserTaskStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CheckUserTaskStatusResponse setBody(CheckUserTaskStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public CheckUserTaskStatusResponseBody getBody() {
        return this.body;
    }

}
