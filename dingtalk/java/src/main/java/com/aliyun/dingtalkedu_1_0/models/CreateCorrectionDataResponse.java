// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateCorrectionDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateCorrectionDataResponseBody body;

    public static CreateCorrectionDataResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateCorrectionDataResponse self = new CreateCorrectionDataResponse();
        return TeaModel.build(map, self);
    }

    public CreateCorrectionDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateCorrectionDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateCorrectionDataResponse setBody(CreateCorrectionDataResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateCorrectionDataResponseBody getBody() {
        return this.body;
    }

}
