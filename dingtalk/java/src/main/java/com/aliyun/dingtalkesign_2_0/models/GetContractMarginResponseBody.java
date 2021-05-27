// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class GetContractMarginResponseBody extends TeaModel {
    @NameInMap("margin")
    public Float margin;

    public static GetContractMarginResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetContractMarginResponseBody self = new GetContractMarginResponseBody();
        return TeaModel.build(map, self);
    }

    public GetContractMarginResponseBody setMargin(Float margin) {
        this.margin = margin;
        return this;
    }
    public Float getMargin() {
        return this.margin;
    }

}
