// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class GetEmployeeRosterByFieldResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetEmployeeRosterByFieldResponseBody body;

    public static GetEmployeeRosterByFieldResponse build(java.util.Map<String, ?> map) throws Exception {
        GetEmployeeRosterByFieldResponse self = new GetEmployeeRosterByFieldResponse();
        return TeaModel.build(map, self);
    }

    public GetEmployeeRosterByFieldResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetEmployeeRosterByFieldResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetEmployeeRosterByFieldResponse setBody(GetEmployeeRosterByFieldResponseBody body) {
        this.body = body;
        return this;
    }
    public GetEmployeeRosterByFieldResponseBody getBody() {
        return this.body;
    }

}
