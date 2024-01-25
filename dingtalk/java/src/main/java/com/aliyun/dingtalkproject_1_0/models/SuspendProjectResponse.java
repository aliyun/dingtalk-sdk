// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SuspendProjectResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SuspendProjectResponseBody body;

    public static SuspendProjectResponse build(java.util.Map<String, ?> map) throws Exception {
        SuspendProjectResponse self = new SuspendProjectResponse();
        return TeaModel.build(map, self);
    }

    public SuspendProjectResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SuspendProjectResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SuspendProjectResponse setBody(SuspendProjectResponseBody body) {
        this.body = body;
        return this;
    }
    public SuspendProjectResponseBody getBody() {
        return this.body;
    }

}
