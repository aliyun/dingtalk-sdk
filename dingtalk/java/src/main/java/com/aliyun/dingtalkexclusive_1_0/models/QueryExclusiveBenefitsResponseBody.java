// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class QueryExclusiveBenefitsResponseBody extends TeaModel {
    @NameInMap("benefitsList")
    public java.util.List<String> benefitsList;

    public static QueryExclusiveBenefitsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryExclusiveBenefitsResponseBody self = new QueryExclusiveBenefitsResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryExclusiveBenefitsResponseBody setBenefitsList(java.util.List<String> benefitsList) {
        this.benefitsList = benefitsList;
        return this;
    }
    public java.util.List<String> getBenefitsList() {
        return this.benefitsList;
    }

}
