// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class GetResidentDeptResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetResidentDeptResponseBody body;

    public static GetResidentDeptResponse build(java.util.Map<String, ?> map) throws Exception {
        GetResidentDeptResponse self = new GetResidentDeptResponse();
        return TeaModel.build(map, self);
    }

    public GetResidentDeptResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetResidentDeptResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetResidentDeptResponse setBody(GetResidentDeptResponseBody body) {
        this.body = body;
        return this;
    }
    public GetResidentDeptResponseBody getBody() {
        return this.body;
    }

}
