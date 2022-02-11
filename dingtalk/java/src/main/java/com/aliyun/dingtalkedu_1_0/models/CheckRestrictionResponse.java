// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CheckRestrictionResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public CheckRestrictionResponse setBody(CheckRestrictionResponseBody body) {
        this.body = body;
        return this;
    }
    public CheckRestrictionResponseBody getBody() {
        return this.body;
    }

}
