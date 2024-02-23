// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class PageAutoFlowLogResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PageAutoFlowLogResponseBody body;

    public static PageAutoFlowLogResponse build(java.util.Map<String, ?> map) throws Exception {
        PageAutoFlowLogResponse self = new PageAutoFlowLogResponse();
        return TeaModel.build(map, self);
    }

    public PageAutoFlowLogResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PageAutoFlowLogResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PageAutoFlowLogResponse setBody(PageAutoFlowLogResponseBody body) {
        this.body = body;
        return this;
    }
    public PageAutoFlowLogResponseBody getBody() {
        return this.body;
    }

}
