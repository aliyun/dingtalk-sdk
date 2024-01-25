// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactUpdateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CustomizeContactUpdateResponseBody body;

    public static CustomizeContactUpdateResponse build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactUpdateResponse self = new CustomizeContactUpdateResponse();
        return TeaModel.build(map, self);
    }

    public CustomizeContactUpdateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CustomizeContactUpdateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CustomizeContactUpdateResponse setBody(CustomizeContactUpdateResponseBody body) {
        this.body = body;
        return this;
    }
    public CustomizeContactUpdateResponseBody getBody() {
        return this.body;
    }

}
