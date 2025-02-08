// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class FreezeGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public FreezeGroupResponseBody body;

    public static FreezeGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        FreezeGroupResponse self = new FreezeGroupResponse();
        return TeaModel.build(map, self);
    }

    public FreezeGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public FreezeGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public FreezeGroupResponse setBody(FreezeGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public FreezeGroupResponseBody getBody() {
        return this.body;
    }

}
