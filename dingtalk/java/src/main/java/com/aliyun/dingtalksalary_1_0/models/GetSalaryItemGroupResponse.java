// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksalary_1_0.models;

import com.aliyun.tea.*;

public class GetSalaryItemGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetSalaryItemGroupResponseBody body;

    public static GetSalaryItemGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSalaryItemGroupResponse self = new GetSalaryItemGroupResponse();
        return TeaModel.build(map, self);
    }

    public GetSalaryItemGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSalaryItemGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSalaryItemGroupResponse setBody(GetSalaryItemGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSalaryItemGroupResponseBody getBody() {
        return this.body;
    }

}
