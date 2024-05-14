// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryYydTodoWeekStatisticalDataRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("statDate")
    public String statDate;

    public static QueryYydTodoWeekStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryYydTodoWeekStatisticalDataRequest self = new QueryYydTodoWeekStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryYydTodoWeekStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
