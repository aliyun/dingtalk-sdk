// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetStarInfoRequest extends TeaModel {
    @NameInMap("operatorId")
    public String operatorId;

    public static GetStarInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetStarInfoRequest self = new GetStarInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetStarInfoRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
