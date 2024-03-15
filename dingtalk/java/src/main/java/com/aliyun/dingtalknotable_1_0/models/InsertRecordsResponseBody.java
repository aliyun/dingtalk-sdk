// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class InsertRecordsResponseBody extends TeaModel {
    @NameInMap("value")
    public java.util.List<InsertRecordsResponseBodyValue> value;

    public static InsertRecordsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        InsertRecordsResponseBody self = new InsertRecordsResponseBody();
        return TeaModel.build(map, self);
    }

    public InsertRecordsResponseBody setValue(java.util.List<InsertRecordsResponseBodyValue> value) {
        this.value = value;
        return this;
    }
    public java.util.List<InsertRecordsResponseBodyValue> getValue() {
        return this.value;
    }

    public static class InsertRecordsResponseBodyValue extends TeaModel {
        @NameInMap("id")
        public String id;

        public static InsertRecordsResponseBodyValue build(java.util.Map<String, ?> map) throws Exception {
            InsertRecordsResponseBodyValue self = new InsertRecordsResponseBodyValue();
            return TeaModel.build(map, self);
        }

        public InsertRecordsResponseBodyValue setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

    }

}
