// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class BindSystemResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BindSystemResponseBody body;

    public static BindSystemResponse build(java.util.Map<String, ?> map) throws Exception {
        BindSystemResponse self = new BindSystemResponse();
        return TeaModel.build(map, self);
    }

    public BindSystemResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BindSystemResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BindSystemResponse setBody(BindSystemResponseBody body) {
        this.body = body;
        return this;
    }
    public BindSystemResponseBody getBody() {
        return this.body;
    }

}
