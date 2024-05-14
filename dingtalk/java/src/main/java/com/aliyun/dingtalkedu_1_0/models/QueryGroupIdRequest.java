// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupIdRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("sn")
    public String sn;

    public static QueryGroupIdRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupIdRequest self = new QueryGroupIdRequest();
        return TeaModel.build(map, self);
    }

    public QueryGroupIdRequest setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

}
