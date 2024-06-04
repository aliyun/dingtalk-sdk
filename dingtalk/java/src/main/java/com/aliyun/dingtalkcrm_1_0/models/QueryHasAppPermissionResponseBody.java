// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryHasAppPermissionResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static QueryHasAppPermissionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryHasAppPermissionResponseBody self = new QueryHasAppPermissionResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryHasAppPermissionResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
