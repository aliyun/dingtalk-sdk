// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydAppMonthStatisticalDataRequest extends TeaModel {
    // statDate
    @NameInMap("statDate")
    public String statDate;

    public static QueryYydAppMonthStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryYydAppMonthStatisticalDataRequest self = new QueryYydAppMonthStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryYydAppMonthStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
