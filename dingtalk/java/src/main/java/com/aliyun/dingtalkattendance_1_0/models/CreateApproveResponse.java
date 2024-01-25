// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class CreateApproveResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public CreateApproveResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateApproveResponse setBody(CreateApproveResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateApproveResponseBody getBody() {
        return this.body;
    }

}
