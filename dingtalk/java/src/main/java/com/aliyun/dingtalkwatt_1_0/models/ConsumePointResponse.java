// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwatt_1_0.models;

import com.aliyun.tea.*;

public class ConsumePointResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ConsumePointResponseBody body;

    public static ConsumePointResponse build(java.util.Map<String, ?> map) throws Exception {
        ConsumePointResponse self = new ConsumePointResponse();
        return TeaModel.build(map, self);
    }

    public ConsumePointResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ConsumePointResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ConsumePointResponse setBody(ConsumePointResponseBody body) {
        this.body = body;
        return this;
    }
    public ConsumePointResponseBody getBody() {
        return this.body;
    }

}
