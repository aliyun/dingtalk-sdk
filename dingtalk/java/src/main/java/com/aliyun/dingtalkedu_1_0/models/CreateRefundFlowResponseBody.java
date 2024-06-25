// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateRefundFlowResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static CreateRefundFlowResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateRefundFlowResponseBody self = new CreateRefundFlowResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateRefundFlowResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
