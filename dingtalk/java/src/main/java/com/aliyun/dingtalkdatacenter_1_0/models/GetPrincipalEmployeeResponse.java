// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetPrincipalEmployeeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetPrincipalEmployeeResponseBody body;

    public static GetPrincipalEmployeeResponse build(java.util.Map<String, ?> map) throws Exception {
        GetPrincipalEmployeeResponse self = new GetPrincipalEmployeeResponse();
        return TeaModel.build(map, self);
    }

    public GetPrincipalEmployeeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetPrincipalEmployeeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetPrincipalEmployeeResponse setBody(GetPrincipalEmployeeResponseBody body) {
        this.body = body;
        return this;
    }
    public GetPrincipalEmployeeResponseBody getBody() {
        return this.body;
    }

}
