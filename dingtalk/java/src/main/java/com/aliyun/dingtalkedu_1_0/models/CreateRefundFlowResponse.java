// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateRefundFlowResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CreateRefundFlowResponseBody body;

    public static CreateRefundFlowResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateRefundFlowResponse self = new CreateRefundFlowResponse();
        return TeaModel.build(map, self);
    }

    public CreateRefundFlowResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateRefundFlowResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateRefundFlowResponse setBody(CreateRefundFlowResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateRefundFlowResponseBody getBody() {
        return this.body;
    }

}
