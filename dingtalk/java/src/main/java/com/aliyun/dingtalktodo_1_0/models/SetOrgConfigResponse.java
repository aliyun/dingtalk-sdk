// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class SetOrgConfigResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SetOrgConfigResponseBody body;

    public static SetOrgConfigResponse build(java.util.Map<String, ?> map) throws Exception {
        SetOrgConfigResponse self = new SetOrgConfigResponse();
        return TeaModel.build(map, self);
    }

    public SetOrgConfigResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SetOrgConfigResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SetOrgConfigResponse setBody(SetOrgConfigResponseBody body) {
        this.body = body;
        return this;
    }
    public SetOrgConfigResponseBody getBody() {
        return this.body;
    }

}
