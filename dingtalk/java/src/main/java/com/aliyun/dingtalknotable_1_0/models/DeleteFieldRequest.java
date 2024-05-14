// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class DeleteFieldRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static DeleteFieldRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteFieldRequest self = new DeleteFieldRequest();
        return TeaModel.build(map, self);
    }

    public DeleteFieldRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
