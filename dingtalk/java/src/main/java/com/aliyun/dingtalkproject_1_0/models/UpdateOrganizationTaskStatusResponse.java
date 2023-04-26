// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateOrganizationTaskStatusResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateOrganizationTaskStatusResponseBody body;

    public static UpdateOrganizationTaskStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateOrganizationTaskStatusResponse self = new UpdateOrganizationTaskStatusResponse();
        return TeaModel.build(map, self);
    }

    public UpdateOrganizationTaskStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateOrganizationTaskStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateOrganizationTaskStatusResponse setBody(UpdateOrganizationTaskStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateOrganizationTaskStatusResponseBody getBody() {
        return this.body;
    }

}
