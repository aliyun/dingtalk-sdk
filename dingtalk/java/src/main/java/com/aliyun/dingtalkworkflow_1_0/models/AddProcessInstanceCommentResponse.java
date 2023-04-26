// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class AddProcessInstanceCommentResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public AddProcessInstanceCommentResponseBody body;

    public static AddProcessInstanceCommentResponse build(java.util.Map<String, ?> map) throws Exception {
        AddProcessInstanceCommentResponse self = new AddProcessInstanceCommentResponse();
        return TeaModel.build(map, self);
    }

    public AddProcessInstanceCommentResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddProcessInstanceCommentResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddProcessInstanceCommentResponse setBody(AddProcessInstanceCommentResponseBody body) {
        this.body = body;
        return this;
    }
    public AddProcessInstanceCommentResponseBody getBody() {
        return this.body;
    }

}
