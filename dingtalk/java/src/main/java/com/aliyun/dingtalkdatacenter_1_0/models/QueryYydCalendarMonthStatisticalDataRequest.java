// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydCalendarMonthStatisticalDataRequest extends TeaModel {
    @NameInMap("statDate")
    public String statDate;

    public static QueryYydCalendarMonthStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryYydCalendarMonthStatisticalDataRequest self = new QueryYydCalendarMonthStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryYydCalendarMonthStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
