// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class RebuildRoleMembersResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public RebuildRoleMembersResponseBody body;

    public static RebuildRoleMembersResponse build(java.util.Map<String, ?> map) throws Exception {
        RebuildRoleMembersResponse self = new RebuildRoleMembersResponse();
        return TeaModel.build(map, self);
    }

    public RebuildRoleMembersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RebuildRoleMembersResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RebuildRoleMembersResponse setBody(RebuildRoleMembersResponseBody body) {
        this.body = body;
        return this;
    }
    public RebuildRoleMembersResponseBody getBody() {
        return this.body;
    }

}
