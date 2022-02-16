// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydTotalMonthStatisticalDataRequest extends TeaModel {
    // statDate
    @NameInMap("statDate")
    public String statDate;

    public static QueryYydTotalMonthStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryYydTotalMonthStatisticalDataRequest self = new QueryYydTotalMonthStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryYydTotalMonthStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
