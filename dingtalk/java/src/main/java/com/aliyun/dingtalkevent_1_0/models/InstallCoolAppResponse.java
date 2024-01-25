// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkevent_1_0.models;

import com.aliyun.tea.*;

public class InstallCoolAppResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public InstallCoolAppResponseBody body;

    public static InstallCoolAppResponse build(java.util.Map<String, ?> map) throws Exception {
        InstallCoolAppResponse self = new InstallCoolAppResponse();
        return TeaModel.build(map, self);
    }

    public InstallCoolAppResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public InstallCoolAppResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public InstallCoolAppResponse setBody(InstallCoolAppResponseBody body) {
        this.body = body;
        return this;
    }
    public InstallCoolAppResponseBody getBody() {
        return this.body;
    }

}
