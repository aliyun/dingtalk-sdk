// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class DisableWorkflowResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static DisableWorkflowResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DisableWorkflowResponseBody self = new DisableWorkflowResponseBody();
        return TeaModel.build(map, self);
    }

    public DisableWorkflowResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
