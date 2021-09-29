// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class TerminateCloudAuthorizationResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static TerminateCloudAuthorizationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TerminateCloudAuthorizationResponseBody self = new TerminateCloudAuthorizationResponseBody();
        return TeaModel.build(map, self);
    }

    public TerminateCloudAuthorizationResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
