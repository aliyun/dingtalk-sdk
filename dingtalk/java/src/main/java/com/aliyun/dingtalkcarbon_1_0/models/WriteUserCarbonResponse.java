// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcarbon_1_0.models;

import com.aliyun.tea.*;

public class WriteUserCarbonResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public WriteUserCarbonResponseBody body;

    public static WriteUserCarbonResponse build(java.util.Map<String, ?> map) throws Exception {
        WriteUserCarbonResponse self = new WriteUserCarbonResponse();
        return TeaModel.build(map, self);
    }

    public WriteUserCarbonResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public WriteUserCarbonResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public WriteUserCarbonResponse setBody(WriteUserCarbonResponseBody body) {
        this.body = body;
        return this;
    }
    public WriteUserCarbonResponseBody getBody() {
        return this.body;
    }

}
