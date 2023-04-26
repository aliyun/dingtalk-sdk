// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetTeamRequest extends TeaModel {
    @NameInMap("operatorId")
    public String operatorId;

    public static GetTeamRequest build(java.util.Map<String, ?> map) throws Exception {
        GetTeamRequest self = new GetTeamRequest();
        return TeaModel.build(map, self);
    }

    public GetTeamRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
