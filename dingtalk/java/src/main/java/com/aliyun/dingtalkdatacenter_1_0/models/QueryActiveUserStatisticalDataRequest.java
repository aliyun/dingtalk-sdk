// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryActiveUserStatisticalDataRequest extends TeaModel {
    @NameInMap("statDate")
    public String statDate;

    public static QueryActiveUserStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryActiveUserStatisticalDataRequest self = new QueryActiveUserStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryActiveUserStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
