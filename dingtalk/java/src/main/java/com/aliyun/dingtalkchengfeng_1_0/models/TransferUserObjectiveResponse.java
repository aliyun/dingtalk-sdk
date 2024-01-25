// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class TransferUserObjectiveResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TransferUserObjectiveResponseBody body;

    public static TransferUserObjectiveResponse build(java.util.Map<String, ?> map) throws Exception {
        TransferUserObjectiveResponse self = new TransferUserObjectiveResponse();
        return TeaModel.build(map, self);
    }

    public TransferUserObjectiveResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TransferUserObjectiveResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TransferUserObjectiveResponse setBody(TransferUserObjectiveResponseBody body) {
        this.body = body;
        return this;
    }
    public TransferUserObjectiveResponseBody getBody() {
        return this.body;
    }

}
