// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateAwaitingCorrectionDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateAwaitingCorrectionDataResponseBody body;

    public static CreateAwaitingCorrectionDataResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateAwaitingCorrectionDataResponse self = new CreateAwaitingCorrectionDataResponse();
        return TeaModel.build(map, self);
    }

    public CreateAwaitingCorrectionDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateAwaitingCorrectionDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateAwaitingCorrectionDataResponse setBody(CreateAwaitingCorrectionDataResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateAwaitingCorrectionDataResponseBody getBody() {
        return this.body;
    }

}
