// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class CreateProjectMembersV3Response extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateProjectMembersV3ResponseBody body;

    public static CreateProjectMembersV3Response build(java.util.Map<String, ?> map) throws Exception {
        CreateProjectMembersV3Response self = new CreateProjectMembersV3Response();
        return TeaModel.build(map, self);
    }

    public CreateProjectMembersV3Response setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateProjectMembersV3Response setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateProjectMembersV3Response setBody(CreateProjectMembersV3ResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateProjectMembersV3ResponseBody getBody() {
        return this.body;
    }

}
