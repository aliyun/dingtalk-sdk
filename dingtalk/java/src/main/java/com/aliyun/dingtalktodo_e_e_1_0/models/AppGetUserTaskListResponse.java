// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class AppGetUserTaskListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AppGetUserTaskListResponseBody body;

    public static AppGetUserTaskListResponse build(java.util.Map<String, ?> map) throws Exception {
        AppGetUserTaskListResponse self = new AppGetUserTaskListResponse();
        return TeaModel.build(map, self);
    }

    public AppGetUserTaskListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AppGetUserTaskListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AppGetUserTaskListResponse setBody(AppGetUserTaskListResponseBody body) {
        this.body = body;
        return this;
    }
    public AppGetUserTaskListResponseBody getBody() {
        return this.body;
    }

}
