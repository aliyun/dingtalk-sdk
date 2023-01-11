// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydToatlMsgDayStatisticalDataRequest extends TeaModel {
    /**
     * <p>statDate</p>
     */
    @NameInMap("statDate")
    public String statDate;

    public static QueryYydToatlMsgDayStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryYydToatlMsgDayStatisticalDataRequest self = new QueryYydToatlMsgDayStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryYydToatlMsgDayStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
