// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class DeleteManagementGroupResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static DeleteManagementGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteManagementGroupResponse self = new DeleteManagementGroupResponse();
        return TeaModel.build(map, self);
    }

    public DeleteManagementGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
