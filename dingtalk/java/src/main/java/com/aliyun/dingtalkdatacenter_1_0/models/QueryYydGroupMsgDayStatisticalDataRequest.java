// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydGroupMsgDayStatisticalDataRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("statDate")
    public String statDate;

    public static QueryYydGroupMsgDayStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryYydGroupMsgDayStatisticalDataRequest self = new QueryYydGroupMsgDayStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryYydGroupMsgDayStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
