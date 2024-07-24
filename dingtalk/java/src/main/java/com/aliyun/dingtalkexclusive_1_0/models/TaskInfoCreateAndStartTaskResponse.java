// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class TaskInfoCreateAndStartTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TaskInfoCreateAndStartTaskResponseBody body;

    public static TaskInfoCreateAndStartTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        TaskInfoCreateAndStartTaskResponse self = new TaskInfoCreateAndStartTaskResponse();
        return TeaModel.build(map, self);
    }

    public TaskInfoCreateAndStartTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TaskInfoCreateAndStartTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TaskInfoCreateAndStartTaskResponse setBody(TaskInfoCreateAndStartTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public TaskInfoCreateAndStartTaskResponseBody getBody() {
        return this.body;
    }

}
