// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class CreateTrustGroupResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CreateTrustGroupResponseBody body;

    public static CreateTrustGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateTrustGroupResponse self = new CreateTrustGroupResponse();
        return TeaModel.build(map, self);
    }

    public CreateTrustGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateTrustGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateTrustGroupResponse setBody(CreateTrustGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateTrustGroupResponseBody getBody() {
        return this.body;
    }

}
