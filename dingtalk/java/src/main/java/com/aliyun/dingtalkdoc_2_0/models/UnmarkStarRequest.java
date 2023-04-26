// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class UnmarkStarRequest extends TeaModel {
    @NameInMap("operatorId")
    public String operatorId;

    public static UnmarkStarRequest build(java.util.Map<String, ?> map) throws Exception {
        UnmarkStarRequest self = new UnmarkStarRequest();
        return TeaModel.build(map, self);
    }

    public UnmarkStarRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
