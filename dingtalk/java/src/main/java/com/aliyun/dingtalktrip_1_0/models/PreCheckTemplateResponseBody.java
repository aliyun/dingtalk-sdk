// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class PreCheckTemplateResponseBody extends TeaModel {
    @NameInMap("result")
    public PreCheckTemplateResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static PreCheckTemplateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PreCheckTemplateResponseBody self = new PreCheckTemplateResponseBody();
        return TeaModel.build(map, self);
    }

    public PreCheckTemplateResponseBody setResult(PreCheckTemplateResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public PreCheckTemplateResponseBodyResult getResult() {
        return this.result;
    }

    public PreCheckTemplateResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class PreCheckTemplateResponseBodyResultBlockRecords extends TeaModel {
        @NameInMap("blockType")
        public String blockType;

        @NameInMap("reason")
        public String reason;

        public static PreCheckTemplateResponseBodyResultBlockRecords build(java.util.Map<String, ?> map) throws Exception {
            PreCheckTemplateResponseBodyResultBlockRecords self = new PreCheckTemplateResponseBodyResultBlockRecords();
            return TeaModel.build(map, self);
        }

        public PreCheckTemplateResponseBodyResultBlockRecords setBlockType(String blockType) {
            this.blockType = blockType;
            return this;
        }
        public String getBlockType() {
            return this.blockType;
        }

        public PreCheckTemplateResponseBodyResultBlockRecords setReason(String reason) {
            this.reason = reason;
            return this;
        }
        public String getReason() {
            return this.reason;
        }

    }

    public static class PreCheckTemplateResponseBodyResult extends TeaModel {
        @NameInMap("blockRecords")
        public java.util.List<PreCheckTemplateResponseBodyResultBlockRecords> blockRecords;

        @NameInMap("pass")
        public Boolean pass;

        public static PreCheckTemplateResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            PreCheckTemplateResponseBodyResult self = new PreCheckTemplateResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public PreCheckTemplateResponseBodyResult setBlockRecords(java.util.List<PreCheckTemplateResponseBodyResultBlockRecords> blockRecords) {
            this.blockRecords = blockRecords;
            return this;
        }
        public java.util.List<PreCheckTemplateResponseBodyResultBlockRecords> getBlockRecords() {
            return this.blockRecords;
        }

        public PreCheckTemplateResponseBodyResult setPass(Boolean pass) {
            this.pass = pass;
            return this;
        }
        public Boolean getPass() {
            return this.pass;
        }

    }

}
