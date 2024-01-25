// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class GetEmployeeInfoByWorkNoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetEmployeeInfoByWorkNoResponseBody body;

    public static GetEmployeeInfoByWorkNoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetEmployeeInfoByWorkNoResponse self = new GetEmployeeInfoByWorkNoResponse();
        return TeaModel.build(map, self);
    }

    public GetEmployeeInfoByWorkNoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetEmployeeInfoByWorkNoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetEmployeeInfoByWorkNoResponse setBody(GetEmployeeInfoByWorkNoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetEmployeeInfoByWorkNoResponseBody getBody() {
        return this.body;
    }

}
