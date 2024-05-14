// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydGroupMsgWeekStatisticalDataRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("statDate")
    public String statDate;

    public static QueryYydGroupMsgWeekStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryYydGroupMsgWeekStatisticalDataRequest self = new QueryYydGroupMsgWeekStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryYydGroupMsgWeekStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
