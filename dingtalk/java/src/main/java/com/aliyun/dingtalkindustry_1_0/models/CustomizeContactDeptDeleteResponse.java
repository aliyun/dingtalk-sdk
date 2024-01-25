// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactDeptDeleteResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CustomizeContactDeptDeleteResponseBody body;

    public static CustomizeContactDeptDeleteResponse build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactDeptDeleteResponse self = new CustomizeContactDeptDeleteResponse();
        return TeaModel.build(map, self);
    }

    public CustomizeContactDeptDeleteResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CustomizeContactDeptDeleteResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CustomizeContactDeptDeleteResponse setBody(CustomizeContactDeptDeleteResponseBody body) {
        this.body = body;
        return this;
    }
    public CustomizeContactDeptDeleteResponseBody getBody() {
        return this.body;
    }

}
