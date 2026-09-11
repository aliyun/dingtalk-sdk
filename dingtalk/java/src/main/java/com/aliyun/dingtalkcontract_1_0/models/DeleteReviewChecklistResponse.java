// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class DeleteReviewChecklistResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteReviewChecklistResponseBody body;

    public static DeleteReviewChecklistResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteReviewChecklistResponse self = new DeleteReviewChecklistResponse();
        return TeaModel.build(map, self);
    }

    public DeleteReviewChecklistResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteReviewChecklistResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteReviewChecklistResponse setBody(DeleteReviewChecklistResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteReviewChecklistResponseBody getBody() {
        return this.body;
    }

}
