// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreateOrganizationTaskResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CreateOrganizationTaskResponseBody body;

    public static CreateOrganizationTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateOrganizationTaskResponse self = new CreateOrganizationTaskResponse();
        return TeaModel.build(map, self);
    }

    public CreateOrganizationTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateOrganizationTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateOrganizationTaskResponse setBody(CreateOrganizationTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateOrganizationTaskResponseBody getBody() {
        return this.body;
    }

}
