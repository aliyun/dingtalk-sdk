// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateOrganizationTaskExecutorResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateOrganizationTaskExecutorResponseBody body;

    public static UpdateOrganizationTaskExecutorResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateOrganizationTaskExecutorResponse self = new UpdateOrganizationTaskExecutorResponse();
        return TeaModel.build(map, self);
    }

    public UpdateOrganizationTaskExecutorResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateOrganizationTaskExecutorResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateOrganizationTaskExecutorResponse setBody(UpdateOrganizationTaskExecutorResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateOrganizationTaskExecutorResponseBody getBody() {
        return this.body;
    }

}
