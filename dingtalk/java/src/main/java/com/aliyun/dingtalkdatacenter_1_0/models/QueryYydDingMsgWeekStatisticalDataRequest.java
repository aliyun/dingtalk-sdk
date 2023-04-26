// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydDingMsgWeekStatisticalDataRequest extends TeaModel {
    @NameInMap("statDate")
    public String statDate;

    public static QueryYydDingMsgWeekStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryYydDingMsgWeekStatisticalDataRequest self = new QueryYydDingMsgWeekStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryYydDingMsgWeekStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
