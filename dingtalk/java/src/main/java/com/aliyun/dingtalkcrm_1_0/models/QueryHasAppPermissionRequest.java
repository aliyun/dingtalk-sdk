// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryHasAppPermissionRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorUserId")
    public String operatorUserId;

    public static QueryHasAppPermissionRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryHasAppPermissionRequest self = new QueryHasAppPermissionRequest();
        return TeaModel.build(map, self);
    }

    public QueryHasAppPermissionRequest setOperatorUserId(String operatorUserId) {
        this.operatorUserId = operatorUserId;
        return this;
    }
    public String getOperatorUserId() {
        return this.operatorUserId;
    }

}
