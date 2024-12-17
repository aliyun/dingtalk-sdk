// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class AppCreateEnterpriseTodoTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AppCreateEnterpriseTodoTaskResponseBody body;

    public static AppCreateEnterpriseTodoTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        AppCreateEnterpriseTodoTaskResponse self = new AppCreateEnterpriseTodoTaskResponse();
        return TeaModel.build(map, self);
    }

    public AppCreateEnterpriseTodoTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AppCreateEnterpriseTodoTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AppCreateEnterpriseTodoTaskResponse setBody(AppCreateEnterpriseTodoTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public AppCreateEnterpriseTodoTaskResponseBody getBody() {
        return this.body;
    }

}
