// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryOnlineUserStatisticalDataRequest extends TeaModel {
    // statDate
    @NameInMap("statDate")
    public String statDate;

    public static QueryOnlineUserStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryOnlineUserStatisticalDataRequest self = new QueryOnlineUserStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryOnlineUserStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
