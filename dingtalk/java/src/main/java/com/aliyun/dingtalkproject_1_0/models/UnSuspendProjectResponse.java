// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UnSuspendProjectResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UnSuspendProjectResponseBody body;

    public static UnSuspendProjectResponse build(java.util.Map<String, ?> map) throws Exception {
        UnSuspendProjectResponse self = new UnSuspendProjectResponse();
        return TeaModel.build(map, self);
    }

    public UnSuspendProjectResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UnSuspendProjectResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UnSuspendProjectResponse setBody(UnSuspendProjectResponseBody body) {
        this.body = body;
        return this;
    }
    public UnSuspendProjectResponseBody getBody() {
        return this.body;
    }

}
