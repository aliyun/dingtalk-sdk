// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GroupManageReduceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static GroupManageReduceResponse build(java.util.Map<String, ?> map) throws Exception {
        GroupManageReduceResponse self = new GroupManageReduceResponse();
        return TeaModel.build(map, self);
    }

    public GroupManageReduceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
