// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryBlackboardStatisticalDataRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("statDate")
    public String statDate;

    public static QueryBlackboardStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryBlackboardStatisticalDataRequest self = new QueryBlackboardStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryBlackboardStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
