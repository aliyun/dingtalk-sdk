// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class UnpinSpaceRequest extends TeaModel {
    /**
     * <p>操作人id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static UnpinSpaceRequest build(java.util.Map<String, ?> map) throws Exception {
        UnpinSpaceRequest self = new UnpinSpaceRequest();
        return TeaModel.build(map, self);
    }

    public UnpinSpaceRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
