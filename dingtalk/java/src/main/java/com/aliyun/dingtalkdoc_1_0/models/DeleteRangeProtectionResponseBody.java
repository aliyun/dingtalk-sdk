// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DeleteRangeProtectionResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>A1</p>
     */
    @NameInMap("a1Notation")
    public String a1Notation;

    public static DeleteRangeProtectionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteRangeProtectionResponseBody self = new DeleteRangeProtectionResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteRangeProtectionResponseBody setA1Notation(String a1Notation) {
        this.a1Notation = a1Notation;
        return this;
    }
    public String getA1Notation() {
        return this.a1Notation;
    }

}
