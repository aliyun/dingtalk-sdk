// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryScreenRequest extends TeaModel {
    @NameInMap("operatorId")
    public String operatorId;

    public static QueryScreenRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryScreenRequest self = new QueryScreenRequest();
        return TeaModel.build(map, self);
    }

    public QueryScreenRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
