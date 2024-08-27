// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumGetDoneTasksResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PremiumGetDoneTasksResponseBody body;

    public static PremiumGetDoneTasksResponse build(java.util.Map<String, ?> map) throws Exception {
        PremiumGetDoneTasksResponse self = new PremiumGetDoneTasksResponse();
        return TeaModel.build(map, self);
    }

    public PremiumGetDoneTasksResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PremiumGetDoneTasksResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PremiumGetDoneTasksResponse setBody(PremiumGetDoneTasksResponseBody body) {
        this.body = body;
        return this;
    }
    public PremiumGetDoneTasksResponseBody getBody() {
        return this.body;
    }

}
