// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class DeleteWorkflowInstanceResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static DeleteWorkflowInstanceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteWorkflowInstanceResponseBody self = new DeleteWorkflowInstanceResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteWorkflowInstanceResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
