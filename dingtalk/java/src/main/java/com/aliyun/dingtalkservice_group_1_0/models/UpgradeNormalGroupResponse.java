// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class UpgradeNormalGroupResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static UpgradeNormalGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        UpgradeNormalGroupResponse self = new UpgradeNormalGroupResponse();
        return TeaModel.build(map, self);
    }

    public UpgradeNormalGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
