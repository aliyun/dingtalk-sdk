// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydCalendarDayStatisticalDataRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("statDate")
    public String statDate;

    public static QueryYydCalendarDayStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryYydCalendarDayStatisticalDataRequest self = new QueryYydCalendarDayStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryYydCalendarDayStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
