// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class GetUserJoinedProjectsV3Response extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetUserJoinedProjectsV3ResponseBody body;

    public static GetUserJoinedProjectsV3Response build(java.util.Map<String, ?> map) throws Exception {
        GetUserJoinedProjectsV3Response self = new GetUserJoinedProjectsV3Response();
        return TeaModel.build(map, self);
    }

    public GetUserJoinedProjectsV3Response setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetUserJoinedProjectsV3Response setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetUserJoinedProjectsV3Response setBody(GetUserJoinedProjectsV3ResponseBody body) {
        this.body = body;
        return this;
    }
    public GetUserJoinedProjectsV3ResponseBody getBody() {
        return this.body;
    }

}
