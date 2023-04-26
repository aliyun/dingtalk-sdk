// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateOrganizationTaskPriorityResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateOrganizationTaskPriorityResponseBody body;

    public static UpdateOrganizationTaskPriorityResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateOrganizationTaskPriorityResponse self = new UpdateOrganizationTaskPriorityResponse();
        return TeaModel.build(map, self);
    }

    public UpdateOrganizationTaskPriorityResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateOrganizationTaskPriorityResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateOrganizationTaskPriorityResponse setBody(UpdateOrganizationTaskPriorityResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateOrganizationTaskPriorityResponseBody getBody() {
        return this.body;
    }

}
