// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class InstallAppResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public InstallAppResponseBody body;

    public static InstallAppResponse build(java.util.Map<String, ?> map) throws Exception {
        InstallAppResponse self = new InstallAppResponse();
        return TeaModel.build(map, self);
    }

    public InstallAppResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public InstallAppResponse setBody(InstallAppResponseBody body) {
        this.body = body;
        return this;
    }
    public InstallAppResponseBody getBody() {
        return this.body;
    }

}
