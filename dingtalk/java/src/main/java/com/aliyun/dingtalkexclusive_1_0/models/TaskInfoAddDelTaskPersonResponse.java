// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class TaskInfoAddDelTaskPersonResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TaskInfoAddDelTaskPersonResponseBody body;

    public static TaskInfoAddDelTaskPersonResponse build(java.util.Map<String, ?> map) throws Exception {
        TaskInfoAddDelTaskPersonResponse self = new TaskInfoAddDelTaskPersonResponse();
        return TeaModel.build(map, self);
    }

    public TaskInfoAddDelTaskPersonResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TaskInfoAddDelTaskPersonResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TaskInfoAddDelTaskPersonResponse setBody(TaskInfoAddDelTaskPersonResponseBody body) {
        this.body = body;
        return this;
    }
    public TaskInfoAddDelTaskPersonResponseBody getBody() {
        return this.body;
    }

}
