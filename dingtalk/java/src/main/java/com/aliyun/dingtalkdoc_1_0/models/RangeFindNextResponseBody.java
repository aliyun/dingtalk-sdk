// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class RangeFindNextResponseBody extends TeaModel {
    // 找到的单元格的地址，使用A1表示法
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
