// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class AlignObjectiveResponseBody extends TeaModel {
    // code
    @NameInMap("code")
    public Long code;

    // data
    @NameInMap("data")
    public AlignObjectiveResponseBodyData data;

    // message
    @NameInMap("message")
    public String message;

    // success
    @NameInMap("success")
    public Boolean success;

    public static AlignObjectiveResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AlignObjectiveResponseBody self = new AlignObjectiveResponseBody();
        return TeaModel.build(map, self);
    }

    public AlignObjectiveResponseBody setCode(Long code) {
        this.code = code;
        return this;
    }
    public Long getCode() {
        return this.code;
    }

    public AlignObjectiveResponseBody setData(AlignObjectiveResponseBodyData data) {
        this.data = data;
        return this;
    }
    public AlignObjectiveResponseBodyData getData() {
        return this.data;
    }

    public AlignObjectiveResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public AlignObjectiveResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class AlignObjectiveResponseBodyData extends TeaModel {
        @NameInMap("alignId")
        public java.io.InputStream alignId;

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

    public static class UnAlignObjectiveResponseBodyData extends TeaModel {
        @NameInMap("alignId")
        public java.io.InputStream alignId;

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
