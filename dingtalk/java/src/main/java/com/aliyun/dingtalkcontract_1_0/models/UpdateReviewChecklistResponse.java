// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class UpdateReviewChecklistResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateReviewChecklistResponseBody body;

    public static UpdateReviewChecklistResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateReviewChecklistResponse self = new UpdateReviewChecklistResponse();
        return TeaModel.build(map, self);
    }

    public UpdateReviewChecklistResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateReviewChecklistResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateReviewChecklistResponse setBody(UpdateReviewChecklistResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateReviewChecklistResponseBody getBody() {
        return this.body;
    }

}
