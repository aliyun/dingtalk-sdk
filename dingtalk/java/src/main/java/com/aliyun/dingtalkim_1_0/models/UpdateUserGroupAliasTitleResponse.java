// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateUserGroupAliasTitleResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateUserGroupAliasTitleResponseBody body;

    public static UpdateUserGroupAliasTitleResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateUserGroupAliasTitleResponse self = new UpdateUserGroupAliasTitleResponse();
        return TeaModel.build(map, self);
    }

    public UpdateUserGroupAliasTitleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateUserGroupAliasTitleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateUserGroupAliasTitleResponse setBody(UpdateUserGroupAliasTitleResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateUserGroupAliasTitleResponseBody getBody() {
        return this.body;
    }

}
