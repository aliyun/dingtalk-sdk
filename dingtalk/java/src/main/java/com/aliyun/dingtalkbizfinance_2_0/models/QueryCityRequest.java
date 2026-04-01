// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryCityRequest extends TeaModel {
    @NameInMap("province")
    public String province;

    public static QueryCityRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCityRequest self = new QueryCityRequest();
        return TeaModel.build(map, self);
    }

    public QueryCityRequest setProvince(String province) {
        this.province = province;
        return this;
    }
    public String getProvince() {
        return this.province;
    }

}
