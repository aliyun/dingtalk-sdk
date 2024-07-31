// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class TaskInfoUpdateTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TaskInfoUpdateTaskResponseBody body;

    public static TaskInfoUpdateTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        TaskInfoUpdateTaskResponse self = new TaskInfoUpdateTaskResponse();
        return TeaModel.build(map, self);
    }

    public TaskInfoUpdateTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TaskInfoUpdateTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TaskInfoUpdateTaskResponse setBody(TaskInfoUpdateTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public TaskInfoUpdateTaskResponseBody getBody() {
        return this.body;
    }

}
