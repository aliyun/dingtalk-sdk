// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryTodoStatisticalDataRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("statDate")
    public String statDate;

    public static QueryTodoStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryTodoStatisticalDataRequest self = new QueryTodoStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryTodoStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
