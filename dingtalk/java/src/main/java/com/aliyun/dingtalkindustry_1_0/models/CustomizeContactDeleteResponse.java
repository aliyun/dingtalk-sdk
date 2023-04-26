// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactDeleteResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CustomizeContactDeleteResponseBody body;

    public static CustomizeContactDeleteResponse build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactDeleteResponse self = new CustomizeContactDeleteResponse();
        return TeaModel.build(map, self);
    }

    public CustomizeContactDeleteResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CustomizeContactDeleteResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CustomizeContactDeleteResponse setBody(CustomizeContactDeleteResponseBody body) {
        this.body = body;
        return this;
    }
    public CustomizeContactDeleteResponseBody getBody() {
        return this.body;
    }

}
