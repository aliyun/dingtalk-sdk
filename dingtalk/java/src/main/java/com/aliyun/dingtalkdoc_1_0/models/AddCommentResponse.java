// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class AddCommentResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddCommentResponseBody body;

    public static AddCommentResponse build(java.util.Map<String, ?> map) throws Exception {
        AddCommentResponse self = new AddCommentResponse();
        return TeaModel.build(map, self);
    }

    public AddCommentResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddCommentResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddCommentResponse setBody(AddCommentResponseBody body) {
        this.body = body;
        return this;
    }
    public AddCommentResponseBody getBody() {
        return this.body;
    }

}
