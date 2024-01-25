// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactEmpDeleteResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CustomizeContactEmpDeleteResponseBody body;

    public static CustomizeContactEmpDeleteResponse build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactEmpDeleteResponse self = new CustomizeContactEmpDeleteResponse();
        return TeaModel.build(map, self);
    }

    public CustomizeContactEmpDeleteResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CustomizeContactEmpDeleteResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CustomizeContactEmpDeleteResponse setBody(CustomizeContactEmpDeleteResponseBody body) {
        this.body = body;
        return this;
    }
    public CustomizeContactEmpDeleteResponseBody getBody() {
        return this.body;
    }

}
