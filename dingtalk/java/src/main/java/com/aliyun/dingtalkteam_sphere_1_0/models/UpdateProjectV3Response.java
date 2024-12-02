// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class UpdateProjectV3Response extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateProjectV3ResponseBody body;

    public static UpdateProjectV3Response build(java.util.Map<String, ?> map) throws Exception {
        UpdateProjectV3Response self = new UpdateProjectV3Response();
        return TeaModel.build(map, self);
    }

    public UpdateProjectV3Response setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateProjectV3Response setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateProjectV3Response setBody(UpdateProjectV3ResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateProjectV3ResponseBody getBody() {
        return this.body;
    }

}
