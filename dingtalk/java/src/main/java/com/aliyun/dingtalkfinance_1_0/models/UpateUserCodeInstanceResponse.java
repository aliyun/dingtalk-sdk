// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class UpateUserCodeInstanceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpateUserCodeInstanceResponseBody body;

    public static UpateUserCodeInstanceResponse build(java.util.Map<String, ?> map) throws Exception {
        UpateUserCodeInstanceResponse self = new UpateUserCodeInstanceResponse();
        return TeaModel.build(map, self);
    }

    public UpateUserCodeInstanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpateUserCodeInstanceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpateUserCodeInstanceResponse setBody(UpateUserCodeInstanceResponseBody body) {
        this.body = body;
        return this;
    }
    public UpateUserCodeInstanceResponseBody getBody() {
        return this.body;
    }

}
