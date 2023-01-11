// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryAttendanceStatisticalDataRequest extends TeaModel {
    /**
     * <p>statDate</p>
     */
    @NameInMap("statDate")
    public String statDate;

    public static QueryAttendanceStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryAttendanceStatisticalDataRequest self = new QueryAttendanceStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryAttendanceStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
