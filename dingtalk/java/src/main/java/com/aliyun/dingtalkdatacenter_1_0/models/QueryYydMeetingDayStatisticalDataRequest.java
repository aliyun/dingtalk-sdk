// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydMeetingDayStatisticalDataRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("statDate")
    public String statDate;

    public static QueryYydMeetingDayStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryYydMeetingDayStatisticalDataRequest self = new QueryYydMeetingDayStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryYydMeetingDayStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
