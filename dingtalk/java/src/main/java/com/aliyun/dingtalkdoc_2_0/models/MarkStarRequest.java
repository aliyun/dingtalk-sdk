// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class MarkStarRequest extends TeaModel {
    @NameInMap("operatorId")
    public String operatorId;

    public static MarkStarRequest build(java.util.Map<String, ?> map) throws Exception {
        MarkStarRequest self = new MarkStarRequest();
        return TeaModel.build(map, self);
    }

    public MarkStarRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
