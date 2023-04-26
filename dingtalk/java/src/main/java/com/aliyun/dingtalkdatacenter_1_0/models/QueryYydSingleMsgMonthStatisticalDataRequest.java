// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydSingleMsgMonthStatisticalDataRequest extends TeaModel {
    @NameInMap("statDate")
    public String statDate;

    public static QueryYydSingleMsgMonthStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryYydSingleMsgMonthStatisticalDataRequest self = new QueryYydSingleMsgMonthStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryYydSingleMsgMonthStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
