// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydDingMsgDayStatisticalDataRequest extends TeaModel {
    /**
     * <p>statDate</p>
     */
    @NameInMap("statDate")
    public String statDate;

    public static QueryYydDingMsgDayStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryYydDingMsgDayStatisticalDataRequest self = new QueryYydDingMsgDayStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryYydDingMsgDayStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
