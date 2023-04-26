// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SaveWhiteAppResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public SaveWhiteAppResponseBody body;

    public static SaveWhiteAppResponse build(java.util.Map<String, ?> map) throws Exception {
        SaveWhiteAppResponse self = new SaveWhiteAppResponse();
        return TeaModel.build(map, self);
    }

    public SaveWhiteAppResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SaveWhiteAppResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SaveWhiteAppResponse setBody(SaveWhiteAppResponseBody body) {
        this.body = body;
        return this;
    }
    public SaveWhiteAppResponseBody getBody() {
        return this.body;
    }

}
