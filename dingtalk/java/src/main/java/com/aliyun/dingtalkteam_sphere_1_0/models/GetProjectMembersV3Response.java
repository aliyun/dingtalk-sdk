// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class GetProjectMembersV3Response extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetProjectMembersV3ResponseBody body;

    public static GetProjectMembersV3Response build(java.util.Map<String, ?> map) throws Exception {
        GetProjectMembersV3Response self = new GetProjectMembersV3Response();
        return TeaModel.build(map, self);
    }

    public GetProjectMembersV3Response setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetProjectMembersV3Response setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetProjectMembersV3Response setBody(GetProjectMembersV3ResponseBody body) {
        this.body = body;
        return this;
    }
    public GetProjectMembersV3ResponseBody getBody() {
        return this.body;
    }

}
