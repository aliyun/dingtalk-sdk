// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoccupationauth_1_0.models;

import com.aliyun.tea.*;

public class CheckUserTasksStatusResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public CheckUserTasksStatusResponse setBody(CheckUserTasksStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public CheckUserTasksStatusResponseBody getBody() {
        return this.body;
    }

}
