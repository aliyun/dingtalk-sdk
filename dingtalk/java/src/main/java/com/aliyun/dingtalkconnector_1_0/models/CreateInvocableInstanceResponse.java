// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class CreateInvocableInstanceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateInvocableInstanceResponseBody body;

    public static CreateInvocableInstanceResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateInvocableInstanceResponse self = new CreateInvocableInstanceResponse();
        return TeaModel.build(map, self);
    }

    public CreateInvocableInstanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateInvocableInstanceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateInvocableInstanceResponse setBody(CreateInvocableInstanceResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateInvocableInstanceResponseBody getBody() {
        return this.body;
    }

}
