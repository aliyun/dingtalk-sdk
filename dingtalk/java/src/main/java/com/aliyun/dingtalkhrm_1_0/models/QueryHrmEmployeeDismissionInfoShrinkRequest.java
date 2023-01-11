// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class QueryHrmEmployeeDismissionInfoShrinkRequest extends TeaModel {
    /**
     * <p>员工 ids</p>
     */
    @NameInMap("userIdList")
    public String userIdListShrink;

    public static QueryHrmEmployeeDismissionInfoShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryHrmEmployeeDismissionInfoShrinkRequest self = new QueryHrmEmployeeDismissionInfoShrinkRequest();
        return TeaModel.build(map, self);
    }

    public QueryHrmEmployeeDismissionInfoShrinkRequest setUserIdListShrink(String userIdListShrink) {
        this.userIdListShrink = userIdListShrink;
        return this;
    }
    public String getUserIdListShrink() {
        return this.userIdListShrink;
    }

}
