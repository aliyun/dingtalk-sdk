// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SetColumnsWidthResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SetColumnsWidthResponseBody body;

    public static SetColumnsWidthResponse build(java.util.Map<String, ?> map) throws Exception {
        SetColumnsWidthResponse self = new SetColumnsWidthResponse();
        return TeaModel.build(map, self);
    }

    public SetColumnsWidthResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SetColumnsWidthResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SetColumnsWidthResponse setBody(SetColumnsWidthResponseBody body) {
        this.body = body;
        return this;
    }
    public SetColumnsWidthResponseBody getBody() {
        return this.body;
    }

}
