// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateEvaluatePerformanceCountResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateEvaluatePerformanceCountResponseBody body;

    public static UpdateEvaluatePerformanceCountResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateEvaluatePerformanceCountResponse self = new UpdateEvaluatePerformanceCountResponse();
        return TeaModel.build(map, self);
    }

    public UpdateEvaluatePerformanceCountResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateEvaluatePerformanceCountResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateEvaluatePerformanceCountResponse setBody(UpdateEvaluatePerformanceCountResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateEvaluatePerformanceCountResponseBody getBody() {
        return this.body;
    }

}
