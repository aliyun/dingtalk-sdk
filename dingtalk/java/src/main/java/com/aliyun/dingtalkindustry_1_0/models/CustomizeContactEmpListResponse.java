// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactEmpListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CustomizeContactEmpListResponseBody body;

    public static CustomizeContactEmpListResponse build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactEmpListResponse self = new CustomizeContactEmpListResponse();
        return TeaModel.build(map, self);
    }

    public CustomizeContactEmpListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CustomizeContactEmpListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CustomizeContactEmpListResponse setBody(CustomizeContactEmpListResponseBody body) {
        this.body = body;
        return this;
    }
    public CustomizeContactEmpListResponseBody getBody() {
        return this.body;
    }

}
