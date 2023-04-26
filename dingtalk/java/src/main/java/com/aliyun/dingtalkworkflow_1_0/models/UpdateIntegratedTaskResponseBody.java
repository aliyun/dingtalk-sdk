// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class UpdateIntegratedTaskResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static UpdateIntegratedTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateIntegratedTaskResponseBody self = new UpdateIntegratedTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateIntegratedTaskResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
