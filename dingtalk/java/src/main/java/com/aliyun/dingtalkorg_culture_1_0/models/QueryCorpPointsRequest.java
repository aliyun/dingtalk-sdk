// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class QueryCorpPointsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>042216842933</p>
     */
    @NameInMap("optUserId")
    public String optUserId;

    public static QueryCorpPointsRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCorpPointsRequest self = new QueryCorpPointsRequest();
        return TeaModel.build(map, self);
    }

    public QueryCorpPointsRequest setOptUserId(String optUserId) {
        this.optUserId = optUserId;
        return this;
    }
    public String getOptUserId() {
        return this.optUserId;
    }

}
