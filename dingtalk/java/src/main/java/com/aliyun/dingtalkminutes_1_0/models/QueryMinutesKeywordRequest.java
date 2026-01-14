// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryMinutesKeywordRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>D5xxxxxxxxxgiEiE</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static QueryMinutesKeywordRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryMinutesKeywordRequest self = new QueryMinutesKeywordRequest();
        return TeaModel.build(map, self);
    }

    public QueryMinutesKeywordRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
