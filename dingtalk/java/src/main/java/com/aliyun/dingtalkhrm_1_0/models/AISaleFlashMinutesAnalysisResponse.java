// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AISaleFlashMinutesAnalysisResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AISaleFlashMinutesAnalysisResponseBody body;

    public static AISaleFlashMinutesAnalysisResponse build(java.util.Map<String, ?> map) throws Exception {
        AISaleFlashMinutesAnalysisResponse self = new AISaleFlashMinutesAnalysisResponse();
        return TeaModel.build(map, self);
    }

    public AISaleFlashMinutesAnalysisResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AISaleFlashMinutesAnalysisResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AISaleFlashMinutesAnalysisResponse setBody(AISaleFlashMinutesAnalysisResponseBody body) {
        this.body = body;
        return this;
    }
    public AISaleFlashMinutesAnalysisResponseBody getBody() {
        return this.body;
    }

}
