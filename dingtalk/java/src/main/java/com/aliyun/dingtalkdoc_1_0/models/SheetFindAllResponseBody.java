// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SheetFindAllResponseBody extends TeaModel {
    @NameInMap("value")
    public java.util.List<SheetFindAllResponseBodyValue> value;

    public static SheetFindAllResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SheetFindAllResponseBody self = new SheetFindAllResponseBody();
        return TeaModel.build(map, self);
    }

    public SheetFindAllResponseBody setValue(java.util.List<SheetFindAllResponseBodyValue> value) {
        this.value = value;
        return this;
    }
    public java.util.List<SheetFindAllResponseBodyValue> getValue() {
        return this.value;
    }

    public static class SheetFindAllResponseBodyValue extends TeaModel {
        @NameInMap("a1Notation")
        public String a1Notation;

        public static SheetFindAllResponseBodyValue build(java.util.Map<String, ?> map) throws Exception {
            SheetFindAllResponseBodyValue self = new SheetFindAllResponseBodyValue();
            return TeaModel.build(map, self);
        }

        public SheetFindAllResponseBodyValue setA1Notation(String a1Notation) {
            this.a1Notation = a1Notation;
            return this;
        }
        public String getA1Notation() {
            return this.a1Notation;
        }

    }

}
