// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydCalendarWeekStatisticalDataRequest extends TeaModel {
    /**
     * <p>statDate</p>
     */
    @NameInMap("statDate")
    public String statDate;

    public static QueryYydCalendarWeekStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryYydCalendarWeekStatisticalDataRequest self = new QueryYydCalendarWeekStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryYydCalendarWeekStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
