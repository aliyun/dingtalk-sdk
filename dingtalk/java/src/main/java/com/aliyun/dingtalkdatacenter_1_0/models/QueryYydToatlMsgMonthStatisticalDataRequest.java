// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydToatlMsgMonthStatisticalDataRequest extends TeaModel {
    @NameInMap("statDate")
    public String statDate;

    public static QueryYydToatlMsgMonthStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryYydToatlMsgMonthStatisticalDataRequest self = new QueryYydToatlMsgMonthStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryYydToatlMsgMonthStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
