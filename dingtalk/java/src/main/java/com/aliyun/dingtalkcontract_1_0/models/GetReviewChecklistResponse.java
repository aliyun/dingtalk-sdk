// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class GetReviewChecklistResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetReviewChecklistResponseBody body;

    public static GetReviewChecklistResponse build(java.util.Map<String, ?> map) throws Exception {
        GetReviewChecklistResponse self = new GetReviewChecklistResponse();
        return TeaModel.build(map, self);
    }

    public GetReviewChecklistResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetReviewChecklistResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetReviewChecklistResponse setBody(GetReviewChecklistResponseBody body) {
        this.body = body;
        return this;
    }
    public GetReviewChecklistResponseBody getBody() {
        return this.body;
    }

}
