// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateFulfilRecordResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateFulfilRecordResponseBody body;

    public static CreateFulfilRecordResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateFulfilRecordResponse self = new CreateFulfilRecordResponse();
        return TeaModel.build(map, self);
    }

    public CreateFulfilRecordResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateFulfilRecordResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateFulfilRecordResponse setBody(CreateFulfilRecordResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateFulfilRecordResponseBody getBody() {
        return this.body;
    }

}
