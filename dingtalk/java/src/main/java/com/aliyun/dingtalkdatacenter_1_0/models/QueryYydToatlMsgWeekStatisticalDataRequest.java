// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydToatlMsgWeekStatisticalDataRequest extends TeaModel {
    /**
     * <p>statDate</p>
     */
    @NameInMap("statDate")
    public String statDate;

    public static QueryYydToatlMsgWeekStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryYydToatlMsgWeekStatisticalDataRequest self = new QueryYydToatlMsgWeekStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryYydToatlMsgWeekStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
