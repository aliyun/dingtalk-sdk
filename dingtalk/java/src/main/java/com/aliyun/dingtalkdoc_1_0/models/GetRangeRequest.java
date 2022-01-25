// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetRangeRequest extends TeaModel {
    // 操作人unionId
    @NameInMap("operatorId")
    public String operatorId;

    public static GetRangeRequest build(java.util.Map<String, ?> map) throws Exception {
        GetRangeRequest self = new GetRangeRequest();
        return TeaModel.build(map, self);
    }

    public GetRangeRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
