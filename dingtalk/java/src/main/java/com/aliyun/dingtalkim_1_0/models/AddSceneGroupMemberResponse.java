// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class AddSceneGroupMemberResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddSceneGroupMemberResponseBody body;

    public static AddSceneGroupMemberResponse build(java.util.Map<String, ?> map) throws Exception {
        AddSceneGroupMemberResponse self = new AddSceneGroupMemberResponse();
        return TeaModel.build(map, self);
    }

    public AddSceneGroupMemberResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddSceneGroupMemberResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddSceneGroupMemberResponse setBody(AddSceneGroupMemberResponseBody body) {
        this.body = body;
        return this;
    }
    public AddSceneGroupMemberResponseBody getBody() {
        return this.body;
    }

}
