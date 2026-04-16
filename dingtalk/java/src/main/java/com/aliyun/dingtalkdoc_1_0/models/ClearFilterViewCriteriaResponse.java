// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class ClearFilterViewCriteriaResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ClearFilterViewCriteriaResponseBody body;

    public static ClearFilterViewCriteriaResponse build(java.util.Map<String, ?> map) throws Exception {
        ClearFilterViewCriteriaResponse self = new ClearFilterViewCriteriaResponse();
        return TeaModel.build(map, self);
    }

    public ClearFilterViewCriteriaResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ClearFilterViewCriteriaResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ClearFilterViewCriteriaResponse setBody(ClearFilterViewCriteriaResponseBody body) {
        this.body = body;
        return this;
    }
    public ClearFilterViewCriteriaResponseBody getBody() {
        return this.body;
    }

}
