// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class AiTrainingRecordResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AiTrainingRecordResponseBody body;

    public static AiTrainingRecordResponse build(java.util.Map<String, ?> map) throws Exception {
        AiTrainingRecordResponse self = new AiTrainingRecordResponse();
        return TeaModel.build(map, self);
    }

    public AiTrainingRecordResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AiTrainingRecordResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AiTrainingRecordResponse setBody(AiTrainingRecordResponseBody body) {
        this.body = body;
        return this;
    }
    public AiTrainingRecordResponseBody getBody() {
        return this.body;
    }

}
