// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class SaveCustomWaterMarkTemplateResponseBody extends TeaModel {
    /**
     * <p>返回对象。</p>
     */
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
        /**
         * <p>模板的表单Code。</p>
         */
        @NameInMap("formCode")
        public String formCode;

        /**
         * <p>模板的水印ID。</p>
         */
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
