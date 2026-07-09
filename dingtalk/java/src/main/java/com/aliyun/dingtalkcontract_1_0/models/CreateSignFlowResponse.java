// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateSignFlowResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateSignFlowResponseBody body;

    public static CreateSignFlowResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateSignFlowResponse self = new CreateSignFlowResponse();
        return TeaModel.build(map, self);
    }

    public CreateSignFlowResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateSignFlowResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateSignFlowResponse setBody(CreateSignFlowResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateSignFlowResponseBody getBody() {
        return this.body;
    }

}
