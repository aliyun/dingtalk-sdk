// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CancelContractReviewResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CancelContractReviewResponseBody body;

    public static CancelContractReviewResponse build(java.util.Map<String, ?> map) throws Exception {
        CancelContractReviewResponse self = new CancelContractReviewResponse();
        return TeaModel.build(map, self);
    }

    public CancelContractReviewResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CancelContractReviewResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CancelContractReviewResponse setBody(CancelContractReviewResponseBody body) {
        this.body = body;
        return this;
    }
    public CancelContractReviewResponseBody getBody() {
        return this.body;
    }

}
