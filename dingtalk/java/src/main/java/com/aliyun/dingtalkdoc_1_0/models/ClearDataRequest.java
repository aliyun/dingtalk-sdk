// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class ClearDataRequest extends TeaModel {
    /**
     * <p>操作人id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static ClearDataRequest build(java.util.Map<String, ?> map) throws Exception {
        ClearDataRequest self = new ClearDataRequest();
        return TeaModel.build(map, self);
    }

    public ClearDataRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
