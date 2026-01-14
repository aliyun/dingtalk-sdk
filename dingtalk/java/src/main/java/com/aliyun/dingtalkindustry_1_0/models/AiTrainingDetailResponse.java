// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class AiTrainingDetailResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AiTrainingDetailResponseBody body;

    public static AiTrainingDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        AiTrainingDetailResponse self = new AiTrainingDetailResponse();
        return TeaModel.build(map, self);
    }

    public AiTrainingDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AiTrainingDetailResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AiTrainingDetailResponse setBody(AiTrainingDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public AiTrainingDetailResponseBody getBody() {
        return this.body;
    }

}
