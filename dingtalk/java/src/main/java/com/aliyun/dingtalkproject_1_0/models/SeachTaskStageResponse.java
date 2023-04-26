// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SeachTaskStageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public SeachTaskStageResponseBody body;

    public static SeachTaskStageResponse build(java.util.Map<String, ?> map) throws Exception {
        SeachTaskStageResponse self = new SeachTaskStageResponse();
        return TeaModel.build(map, self);
    }

    public SeachTaskStageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SeachTaskStageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SeachTaskStageResponse setBody(SeachTaskStageResponseBody body) {
        this.body = body;
        return this;
    }
    public SeachTaskStageResponseBody getBody() {
        return this.body;
    }

}
