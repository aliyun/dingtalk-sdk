// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class EnableWorkflowResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static EnableWorkflowResponseBody build(java.util.Map<String, ?> map) throws Exception {
        EnableWorkflowResponseBody self = new EnableWorkflowResponseBody();
        return TeaModel.build(map, self);
    }

    public EnableWorkflowResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
