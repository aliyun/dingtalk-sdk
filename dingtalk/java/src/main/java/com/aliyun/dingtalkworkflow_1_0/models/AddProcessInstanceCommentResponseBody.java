// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class AddProcessInstanceCommentResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("result")
    public Boolean result;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static AddProcessInstanceCommentResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddProcessInstanceCommentResponseBody self = new AddProcessInstanceCommentResponseBody();
        return TeaModel.build(map, self);
    }

    public AddProcessInstanceCommentResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public AddProcessInstanceCommentResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
