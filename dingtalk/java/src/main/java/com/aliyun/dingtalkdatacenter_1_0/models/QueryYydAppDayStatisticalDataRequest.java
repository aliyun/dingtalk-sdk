// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydAppDayStatisticalDataRequest extends TeaModel {
    /**
     * <p>statDate</p>
     */
    @NameInMap("statDate")
    public String statDate;

    public static QueryYydAppDayStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryYydAppDayStatisticalDataRequest self = new QueryYydAppDayStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryYydAppDayStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
