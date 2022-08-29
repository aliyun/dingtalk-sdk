// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class UpdateProcessInstanceResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static UpdateProcessInstanceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateProcessInstanceResponseBody self = new UpdateProcessInstanceResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateProcessInstanceResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
