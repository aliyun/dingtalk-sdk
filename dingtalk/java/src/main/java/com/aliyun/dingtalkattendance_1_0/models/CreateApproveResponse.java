// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class CreateApproveResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateApproveResponseBody body;

    public static CreateApproveResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateApproveResponse self = new CreateApproveResponse();
        return TeaModel.build(map, self);
    }

    public CreateApproveResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateApproveResponse setBody(CreateApproveResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateApproveResponseBody getBody() {
        return this.body;
    }

}
