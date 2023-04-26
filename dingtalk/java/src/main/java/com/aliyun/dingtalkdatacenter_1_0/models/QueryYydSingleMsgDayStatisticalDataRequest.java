// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydSingleMsgDayStatisticalDataRequest extends TeaModel {
    @NameInMap("statDate")
    public String statDate;

    public static QueryYydSingleMsgDayStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryYydSingleMsgDayStatisticalDataRequest self = new QueryYydSingleMsgDayStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryYydSingleMsgDayStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
