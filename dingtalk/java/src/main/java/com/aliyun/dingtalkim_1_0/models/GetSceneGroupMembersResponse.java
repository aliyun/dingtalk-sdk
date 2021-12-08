// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetSceneGroupMembersResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetSceneGroupMembersResponseBody body;

    public static GetSceneGroupMembersResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSceneGroupMembersResponse self = new GetSceneGroupMembersResponse();
        return TeaModel.build(map, self);
    }

    public GetSceneGroupMembersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSceneGroupMembersResponse setBody(GetSceneGroupMembersResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSceneGroupMembersResponseBody getBody() {
        return this.body;
    }

}
