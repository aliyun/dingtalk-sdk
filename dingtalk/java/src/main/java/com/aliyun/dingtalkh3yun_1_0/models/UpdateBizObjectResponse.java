// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class UpdateBizObjectResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateBizObjectResponseBody body;

    public static UpdateBizObjectResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateBizObjectResponse self = new UpdateBizObjectResponse();
        return TeaModel.build(map, self);
    }

    public UpdateBizObjectResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateBizObjectResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateBizObjectResponse setBody(UpdateBizObjectResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateBizObjectResponseBody getBody() {
        return this.body;
    }

}
