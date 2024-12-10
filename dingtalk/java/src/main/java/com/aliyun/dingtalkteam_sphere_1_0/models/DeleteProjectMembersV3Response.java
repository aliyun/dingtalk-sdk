// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class DeleteProjectMembersV3Response extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteProjectMembersV3ResponseBody body;

    public static DeleteProjectMembersV3Response build(java.util.Map<String, ?> map) throws Exception {
        DeleteProjectMembersV3Response self = new DeleteProjectMembersV3Response();
        return TeaModel.build(map, self);
    }

    public DeleteProjectMembersV3Response setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteProjectMembersV3Response setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteProjectMembersV3Response setBody(DeleteProjectMembersV3ResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteProjectMembersV3ResponseBody getBody() {
        return this.body;
    }

}
