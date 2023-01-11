// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DeleteRangeProtectionRequest extends TeaModel {
    /**
     * <p>操作人unionId</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static DeleteRangeProtectionRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteRangeProtectionRequest self = new DeleteRangeProtectionRequest();
        return TeaModel.build(map, self);
    }

    public DeleteRangeProtectionRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
