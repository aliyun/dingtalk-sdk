// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class UpdateRangeResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>a1_notation</p>
     */
    @NameInMap("a1Notation")
    public String a1Notation;

    public static UpdateRangeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateRangeResponseBody self = new UpdateRangeResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateRangeResponseBody setA1Notation(String a1Notation) {
        this.a1Notation = a1Notation;
        return this;
    }
    public String getA1Notation() {
        return this.a1Notation;
    }

}
