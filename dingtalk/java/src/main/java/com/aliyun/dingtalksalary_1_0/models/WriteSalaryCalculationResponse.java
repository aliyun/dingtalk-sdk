// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksalary_1_0.models;

import com.aliyun.tea.*;

public class WriteSalaryCalculationResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public WriteSalaryCalculationResponseBody body;

    public static WriteSalaryCalculationResponse build(java.util.Map<String, ?> map) throws Exception {
        WriteSalaryCalculationResponse self = new WriteSalaryCalculationResponse();
        return TeaModel.build(map, self);
    }

    public WriteSalaryCalculationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public WriteSalaryCalculationResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public WriteSalaryCalculationResponse setBody(WriteSalaryCalculationResponseBody body) {
        this.body = body;
        return this;
    }
    public WriteSalaryCalculationResponseBody getBody() {
        return this.body;
    }

}
