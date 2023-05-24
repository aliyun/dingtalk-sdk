// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SupplyUpdateMemberResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static SupplyUpdateMemberResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SupplyUpdateMemberResponseBody self = new SupplyUpdateMemberResponseBody();
        return TeaModel.build(map, self);
    }

    public SupplyUpdateMemberResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
