// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class AddWorkspaceMembersResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static AddWorkspaceMembersResponse build(java.util.Map<String, ?> map) throws Exception {
        AddWorkspaceMembersResponse self = new AddWorkspaceMembersResponse();
        return TeaModel.build(map, self);
    }

    public AddWorkspaceMembersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
