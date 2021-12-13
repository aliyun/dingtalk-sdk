// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class BatchInsertBizObjectResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public BatchInsertBizObjectResponse setBody(BatchInsertBizObjectResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchInsertBizObjectResponseBody getBody() {
        return this.body;
    }

}
