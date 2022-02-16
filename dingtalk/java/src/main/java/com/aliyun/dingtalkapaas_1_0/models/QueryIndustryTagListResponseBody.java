// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapaas_1_0.models;

import com.aliyun.tea.*;

public class QueryIndustryTagListResponseBody extends TeaModel {
    @NameInMap("industryList")
    public java.util.List<String> industryList;

    public static QueryIndustryTagListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryIndustryTagListResponseBody self = new QueryIndustryTagListResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryIndustryTagListResponseBody setIndustryList(java.util.List<String> industryList) {
        this.industryList = industryList;
        return this;
    }
    public java.util.List<String> getIndustryList() {
        return this.industryList;
    }

}
