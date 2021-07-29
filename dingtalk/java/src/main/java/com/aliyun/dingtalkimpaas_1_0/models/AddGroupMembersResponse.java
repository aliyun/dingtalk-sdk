// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class AddGroupMembersResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static AddGroupMembersResponse build(java.util.Map<String, ?> map) throws Exception {
        AddGroupMembersResponse self = new AddGroupMembersResponse();
        return TeaModel.build(map, self);
    }

    public AddGroupMembersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
