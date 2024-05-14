// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydSingleMsgWeekStatisticalDataRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("statDate")
    public String statDate;

    public static QueryYydSingleMsgWeekStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryYydSingleMsgWeekStatisticalDataRequest self = new QueryYydSingleMsgWeekStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryYydSingleMsgWeekStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
