// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactEmpAddResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CustomizeContactEmpAddResponseBody body;

    public static CustomizeContactEmpAddResponse build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactEmpAddResponse self = new CustomizeContactEmpAddResponse();
        return TeaModel.build(map, self);
    }

    public CustomizeContactEmpAddResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CustomizeContactEmpAddResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CustomizeContactEmpAddResponse setBody(CustomizeContactEmpAddResponseBody body) {
        this.body = body;
        return this;
    }
    public CustomizeContactEmpAddResponseBody getBody() {
        return this.body;
    }

}
