// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class ProcessForecastResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ProcessForecastResponseBody body;

    public static ProcessForecastResponse build(java.util.Map<String, ?> map) throws Exception {
        ProcessForecastResponse self = new ProcessForecastResponse();
        return TeaModel.build(map, self);
    }

    public ProcessForecastResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ProcessForecastResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ProcessForecastResponse setBody(ProcessForecastResponseBody body) {
        this.body = body;
        return this;
    }
    public ProcessForecastResponseBody getBody() {
        return this.body;
    }

}
