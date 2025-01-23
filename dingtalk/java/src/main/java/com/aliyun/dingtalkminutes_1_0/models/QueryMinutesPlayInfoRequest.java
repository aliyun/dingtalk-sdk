// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryMinutesPlayInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static QueryMinutesPlayInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryMinutesPlayInfoRequest self = new QueryMinutesPlayInfoRequest();
        return TeaModel.build(map, self);
    }

    public QueryMinutesPlayInfoRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
