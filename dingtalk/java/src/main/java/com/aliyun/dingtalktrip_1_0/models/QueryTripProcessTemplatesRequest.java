// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class QueryTripProcessTemplatesRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>dingcd2016f425331dc1acaaa37764f94726</p>
     */
    @NameInMap("customerCorpId")
    public String customerCorpId;

    public static QueryTripProcessTemplatesRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryTripProcessTemplatesRequest self = new QueryTripProcessTemplatesRequest();
        return TeaModel.build(map, self);
    }

    public QueryTripProcessTemplatesRequest setCustomerCorpId(String customerCorpId) {
        this.customerCorpId = customerCorpId;
        return this;
    }
    public String getCustomerCorpId() {
        return this.customerCorpId;
    }

}
