// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateTheGroupRolesOfGroupMemberResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateTheGroupRolesOfGroupMemberResponseBody body;

    public static UpdateTheGroupRolesOfGroupMemberResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateTheGroupRolesOfGroupMemberResponse self = new UpdateTheGroupRolesOfGroupMemberResponse();
        return TeaModel.build(map, self);
    }

    public UpdateTheGroupRolesOfGroupMemberResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateTheGroupRolesOfGroupMemberResponse setBody(UpdateTheGroupRolesOfGroupMemberResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateTheGroupRolesOfGroupMemberResponseBody getBody() {
        return this.body;
    }

}
