// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateTaskInvolvemembersResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateTaskInvolvemembersResponseBody body;

    public static UpdateTaskInvolvemembersResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateTaskInvolvemembersResponse self = new UpdateTaskInvolvemembersResponse();
        return TeaModel.build(map, self);
    }

    public UpdateTaskInvolvemembersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateTaskInvolvemembersResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateTaskInvolvemembersResponse setBody(UpdateTaskInvolvemembersResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateTaskInvolvemembersResponseBody getBody() {
        return this.body;
    }

}
