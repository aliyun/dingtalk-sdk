// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class DeleteBizObjectResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public DeleteBizObjectResponseBody body;

    public static DeleteBizObjectResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteBizObjectResponse self = new DeleteBizObjectResponse();
        return TeaModel.build(map, self);
    }

    public DeleteBizObjectResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteBizObjectResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteBizObjectResponse setBody(DeleteBizObjectResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteBizObjectResponseBody getBody() {
        return this.body;
    }

}
