// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoccupationauth_1_0.models;

import com.aliyun.tea.*;

public class CheckUserTasksStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CheckUserTasksStatusResponseBody body;

    public static CheckUserTasksStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        CheckUserTasksStatusResponse self = new CheckUserTasksStatusResponse();
        return TeaModel.build(map, self);
    }

    public CheckUserTasksStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CheckUserTasksStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CheckUserTasksStatusResponse setBody(CheckUserTasksStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public CheckUserTasksStatusResponseBody getBody() {
        return this.body;
    }

}
