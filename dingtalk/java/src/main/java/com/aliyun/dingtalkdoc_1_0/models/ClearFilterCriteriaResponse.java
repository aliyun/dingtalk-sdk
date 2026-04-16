// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class ClearFilterCriteriaResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ClearFilterCriteriaResponseBody body;

    public static ClearFilterCriteriaResponse build(java.util.Map<String, ?> map) throws Exception {
        ClearFilterCriteriaResponse self = new ClearFilterCriteriaResponse();
        return TeaModel.build(map, self);
    }

    public ClearFilterCriteriaResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ClearFilterCriteriaResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ClearFilterCriteriaResponse setBody(ClearFilterCriteriaResponseBody body) {
        this.body = body;
        return this;
    }
    public ClearFilterCriteriaResponseBody getBody() {
        return this.body;
    }

}
