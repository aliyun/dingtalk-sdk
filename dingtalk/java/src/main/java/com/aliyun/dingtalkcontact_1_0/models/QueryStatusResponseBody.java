// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class QueryStatusResponseBody extends TeaModel {
    @NameInMap("disable")
    public Boolean disable;

    public static QueryStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryStatusResponseBody self = new QueryStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryStatusResponseBody setDisable(Boolean disable) {
        this.disable = disable;
        return this;
    }
    public Boolean getDisable() {
        return this.disable;
    }

}
