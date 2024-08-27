// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumQueryTodoTasksByManagerResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PremiumQueryTodoTasksByManagerResponseBody body;

    public static PremiumQueryTodoTasksByManagerResponse build(java.util.Map<String, ?> map) throws Exception {
        PremiumQueryTodoTasksByManagerResponse self = new PremiumQueryTodoTasksByManagerResponse();
        return TeaModel.build(map, self);
    }

    public PremiumQueryTodoTasksByManagerResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PremiumQueryTodoTasksByManagerResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PremiumQueryTodoTasksByManagerResponse setBody(PremiumQueryTodoTasksByManagerResponseBody body) {
        this.body = body;
        return this;
    }
    public PremiumQueryTodoTasksByManagerResponseBody getBody() {
        return this.body;
    }

}
