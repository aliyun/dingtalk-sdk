// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryMinutesStatusRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static QueryMinutesStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryMinutesStatusRequest self = new QueryMinutesStatusRequest();
        return TeaModel.build(map, self);
    }

    public QueryMinutesStatusRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
