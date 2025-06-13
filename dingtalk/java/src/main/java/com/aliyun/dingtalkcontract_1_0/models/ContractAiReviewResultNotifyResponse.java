// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class ContractAiReviewResultNotifyResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ContractAiReviewResultNotifyResponseBody body;

    public static ContractAiReviewResultNotifyResponse build(java.util.Map<String, ?> map) throws Exception {
        ContractAiReviewResultNotifyResponse self = new ContractAiReviewResultNotifyResponse();
        return TeaModel.build(map, self);
    }

    public ContractAiReviewResultNotifyResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ContractAiReviewResultNotifyResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ContractAiReviewResultNotifyResponse setBody(ContractAiReviewResultNotifyResponseBody body) {
        this.body = body;
        return this;
    }
    public ContractAiReviewResultNotifyResponseBody getBody() {
        return this.body;
    }

}
