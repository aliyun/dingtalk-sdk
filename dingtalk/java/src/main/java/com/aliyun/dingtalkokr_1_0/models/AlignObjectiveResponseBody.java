// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class AlignObjectiveResponseBody extends TeaModel {
    @NameInMap("data")
    public AlignObjectiveResponseBodyData data;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static AlignObjectiveResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AlignObjectiveResponseBody self = new AlignObjectiveResponseBody();
        return TeaModel.build(map, self);
    }

    public AlignObjectiveResponseBody setData(AlignObjectiveResponseBodyData data) {
        this.data = data;
        return this;
    }
    public AlignObjectiveResponseBodyData getData() {
        return this.data;
    }

    public AlignObjectiveResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class AlignObjectiveResponseBodyData extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>59YD</p>
         */
        @NameInMap("alignId")
        public java.io.InputStream alignId;

        /**
         * <strong>example:</strong>
         * <p>5dAX8</p>
         */
        @NameInMap("id")
        public java.io.InputStream id;

        public static AlignObjectiveResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            AlignObjectiveResponseBodyData self = new AlignObjectiveResponseBodyData();
            return TeaModel.build(map, self);
        }

        public AlignObjectiveResponseBodyData setAlignId(java.io.InputStream alignId) {
            this.alignId = alignId;
            return this;
        }
        public java.io.InputStream getAlignId() {
            return this.alignId;
        }

        public AlignObjectiveResponseBodyData setId(java.io.InputStream id) {
            this.id = id;
            return this;
        }
        public java.io.InputStream getId() {
            return this.id;
        }

    }

}
