// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryRedEnvelopeSendStatisticalDataRequest extends TeaModel {
    /**
     * <p>statDate</p>
     */
    @NameInMap("statDate")
    public String statDate;

    public static QueryRedEnvelopeSendStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryRedEnvelopeSendStatisticalDataRequest self = new QueryRedEnvelopeSendStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryRedEnvelopeSendStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
