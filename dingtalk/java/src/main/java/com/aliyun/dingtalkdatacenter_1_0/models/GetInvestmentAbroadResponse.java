// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetInvestmentAbroadResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetInvestmentAbroadResponseBody body;

    public static GetInvestmentAbroadResponse build(java.util.Map<String, ?> map) throws Exception {
        GetInvestmentAbroadResponse self = new GetInvestmentAbroadResponse();
        return TeaModel.build(map, self);
    }

    public GetInvestmentAbroadResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetInvestmentAbroadResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetInvestmentAbroadResponse setBody(GetInvestmentAbroadResponseBody body) {
        this.body = body;
        return this;
    }
    public GetInvestmentAbroadResponseBody getBody() {
        return this.body;
    }

}
