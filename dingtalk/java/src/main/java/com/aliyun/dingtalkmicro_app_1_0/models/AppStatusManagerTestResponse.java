// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class AppStatusManagerTestResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AppStatusManagerTestResponseBody body;

    public static AppStatusManagerTestResponse build(java.util.Map<String, ?> map) throws Exception {
        AppStatusManagerTestResponse self = new AppStatusManagerTestResponse();
        return TeaModel.build(map, self);
    }

    public AppStatusManagerTestResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AppStatusManagerTestResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AppStatusManagerTestResponse setBody(AppStatusManagerTestResponseBody body) {
        this.body = body;
        return this;
    }
    public AppStatusManagerTestResponseBody getBody() {
        return this.body;
    }

}
