// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class UnAlignObjectiveResponseBody extends TeaModel {
    // data
    @NameInMap("data")
    public UnAlignObjectiveResponseBodyData data;

    // success
    @NameInMap("success")
    public Boolean success;

    public static UnAlignObjectiveResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UnAlignObjectiveResponseBody self = new UnAlignObjectiveResponseBody();
        return TeaModel.build(map, self);
    }

    public UnAlignObjectiveResponseBody setData(UnAlignObjectiveResponseBodyData data) {
        this.data = data;
        return this;
    }
    public UnAlignObjectiveResponseBodyData getData() {
        return this.data;
    }

    public UnAlignObjectiveResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class UnAlignObjectiveResponseBodyData extends TeaModel {
        // 对齐的 Objective ID。
        @NameInMap("alignId")
        public java.io.InputStream alignId;

        // 当前 Objective ID。
        @NameInMap("id")
        public java.io.InputStream id;

        public static UnAlignObjectiveResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            UnAlignObjectiveResponseBodyData self = new UnAlignObjectiveResponseBodyData();
            return TeaModel.build(map, self);
        }

        public UnAlignObjectiveResponseBodyData setAlignId(java.io.InputStream alignId) {
            this.alignId = alignId;
            return this;
        }
        public java.io.InputStream getAlignId() {
            return this.alignId;
        }

        public UnAlignObjectiveResponseBodyData setId(java.io.InputStream id) {
            this.id = id;
            return this;
        }
        public java.io.InputStream getId() {
            return this.id;
        }

    }

}
