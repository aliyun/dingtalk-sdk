// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DeleteFilterViewRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static DeleteFilterViewRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteFilterViewRequest self = new DeleteFilterViewRequest();
        return TeaModel.build(map, self);
    }

    public DeleteFilterViewRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
