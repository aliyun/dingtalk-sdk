// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class OpportunitySearchResponseBody extends TeaModel {
    @NameInMap("opportunityExist")
    public Boolean opportunityExist;

    public static OpportunitySearchResponseBody build(java.util.Map<String, ?> map) throws Exception {
        OpportunitySearchResponseBody self = new OpportunitySearchResponseBody();
        return TeaModel.build(map, self);
    }

    public OpportunitySearchResponseBody setOpportunityExist(Boolean opportunityExist) {
        this.opportunityExist = opportunityExist;
        return this;
    }
    public Boolean getOpportunityExist() {
        return this.opportunityExist;
    }

}
