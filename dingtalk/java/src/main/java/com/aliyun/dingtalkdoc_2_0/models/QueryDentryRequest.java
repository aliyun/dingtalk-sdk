// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class QueryDentryRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>false</p>
     */
    @NameInMap("includeSpace")
    public Boolean includeSpace;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>abcd</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static QueryDentryRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryDentryRequest self = new QueryDentryRequest();
        return TeaModel.build(map, self);
    }

    public QueryDentryRequest setIncludeSpace(Boolean includeSpace) {
        this.includeSpace = includeSpace;
        return this;
    }
    public Boolean getIncludeSpace() {
        return this.includeSpace;
    }

    public QueryDentryRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
