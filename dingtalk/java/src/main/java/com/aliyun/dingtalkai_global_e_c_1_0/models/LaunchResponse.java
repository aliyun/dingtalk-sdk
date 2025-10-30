// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_global_e_c_1_0.models;

import com.aliyun.tea.*;

public class LaunchResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public LaunchResponseBody body;

    public static LaunchResponse build(java.util.Map<String, ?> map) throws Exception {
        LaunchResponse self = new LaunchResponse();
        return TeaModel.build(map, self);
    }

    public LaunchResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public LaunchResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public LaunchResponse setBody(LaunchResponseBody body) {
        this.body = body;
        return this;
    }
    public LaunchResponseBody getBody() {
        return this.body;
    }

}
