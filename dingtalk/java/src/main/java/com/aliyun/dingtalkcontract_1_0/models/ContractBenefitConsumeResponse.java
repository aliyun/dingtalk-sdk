// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class ContractBenefitConsumeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ContractBenefitConsumeResponseBody body;

    public static ContractBenefitConsumeResponse build(java.util.Map<String, ?> map) throws Exception {
        ContractBenefitConsumeResponse self = new ContractBenefitConsumeResponse();
        return TeaModel.build(map, self);
    }

    public ContractBenefitConsumeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ContractBenefitConsumeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ContractBenefitConsumeResponse setBody(ContractBenefitConsumeResponseBody body) {
        this.body = body;
        return this;
    }
    public ContractBenefitConsumeResponseBody getBody() {
        return this.body;
    }

}
