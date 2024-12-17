// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class AppUpdateUserTaskStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AppUpdateUserTaskStatusResponseBody body;

    public static AppUpdateUserTaskStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        AppUpdateUserTaskStatusResponse self = new AppUpdateUserTaskStatusResponse();
        return TeaModel.build(map, self);
    }

    public AppUpdateUserTaskStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AppUpdateUserTaskStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AppUpdateUserTaskStatusResponse setBody(AppUpdateUserTaskStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public AppUpdateUserTaskStatusResponseBody getBody() {
        return this.body;
    }

}
