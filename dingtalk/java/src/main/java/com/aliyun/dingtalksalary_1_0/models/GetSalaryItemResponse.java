// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksalary_1_0.models;

import com.aliyun.tea.*;

public class GetSalaryItemResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetSalaryItemResponseBody body;

    public static GetSalaryItemResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSalaryItemResponse self = new GetSalaryItemResponse();
        return TeaModel.build(map, self);
    }

    public GetSalaryItemResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSalaryItemResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSalaryItemResponse setBody(GetSalaryItemResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSalaryItemResponseBody getBody() {
        return this.body;
    }

}
