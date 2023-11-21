// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class QueryTripProcessTemplatesRequest extends TeaModel {
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
