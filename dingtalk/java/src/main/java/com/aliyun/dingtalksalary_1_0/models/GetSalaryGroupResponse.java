// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksalary_1_0.models;

import com.aliyun.tea.*;

public class GetSalaryGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetSalaryGroupResponseBody body;

    public static GetSalaryGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSalaryGroupResponse self = new GetSalaryGroupResponse();
        return TeaModel.build(map, self);
    }

    public GetSalaryGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSalaryGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSalaryGroupResponse setBody(GetSalaryGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSalaryGroupResponseBody getBody() {
        return this.body;
    }

}
