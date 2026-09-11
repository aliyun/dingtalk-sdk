// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class ConfirmContractReviewResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ConfirmContractReviewResponseBody body;

    public static ConfirmContractReviewResponse build(java.util.Map<String, ?> map) throws Exception {
        ConfirmContractReviewResponse self = new ConfirmContractReviewResponse();
        return TeaModel.build(map, self);
    }

    public ConfirmContractReviewResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ConfirmContractReviewResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ConfirmContractReviewResponse setBody(ConfirmContractReviewResponseBody body) {
        this.body = body;
        return this;
    }
    public ConfirmContractReviewResponseBody getBody() {
        return this.body;
    }

}
