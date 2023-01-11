// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryRedEnvelopeReciveStatisticalDataRequest extends TeaModel {
    /**
     * <p>statDate</p>
     */
    @NameInMap("statDate")
    public String statDate;

    public static QueryRedEnvelopeReciveStatisticalDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryRedEnvelopeReciveStatisticalDataRequest self = new QueryRedEnvelopeReciveStatisticalDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryRedEnvelopeReciveStatisticalDataRequest setStatDate(String statDate) {
        this.statDate = statDate;
        return this;
    }
    public String getStatDate() {
        return this.statDate;
    }

}
