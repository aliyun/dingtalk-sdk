// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class BatchInsertBizObjectResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchInsertBizObjectResponseBody body;

    public static BatchInsertBizObjectResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchInsertBizObjectResponse self = new BatchInsertBizObjectResponse();
        return TeaModel.build(map, self);
    }

    public BatchInsertBizObjectResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchInsertBizObjectResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchInsertBizObjectResponse setBody(BatchInsertBizObjectResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchInsertBizObjectResponseBody getBody() {
        return this.body;
    }

}
