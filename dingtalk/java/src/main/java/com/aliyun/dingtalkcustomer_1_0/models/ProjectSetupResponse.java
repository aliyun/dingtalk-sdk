// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcustomer_1_0.models;

import com.aliyun.tea.*;

public class ProjectSetupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ProjectSetupResponseBody body;

    public static ProjectSetupResponse build(java.util.Map<String, ?> map) throws Exception {
        ProjectSetupResponse self = new ProjectSetupResponse();
        return TeaModel.build(map, self);
    }

    public ProjectSetupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ProjectSetupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ProjectSetupResponse setBody(ProjectSetupResponseBody body) {
        this.body = body;
        return this;
    }
    public ProjectSetupResponseBody getBody() {
        return this.body;
    }

}
