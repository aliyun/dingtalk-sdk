// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryBranchRequest extends TeaModel {
    @NameInMap("bankName")
    public String bankName;

    @NameInMap("city")
    public String city;

    @NameInMap("province")
    public String province;

    public static QueryBranchRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryBranchRequest self = new QueryBranchRequest();
        return TeaModel.build(map, self);
    }

    public QueryBranchRequest setBankName(String bankName) {
        this.bankName = bankName;
        return this;
    }
    public String getBankName() {
        return this.bankName;
    }

    public QueryBranchRequest setCity(String city) {
        this.city = city;
        return this;
    }
    public String getCity() {
        return this.city;
    }

    public QueryBranchRequest setProvince(String province) {
        this.province = province;
        return this;
    }
    public String getProvince() {
        return this.province;
    }

}
