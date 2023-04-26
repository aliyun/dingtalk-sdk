// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class ProfessionBenefitConsumeResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ProfessionBenefitConsumeResponseBody body;

    public static ProfessionBenefitConsumeResponse build(java.util.Map<String, ?> map) throws Exception {
        ProfessionBenefitConsumeResponse self = new ProfessionBenefitConsumeResponse();
        return TeaModel.build(map, self);
    }

    public ProfessionBenefitConsumeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ProfessionBenefitConsumeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ProfessionBenefitConsumeResponse setBody(ProfessionBenefitConsumeResponseBody body) {
        this.body = body;
        return this;
    }
    public ProfessionBenefitConsumeResponseBody getBody() {
        return this.body;
    }

}
