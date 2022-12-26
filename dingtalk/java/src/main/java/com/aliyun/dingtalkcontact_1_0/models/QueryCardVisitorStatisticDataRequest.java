// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class QueryCardVisitorStatisticDataRequest extends TeaModel {
    // 用户的unionId
    @NameInMap("unionId")
    public String unionId;

    public static QueryCardVisitorStatisticDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCardVisitorStatisticDataRequest self = new QueryCardVisitorStatisticDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryCardVisitorStatisticDataRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
