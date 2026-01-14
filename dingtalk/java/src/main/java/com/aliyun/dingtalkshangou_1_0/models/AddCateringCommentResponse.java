// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkshangou_1_0.models;

import com.aliyun.tea.*;

public class AddCateringCommentResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddCateringCommentResponseBody body;

    public static AddCateringCommentResponse build(java.util.Map<String, ?> map) throws Exception {
        AddCateringCommentResponse self = new AddCateringCommentResponse();
        return TeaModel.build(map, self);
    }

    public AddCateringCommentResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddCateringCommentResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddCateringCommentResponse setBody(AddCateringCommentResponseBody body) {
        this.body = body;
        return this;
    }
    public AddCateringCommentResponseBody getBody() {
        return this.body;
    }

}
