// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class QueryHrmEmployeeDismissionInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userIdList")
    public java.util.List<String> userIdList;

    public static QueryHrmEmployeeDismissionInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryHrmEmployeeDismissionInfoRequest self = new QueryHrmEmployeeDismissionInfoRequest();
        return TeaModel.build(map, self);
    }

    public QueryHrmEmployeeDismissionInfoRequest setUserIdList(java.util.List<String> userIdList) {
        this.userIdList = userIdList;
        return this;
    }
    public java.util.List<String> getUserIdList() {
        return this.userIdList;
    }

}
