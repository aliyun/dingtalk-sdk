// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class CleanProcessDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CleanProcessDataResponseBody body;

    public static CleanProcessDataResponse build(java.util.Map<String, ?> map) throws Exception {
        CleanProcessDataResponse self = new CleanProcessDataResponse();
        return TeaModel.build(map, self);
    }

    public CleanProcessDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CleanProcessDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CleanProcessDataResponse setBody(CleanProcessDataResponseBody body) {
        this.body = body;
        return this;
    }
    public CleanProcessDataResponseBody getBody() {
        return this.body;
    }

}
