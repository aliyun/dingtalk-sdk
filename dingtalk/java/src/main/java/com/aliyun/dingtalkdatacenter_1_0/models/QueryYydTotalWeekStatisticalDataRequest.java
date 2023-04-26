// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydTotalWeekStatisticalDataRequest extends TeaModel {
    @NameInMap("statDate")
    public String statDate;

    public static QueryYydTotalWeekStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryYydTotalWeekStatisticalDataRequest self = new QueryYydTotalWeekStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryYydTotalWeekStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
