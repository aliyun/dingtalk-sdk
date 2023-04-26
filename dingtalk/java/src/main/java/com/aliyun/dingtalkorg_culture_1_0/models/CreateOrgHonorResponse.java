// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class CreateOrgHonorResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CreateOrgHonorResponseBody body;

    public static CreateOrgHonorResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateOrgHonorResponse self = new CreateOrgHonorResponse();
        return TeaModel.build(map, self);
    }

    public CreateOrgHonorResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateOrgHonorResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateOrgHonorResponse setBody(CreateOrgHonorResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateOrgHonorResponseBody getBody() {
        return this.body;
    }

}
