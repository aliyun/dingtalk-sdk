// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class QueryCardVisitorStatisticDataRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>RCsp7PJmmTUr7w0hbs9aKAiEiE</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static QueryCardVisitorStatisticDataRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCardVisitorStatisticDataRequest self = new QueryCardVisitorStatisticDataRequest();
        return TeaModel.build(map, self);
    }

    public QueryCardVisitorStatisticDataRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
