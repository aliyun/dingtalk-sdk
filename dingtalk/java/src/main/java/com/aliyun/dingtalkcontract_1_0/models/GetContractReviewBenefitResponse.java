// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class GetContractReviewBenefitResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetContractReviewBenefitResponseBody body;

    public static GetContractReviewBenefitResponse build(java.util.Map<String, ?> map) throws Exception {
        GetContractReviewBenefitResponse self = new GetContractReviewBenefitResponse();
        return TeaModel.build(map, self);
    }

    public GetContractReviewBenefitResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetContractReviewBenefitResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetContractReviewBenefitResponse setBody(GetContractReviewBenefitResponseBody body) {
        this.body = body;
        return this;
    }
    public GetContractReviewBenefitResponseBody getBody() {
        return this.body;
    }

}
