// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class ProfessionBenefitConsumeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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
