// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateEduLlmModelReqResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateEduLlmModelReqResponseBody body;

    public static CreateEduLlmModelReqResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateEduLlmModelReqResponse self = new CreateEduLlmModelReqResponse();
        return TeaModel.build(map, self);
    }

    public CreateEduLlmModelReqResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateEduLlmModelReqResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateEduLlmModelReqResponse setBody(CreateEduLlmModelReqResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateEduLlmModelReqResponseBody getBody() {
        return this.body;
    }

}
