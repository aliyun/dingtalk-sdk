// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class AddConvNavTabResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddConvNavTabResponseBody body;

    public static AddConvNavTabResponse build(java.util.Map<String, ?> map) throws Exception {
        AddConvNavTabResponse self = new AddConvNavTabResponse();
        return TeaModel.build(map, self);
    }

    public AddConvNavTabResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddConvNavTabResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddConvNavTabResponse setBody(AddConvNavTabResponseBody body) {
        this.body = body;
        return this;
    }
    public AddConvNavTabResponseBody getBody() {
        return this.body;
    }

}
