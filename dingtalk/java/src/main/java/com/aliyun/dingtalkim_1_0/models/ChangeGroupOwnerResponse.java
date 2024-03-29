// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class ChangeGroupOwnerResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ChangeGroupOwnerResponseBody body;

    public static ChangeGroupOwnerResponse build(java.util.Map<String, ?> map) throws Exception {
        ChangeGroupOwnerResponse self = new ChangeGroupOwnerResponse();
        return TeaModel.build(map, self);
    }

    public ChangeGroupOwnerResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ChangeGroupOwnerResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ChangeGroupOwnerResponse setBody(ChangeGroupOwnerResponseBody body) {
        this.body = body;
        return this;
    }
    public ChangeGroupOwnerResponseBody getBody() {
        return this.body;
    }

}
