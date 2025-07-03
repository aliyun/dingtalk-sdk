// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class BatchAddOrUpdateRoleMembersResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchAddOrUpdateRoleMembersResponseBody body;

    public static BatchAddOrUpdateRoleMembersResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchAddOrUpdateRoleMembersResponse self = new BatchAddOrUpdateRoleMembersResponse();
        return TeaModel.build(map, self);
    }

    public BatchAddOrUpdateRoleMembersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchAddOrUpdateRoleMembersResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchAddOrUpdateRoleMembersResponse setBody(BatchAddOrUpdateRoleMembersResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchAddOrUpdateRoleMembersResponseBody getBody() {
        return this.body;
    }

}
