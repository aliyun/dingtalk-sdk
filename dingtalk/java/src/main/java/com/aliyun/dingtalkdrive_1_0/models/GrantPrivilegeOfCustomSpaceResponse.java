// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class GrantPrivilegeOfCustomSpaceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static GrantPrivilegeOfCustomSpaceResponse build(java.util.Map<String, ?> map) throws Exception {
        GrantPrivilegeOfCustomSpaceResponse self = new GrantPrivilegeOfCustomSpaceResponse();
        return TeaModel.build(map, self);
    }

    public GrantPrivilegeOfCustomSpaceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
