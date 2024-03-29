// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class SolutionTaskSaveResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SolutionTaskSaveResponseBody body;

    public static SolutionTaskSaveResponse build(java.util.Map<String, ?> map) throws Exception {
        SolutionTaskSaveResponse self = new SolutionTaskSaveResponse();
        return TeaModel.build(map, self);
    }

    public SolutionTaskSaveResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SolutionTaskSaveResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SolutionTaskSaveResponse setBody(SolutionTaskSaveResponseBody body) {
        this.body = body;
        return this;
    }
    public SolutionTaskSaveResponseBody getBody() {
        return this.body;
    }

}
