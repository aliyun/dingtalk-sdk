// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryMinutesChaptersRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>D5xxxxxxxxxgiEiE</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static QueryMinutesChaptersRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryMinutesChaptersRequest self = new QueryMinutesChaptersRequest();
        return TeaModel.build(map, self);
    }

    public QueryMinutesChaptersRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
