// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SetFilterCriteriaResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SetFilterCriteriaResponseBody body;

    public static SetFilterCriteriaResponse build(java.util.Map<String, ?> map) throws Exception {
        SetFilterCriteriaResponse self = new SetFilterCriteriaResponse();
        return TeaModel.build(map, self);
    }

    public SetFilterCriteriaResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SetFilterCriteriaResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SetFilterCriteriaResponse setBody(SetFilterCriteriaResponseBody body) {
        this.body = body;
        return this;
    }
    public SetFilterCriteriaResponseBody getBody() {
        return this.body;
    }

}
