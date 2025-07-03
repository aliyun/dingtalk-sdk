// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class BatchDeleteRoleMembersResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchDeleteRoleMembersResponseBody body;

    public static BatchDeleteRoleMembersResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchDeleteRoleMembersResponse self = new BatchDeleteRoleMembersResponse();
        return TeaModel.build(map, self);
    }

    public BatchDeleteRoleMembersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchDeleteRoleMembersResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchDeleteRoleMembersResponse setBody(BatchDeleteRoleMembersResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchDeleteRoleMembersResponseBody getBody() {
        return this.body;
    }

}
