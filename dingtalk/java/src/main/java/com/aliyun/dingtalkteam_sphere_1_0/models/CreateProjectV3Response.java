// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class CreateProjectV3Response extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateProjectV3ResponseBody body;

    public static CreateProjectV3Response build(java.util.Map<String, ?> map) throws Exception {
        CreateProjectV3Response self = new CreateProjectV3Response();
        return TeaModel.build(map, self);
    }

    public CreateProjectV3Response setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateProjectV3Response setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateProjectV3Response setBody(CreateProjectV3ResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateProjectV3ResponseBody getBody() {
        return this.body;
    }

}
