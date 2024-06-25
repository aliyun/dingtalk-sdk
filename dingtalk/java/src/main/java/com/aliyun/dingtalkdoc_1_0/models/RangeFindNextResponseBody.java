// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class RangeFindNextResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>A2</p>
     */
    @NameInMap("a1Notation")
    public String a1Notation;

    public static RangeFindNextResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RangeFindNextResponseBody self = new RangeFindNextResponseBody();
        return TeaModel.build(map, self);
    }

    public RangeFindNextResponseBody setA1Notation(String a1Notation) {
        this.a1Notation = a1Notation;
        return this;
    }
    public String getA1Notation() {
        return this.a1Notation;
    }

}
