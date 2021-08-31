// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class UpdateWorkspaceDocMembersResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static UpdateWorkspaceDocMembersResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateWorkspaceDocMembersResponse self = new UpdateWorkspaceDocMembersResponse();
        return TeaModel.build(map, self);
    }

    public UpdateWorkspaceDocMembersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
