// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class GetIndustryTypeResponseBody extends TeaModel {
    @NameInMap("industryType")
    public String industryType;

    public static GetIndustryTypeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetIndustryTypeResponseBody self = new GetIndustryTypeResponseBody();
        return TeaModel.build(map, self);
    }

    public GetIndustryTypeResponseBody setIndustryType(String industryType) {
        this.industryType = industryType;
        return this;
    }
    public String getIndustryType() {
        return this.industryType;
    }

}
