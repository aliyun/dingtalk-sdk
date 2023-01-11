// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryDriveStatisticalDataRequest extends TeaModel {
    /**
     * <p>statDate</p>
     */
    @NameInMap("statDate")
    public String statDate;

    public static QueryDriveStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryDriveStatisticalDataRequest self = new QueryDriveStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryDriveStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
