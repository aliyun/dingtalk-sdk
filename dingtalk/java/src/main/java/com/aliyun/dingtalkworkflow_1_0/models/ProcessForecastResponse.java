// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class ProcessForecastResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public ProcessForecastResponse setBody(ProcessForecastResponseBody body) {
        this.body = body;
        return this;
    }
    public ProcessForecastResponseBody getBody() {
        return this.body;
    }

}
