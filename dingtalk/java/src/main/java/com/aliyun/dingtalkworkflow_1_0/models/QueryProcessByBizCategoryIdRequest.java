// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class QueryProcessByBizCategoryIdRequest extends TeaModel {
    @NameInMap("bizType")
    public String bizType;

    @NameInMap("userId")
    public String userId;

    public static QueryProcessByBizCategoryIdRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryProcessByBizCategoryIdRequest self = new QueryProcessByBizCategoryIdRequest();
        return TeaModel.build(map, self);
    }

    public QueryProcessByBizCategoryIdRequest setBizType(String bizType) {
        this.bizType = bizType;
        return this;
    }
    public String getBizType() {
        return this.bizType;
    }

    public QueryProcessByBizCategoryIdRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
