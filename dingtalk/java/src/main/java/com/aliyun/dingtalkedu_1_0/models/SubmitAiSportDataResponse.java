// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class SubmitAiSportDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SubmitAiSportDataResponseBody body;

    public static SubmitAiSportDataResponse build(java.util.Map<String, ?> map) throws Exception {
        SubmitAiSportDataResponse self = new SubmitAiSportDataResponse();
        return TeaModel.build(map, self);
    }

    public SubmitAiSportDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SubmitAiSportDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SubmitAiSportDataResponse setBody(SubmitAiSportDataResponseBody body) {
        this.body = body;
        return this;
    }
    public SubmitAiSportDataResponseBody getBody() {
        return this.body;
    }

}
