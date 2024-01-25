// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class ExecuteProcessInstanceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ExecuteProcessInstanceResponseBody body;

    public static ExecuteProcessInstanceResponse build(java.util.Map<String, ?> map) throws Exception {
        ExecuteProcessInstanceResponse self = new ExecuteProcessInstanceResponse();
        return TeaModel.build(map, self);
    }

    public ExecuteProcessInstanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ExecuteProcessInstanceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ExecuteProcessInstanceResponse setBody(ExecuteProcessInstanceResponseBody body) {
        this.body = body;
        return this;
    }
    public ExecuteProcessInstanceResponseBody getBody() {
        return this.body;
    }

}
