// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryDingReciveStatisticalDataRequest extends TeaModel {
    @NameInMap("statDate")
    public String statDate;

    public static QueryDingReciveStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryDingReciveStatisticalDataRequest self = new QueryDingReciveStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryDingReciveStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
