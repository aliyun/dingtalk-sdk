// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class BatchOperateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchOperateResponseBody body;

    public static BatchOperateResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchOperateResponse self = new BatchOperateResponse();
        return TeaModel.build(map, self);
    }

    public BatchOperateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchOperateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchOperateResponse setBody(BatchOperateResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchOperateResponseBody getBody() {
        return this.body;
    }

}
