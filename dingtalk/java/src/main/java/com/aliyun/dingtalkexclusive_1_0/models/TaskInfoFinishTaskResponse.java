// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class TaskInfoFinishTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TaskInfoFinishTaskResponseBody body;

    public static TaskInfoFinishTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        TaskInfoFinishTaskResponse self = new TaskInfoFinishTaskResponse();
        return TeaModel.build(map, self);
    }

    public TaskInfoFinishTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TaskInfoFinishTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TaskInfoFinishTaskResponse setBody(TaskInfoFinishTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public TaskInfoFinishTaskResponseBody getBody() {
        return this.body;
    }

}
