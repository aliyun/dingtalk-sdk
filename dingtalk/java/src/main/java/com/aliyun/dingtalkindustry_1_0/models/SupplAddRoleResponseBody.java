// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplAddRoleResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>1213</p>
     */
    @NameInMap("result")
    public String result;

    public static SupplAddRoleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SupplAddRoleResponseBody self = new SupplAddRoleResponseBody();
        return TeaModel.build(map, self);
    }

    public SupplAddRoleResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
