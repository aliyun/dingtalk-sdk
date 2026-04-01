// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class AppendRowsResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>a1_notation</p>
     */
    @NameInMap("a1Notation")
    public String a1Notation;

    public static AppendRowsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AppendRowsResponseBody self = new AppendRowsResponseBody();
        return TeaModel.build(map, self);
    }

    public AppendRowsResponseBody setA1Notation(String a1Notation) {
        this.a1Notation = a1Notation;
        return this;
    }
    public String getA1Notation() {
        return this.a1Notation;
    }

}
