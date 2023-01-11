// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydDingMsgMonthStatisticalDataRequest extends TeaModel {
    /**
     * <p>statDate</p>
     */
    @NameInMap("statDate")
    public String statDate;

    public static QueryYydDingMsgMonthStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryYydDingMsgMonthStatisticalDataRequest self = new QueryYydDingMsgMonthStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryYydDingMsgMonthStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
