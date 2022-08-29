// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class ClearResponseBody extends TeaModel {
    // 单元格地址
    @NameInMap("a1Notation")
    public String a1Notation;

    public static ClearResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ClearResponseBody self = new ClearResponseBody();
        return TeaModel.build(map, self);
    }

    public ClearResponseBody setA1Notation(String a1Notation) {
        this.a1Notation = a1Notation;
        return this;
    }
    public String getA1Notation() {
        return this.a1Notation;
    }

}
