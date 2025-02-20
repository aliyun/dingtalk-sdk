// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SetRowsHeightResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SetRowsHeightResponseBody body;

    public static SetRowsHeightResponse build(java.util.Map<String, ?> map) throws Exception {
        SetRowsHeightResponse self = new SetRowsHeightResponse();
        return TeaModel.build(map, self);
    }

    public SetRowsHeightResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SetRowsHeightResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SetRowsHeightResponse setBody(SetRowsHeightResponseBody body) {
        this.body = body;
        return this;
    }
    public SetRowsHeightResponseBody getBody() {
        return this.body;
    }

}
