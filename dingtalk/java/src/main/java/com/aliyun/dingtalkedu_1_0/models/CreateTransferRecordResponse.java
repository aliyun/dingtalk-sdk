// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateTransferRecordResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateTransferRecordResponseBody body;

    public static CreateTransferRecordResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateTransferRecordResponse self = new CreateTransferRecordResponse();
        return TeaModel.build(map, self);
    }

    public CreateTransferRecordResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateTransferRecordResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateTransferRecordResponse setBody(CreateTransferRecordResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateTransferRecordResponseBody getBody() {
        return this.body;
    }

}
