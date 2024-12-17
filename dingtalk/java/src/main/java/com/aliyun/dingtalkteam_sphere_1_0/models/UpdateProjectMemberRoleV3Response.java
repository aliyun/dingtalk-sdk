// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class UpdateProjectMemberRoleV3Response extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateProjectMemberRoleV3ResponseBody body;

    public static UpdateProjectMemberRoleV3Response build(java.util.Map<String, ?> map) throws Exception {
        UpdateProjectMemberRoleV3Response self = new UpdateProjectMemberRoleV3Response();
        return TeaModel.build(map, self);
    }

    public UpdateProjectMemberRoleV3Response setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateProjectMemberRoleV3Response setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateProjectMemberRoleV3Response setBody(UpdateProjectMemberRoleV3ResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateProjectMemberRoleV3ResponseBody getBody() {
        return this.body;
    }

}
