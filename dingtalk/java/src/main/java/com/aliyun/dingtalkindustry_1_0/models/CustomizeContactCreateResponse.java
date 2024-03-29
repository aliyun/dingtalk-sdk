// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactCreateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CustomizeContactCreateResponseBody body;

    public static CustomizeContactCreateResponse build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactCreateResponse self = new CustomizeContactCreateResponse();
        return TeaModel.build(map, self);
    }

    public CustomizeContactCreateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CustomizeContactCreateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CustomizeContactCreateResponse setBody(CustomizeContactCreateResponseBody body) {
        this.body = body;
        return this;
    }
    public CustomizeContactCreateResponseBody getBody() {
        return this.body;
    }

}
