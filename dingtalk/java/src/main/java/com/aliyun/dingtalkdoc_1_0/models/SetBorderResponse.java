// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SetBorderResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SetBorderResponseBody body;

    public static SetBorderResponse build(java.util.Map<String, ?> map) throws Exception {
        SetBorderResponse self = new SetBorderResponse();
        return TeaModel.build(map, self);
    }

    public SetBorderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SetBorderResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SetBorderResponse setBody(SetBorderResponseBody body) {
        this.body = body;
        return this;
    }
    public SetBorderResponseBody getBody() {
        return this.body;
    }

}
