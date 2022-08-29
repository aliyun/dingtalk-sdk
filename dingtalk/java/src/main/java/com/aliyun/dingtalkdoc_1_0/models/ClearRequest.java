// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class ClearRequest extends TeaModel {
    // 操作人unionId
    @NameInMap("operatorId")
    public String operatorId;

    public static ClearRequest build(java.util.Map<String, ?> map) throws Exception {
        ClearRequest self = new ClearRequest();
        return TeaModel.build(map, self);
    }

    public ClearRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
