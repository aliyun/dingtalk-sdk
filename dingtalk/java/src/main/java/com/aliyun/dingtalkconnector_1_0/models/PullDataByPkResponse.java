// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class PullDataByPkResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public PullDataByPkResponseBody body;

    public static PullDataByPkResponse build(java.util.Map<String, ?> map) throws Exception {
        PullDataByPkResponse self = new PullDataByPkResponse();
        return TeaModel.build(map, self);
    }

    public PullDataByPkResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PullDataByPkResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PullDataByPkResponse setBody(PullDataByPkResponseBody body) {
        this.body = body;
        return this;
    }
    public PullDataByPkResponseBody getBody() {
        return this.body;
    }

}
