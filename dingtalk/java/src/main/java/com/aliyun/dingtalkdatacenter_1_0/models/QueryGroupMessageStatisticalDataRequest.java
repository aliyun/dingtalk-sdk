// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupMessageStatisticalDataRequest extends TeaModel {
    /**
     * <p>statDate</p>
     */
    @NameInMap("statDate")
    public String statDate;

    public static QueryGroupMessageStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupMessageStatisticalDataRequest self = new QueryGroupMessageStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryGroupMessageStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
