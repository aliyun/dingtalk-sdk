// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class FocusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public FocusResponseBody body;

    public static FocusResponse build(java.util.Map<String, ?> map) throws Exception {
        FocusResponse self = new FocusResponse();
        return TeaModel.build(map, self);
    }

    public FocusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public FocusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public FocusResponse setBody(FocusResponseBody body) {
        this.body = body;
        return this;
    }
    public FocusResponseBody getBody() {
        return this.body;
    }

}
