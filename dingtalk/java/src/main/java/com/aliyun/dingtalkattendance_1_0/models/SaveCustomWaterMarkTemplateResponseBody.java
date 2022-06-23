// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class SaveCustomWaterMarkTemplateResponseBody extends TeaModel {
    // 返回对象。
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
        // 模板的表单Code。
        @NameInMap("formCode")
        public String formCode;

        // 模板的水印ID。
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
