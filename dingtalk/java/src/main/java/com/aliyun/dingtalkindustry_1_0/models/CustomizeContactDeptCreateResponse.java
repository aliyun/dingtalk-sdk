// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactDeptCreateResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CustomizeContactDeptCreateResponseBody body;

    public static CustomizeContactDeptCreateResponse build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactDeptCreateResponse self = new CustomizeContactDeptCreateResponse();
        return TeaModel.build(map, self);
    }

    public CustomizeContactDeptCreateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CustomizeContactDeptCreateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CustomizeContactDeptCreateResponse setBody(CustomizeContactDeptCreateResponseBody body) {
        this.body = body;
        return this;
    }
    public CustomizeContactDeptCreateResponseBody getBody() {
        return this.body;
    }

}
