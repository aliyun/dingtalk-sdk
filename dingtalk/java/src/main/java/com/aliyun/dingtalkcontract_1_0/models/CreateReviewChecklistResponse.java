// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateReviewChecklistResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateReviewChecklistResponseBody body;

    public static CreateReviewChecklistResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateReviewChecklistResponse self = new CreateReviewChecklistResponse();
        return TeaModel.build(map, self);
    }

    public CreateReviewChecklistResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateReviewChecklistResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateReviewChecklistResponse setBody(CreateReviewChecklistResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateReviewChecklistResponseBody getBody() {
        return this.body;
    }

}
