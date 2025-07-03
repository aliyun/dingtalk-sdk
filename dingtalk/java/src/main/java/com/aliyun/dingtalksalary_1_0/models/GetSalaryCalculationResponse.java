// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksalary_1_0.models;

import com.aliyun.tea.*;

public class GetSalaryCalculationResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetSalaryCalculationResponseBody body;

    public static GetSalaryCalculationResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSalaryCalculationResponse self = new GetSalaryCalculationResponse();
        return TeaModel.build(map, self);
    }

    public GetSalaryCalculationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSalaryCalculationResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSalaryCalculationResponse setBody(GetSalaryCalculationResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSalaryCalculationResponseBody getBody() {
        return this.body;
    }

}
