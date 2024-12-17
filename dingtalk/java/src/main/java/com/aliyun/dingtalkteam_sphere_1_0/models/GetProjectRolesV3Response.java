// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class GetProjectRolesV3Response extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetProjectRolesV3ResponseBody body;

    public static GetProjectRolesV3Response build(java.util.Map<String, ?> map) throws Exception {
        GetProjectRolesV3Response self = new GetProjectRolesV3Response();
        return TeaModel.build(map, self);
    }

    public GetProjectRolesV3Response setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetProjectRolesV3Response setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetProjectRolesV3Response setBody(GetProjectRolesV3ResponseBody body) {
        this.body = body;
        return this;
    }
    public GetProjectRolesV3ResponseBody getBody() {
        return this.body;
    }

}
