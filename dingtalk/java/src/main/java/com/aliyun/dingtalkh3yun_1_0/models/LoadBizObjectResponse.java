// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class LoadBizObjectResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public LoadBizObjectResponseBody body;

    public static LoadBizObjectResponse build(java.util.Map<String, ?> map) throws Exception {
        LoadBizObjectResponse self = new LoadBizObjectResponse();
        return TeaModel.build(map, self);
    }

    public LoadBizObjectResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public LoadBizObjectResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public LoadBizObjectResponse setBody(LoadBizObjectResponseBody body) {
        this.body = body;
        return this;
    }
    public LoadBizObjectResponseBody getBody() {
        return this.body;
    }

}
