// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class OpenGroupUserRoleQueryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public OpenGroupUserRoleQueryResponseBody body;

    public static OpenGroupUserRoleQueryResponse build(java.util.Map<String, ?> map) throws Exception {
        OpenGroupUserRoleQueryResponse self = new OpenGroupUserRoleQueryResponse();
        return TeaModel.build(map, self);
    }

    public OpenGroupUserRoleQueryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public OpenGroupUserRoleQueryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public OpenGroupUserRoleQueryResponse setBody(OpenGroupUserRoleQueryResponseBody body) {
        this.body = body;
        return this;
    }
    public OpenGroupUserRoleQueryResponseBody getBody() {
        return this.body;
    }

}
