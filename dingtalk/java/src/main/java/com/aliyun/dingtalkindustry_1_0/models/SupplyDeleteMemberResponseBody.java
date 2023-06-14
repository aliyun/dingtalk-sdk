// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyDeleteMemberResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static SupplyDeleteMemberResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SupplyDeleteMemberResponseBody self = new SupplyDeleteMemberResponseBody();
        return TeaModel.build(map, self);
    }

    public SupplyDeleteMemberResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
