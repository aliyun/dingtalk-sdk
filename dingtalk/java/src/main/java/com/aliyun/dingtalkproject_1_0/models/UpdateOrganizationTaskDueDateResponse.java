// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateOrganizationTaskDueDateResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateOrganizationTaskDueDateResponseBody body;

    public static UpdateOrganizationTaskDueDateResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateOrganizationTaskDueDateResponse self = new UpdateOrganizationTaskDueDateResponse();
        return TeaModel.build(map, self);
    }

    public UpdateOrganizationTaskDueDateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateOrganizationTaskDueDateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateOrganizationTaskDueDateResponse setBody(UpdateOrganizationTaskDueDateResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateOrganizationTaskDueDateResponseBody getBody() {
        return this.body;
    }

}
