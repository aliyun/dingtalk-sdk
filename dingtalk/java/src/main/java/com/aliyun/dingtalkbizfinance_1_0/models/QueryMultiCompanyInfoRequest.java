// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryMultiCompanyInfoRequest extends TeaModel {
    @NameInMap("startStatus")
    public Boolean startStatus;

    public static QueryMultiCompanyInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryMultiCompanyInfoRequest self = new QueryMultiCompanyInfoRequest();
        return TeaModel.build(map, self);
    }

    public QueryMultiCompanyInfoRequest setStartStatus(Boolean startStatus) {
        this.startStatus = startStatus;
        return this;
    }
    public Boolean getStartStatus() {
        return this.startStatus;
    }

}
