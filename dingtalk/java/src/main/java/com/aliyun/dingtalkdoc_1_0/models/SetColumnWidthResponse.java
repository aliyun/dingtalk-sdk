// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SetColumnWidthResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public SetColumnWidthResponseBody body;

    public static SetColumnWidthResponse build(java.util.Map<String, ?> map) throws Exception {
        SetColumnWidthResponse self = new SetColumnWidthResponse();
        return TeaModel.build(map, self);
    }

    public SetColumnWidthResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SetColumnWidthResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SetColumnWidthResponse setBody(SetColumnWidthResponseBody body) {
        this.body = body;
        return this;
    }
    public SetColumnWidthResponseBody getBody() {
        return this.body;
    }

}
