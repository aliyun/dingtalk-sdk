// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyDeleteRoleResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static SupplyDeleteRoleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SupplyDeleteRoleResponseBody self = new SupplyDeleteRoleResponseBody();
        return TeaModel.build(map, self);
    }

    public SupplyDeleteRoleResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
