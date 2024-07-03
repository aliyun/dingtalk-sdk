// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class OpenGroupRoleQueryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public OpenGroupRoleQueryResponseBody body;

    public static OpenGroupRoleQueryResponse build(java.util.Map<String, ?> map) throws Exception {
        OpenGroupRoleQueryResponse self = new OpenGroupRoleQueryResponse();
        return TeaModel.build(map, self);
    }

    public OpenGroupRoleQueryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public OpenGroupRoleQueryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public OpenGroupRoleQueryResponse setBody(OpenGroupRoleQueryResponseBody body) {
        this.body = body;
        return this;
    }
    public OpenGroupRoleQueryResponseBody getBody() {
        return this.body;
    }

}
