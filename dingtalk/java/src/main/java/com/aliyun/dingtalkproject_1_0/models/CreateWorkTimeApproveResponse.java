// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreateWorkTimeApproveResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CreateWorkTimeApproveResponseBody body;

    public static CreateWorkTimeApproveResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateWorkTimeApproveResponse self = new CreateWorkTimeApproveResponse();
        return TeaModel.build(map, self);
    }

    public CreateWorkTimeApproveResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateWorkTimeApproveResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateWorkTimeApproveResponse setBody(CreateWorkTimeApproveResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateWorkTimeApproveResponseBody getBody() {
        return this.body;
    }

}
