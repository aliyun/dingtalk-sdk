// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryTelMeetingStatisticalDataRequest extends TeaModel {
    @NameInMap("statDate")
    public String statDate;

    public static QueryTelMeetingStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryTelMeetingStatisticalDataRequest self = new QueryTelMeetingStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryTelMeetingStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
