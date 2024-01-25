// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateOrganizationTaskInvolveMembersResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateOrganizationTaskInvolveMembersResponseBody body;

    public static UpdateOrganizationTaskInvolveMembersResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateOrganizationTaskInvolveMembersResponse self = new UpdateOrganizationTaskInvolveMembersResponse();
        return TeaModel.build(map, self);
    }

    public UpdateOrganizationTaskInvolveMembersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateOrganizationTaskInvolveMembersResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateOrganizationTaskInvolveMembersResponse setBody(UpdateOrganizationTaskInvolveMembersResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateOrganizationTaskInvolveMembersResponseBody getBody() {
        return this.body;
    }

}
