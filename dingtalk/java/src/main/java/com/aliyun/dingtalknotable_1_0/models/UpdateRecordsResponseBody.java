// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class UpdateRecordsResponseBody extends TeaModel {
    @NameInMap("value")
    public java.util.List<UpdateRecordsResponseBodyValue> value;

    public static UpdateRecordsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateRecordsResponseBody self = new UpdateRecordsResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateRecordsResponseBody setValue(java.util.List<UpdateRecordsResponseBodyValue> value) {
        this.value = value;
        return this;
    }
    public java.util.List<UpdateRecordsResponseBodyValue> getValue() {
        return this.value;
    }

    public static class UpdateRecordsResponseBodyValue extends TeaModel {
        @NameInMap("id")
        public String id;

        public static UpdateRecordsResponseBodyValue build(java.util.Map<String, ?> map) throws Exception {
            UpdateRecordsResponseBodyValue self = new UpdateRecordsResponseBodyValue();
            return TeaModel.build(map, self);
        }

        public UpdateRecordsResponseBodyValue setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

    }

}
