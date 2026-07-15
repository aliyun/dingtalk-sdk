// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class DeleteWorkflowResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static DeleteWorkflowResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteWorkflowResponseBody self = new DeleteWorkflowResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteWorkflowResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
