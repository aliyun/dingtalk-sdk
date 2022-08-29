// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateProcessInstanceResponseBody extends TeaModel {
    // 成功标识
    @NameInMap("success")
    public Boolean success;

    public static BatchUpdateProcessInstanceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchUpdateProcessInstanceResponseBody self = new BatchUpdateProcessInstanceResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchUpdateProcessInstanceResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
