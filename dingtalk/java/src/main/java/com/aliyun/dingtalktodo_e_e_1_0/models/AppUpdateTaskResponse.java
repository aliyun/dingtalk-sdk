// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class AppUpdateTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AppUpdateTaskResponseBody body;

    public static AppUpdateTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        AppUpdateTaskResponse self = new AppUpdateTaskResponse();
        return TeaModel.build(map, self);
    }

    public AppUpdateTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AppUpdateTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AppUpdateTaskResponse setBody(AppUpdateTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public AppUpdateTaskResponseBody getBody() {
        return this.body;
    }

}
