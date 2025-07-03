// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksalary_1_0.models;

import com.aliyun.tea.*;

public class ListSalaryCalculationResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListSalaryCalculationResponseBody body;

    public static ListSalaryCalculationResponse build(java.util.Map<String, ?> map) throws Exception {
        ListSalaryCalculationResponse self = new ListSalaryCalculationResponse();
        return TeaModel.build(map, self);
    }

    public ListSalaryCalculationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListSalaryCalculationResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListSalaryCalculationResponse setBody(ListSalaryCalculationResponseBody body) {
        this.body = body;
        return this;
    }
    public ListSalaryCalculationResponseBody getBody() {
        return this.body;
    }

}
