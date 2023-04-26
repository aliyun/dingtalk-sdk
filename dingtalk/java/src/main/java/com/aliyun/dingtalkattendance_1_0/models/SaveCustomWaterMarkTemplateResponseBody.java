// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class SaveCustomWaterMarkTemplateResponseBody extends TeaModel {
    @NameInMap("result")
    public SaveCustomWaterMarkTemplateResponseBodyResult result;

    public static SaveCustomWaterMarkTemplateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SaveCustomWaterMarkTemplateResponseBody self = new SaveCustomWaterMarkTemplateResponseBody();
        return TeaModel.build(map, self);
    }

    public SaveCustomWaterMarkTemplateResponseBody setResult(SaveCustomWaterMarkTemplateResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SaveCustomWaterMarkTemplateResponseBodyResult getResult() {
        return this.result;
    }

    public static class SaveCustomWaterMarkTemplateResponseBodyResult extends TeaModel {
        @NameInMap("formCode")
        public String formCode;

        @NameInMap("waterMarkId")
        public String waterMarkId;

        public static SaveCustomWaterMarkTemplateResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SaveCustomWaterMarkTemplateResponseBodyResult self = new SaveCustomWaterMarkTemplateResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SaveCustomWaterMarkTemplateResponseBodyResult setFormCode(String formCode) {
            this.formCode = formCode;
            return this;
        }
        public String getFormCode() {
            return this.formCode;
        }

        public SaveCustomWaterMarkTemplateResponseBodyResult setWaterMarkId(String waterMarkId) {
            this.waterMarkId = waterMarkId;
            return this;
        }
        public String getWaterMarkId() {
            return this.waterMarkId;
        }

    }

}
