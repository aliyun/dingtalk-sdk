// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SetRowHeightResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SetRowHeightResponseBody body;

    public static SetRowHeightResponse build(java.util.Map<String, ?> map) throws Exception {
        SetRowHeightResponse self = new SetRowHeightResponse();
        return TeaModel.build(map, self);
    }

    public SetRowHeightResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SetRowHeightResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SetRowHeightResponse setBody(SetRowHeightResponseBody body) {
        this.body = body;
        return this;
    }
    public SetRowHeightResponseBody getBody() {
        return this.body;
    }

}
