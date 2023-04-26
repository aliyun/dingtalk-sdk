// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactDeptInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CustomizeContactDeptInfoResponseBody body;

    public static CustomizeContactDeptInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactDeptInfoResponse self = new CustomizeContactDeptInfoResponse();
        return TeaModel.build(map, self);
    }

    public CustomizeContactDeptInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CustomizeContactDeptInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CustomizeContactDeptInfoResponse setBody(CustomizeContactDeptInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public CustomizeContactDeptInfoResponseBody getBody() {
        return this.body;
    }

}
