// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydLogMonthStatisticalDataRequest extends TeaModel {
    // statDate
    @NameInMap("statDate")
    public String statDate;

    public static QueryYydLogMonthStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryYydLogMonthStatisticalDataRequest self = new QueryYydLogMonthStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryYydLogMonthStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
