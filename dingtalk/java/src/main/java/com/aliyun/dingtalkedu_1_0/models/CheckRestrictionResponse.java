// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CheckRestrictionResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CheckRestrictionResponseBody body;

    public static CheckRestrictionResponse build(java.util.Map<String, ?> map) throws Exception {
        CheckRestrictionResponse self = new CheckRestrictionResponse();
        return TeaModel.build(map, self);
    }

    public CheckRestrictionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CheckRestrictionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CheckRestrictionResponse setBody(CheckRestrictionResponseBody body) {
        this.body = body;
        return this;
    }
    public CheckRestrictionResponseBody getBody() {
        return this.body;
    }

}
