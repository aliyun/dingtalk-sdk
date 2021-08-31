// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class AddWorkspaceDocMembersResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static AddWorkspaceDocMembersResponse build(java.util.Map<String, ?> map) throws Exception {
        AddWorkspaceDocMembersResponse self = new AddWorkspaceDocMembersResponse();
        return TeaModel.build(map, self);
    }

    public AddWorkspaceDocMembersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
