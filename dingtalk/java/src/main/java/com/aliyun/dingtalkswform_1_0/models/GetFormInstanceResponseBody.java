// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkswform_1_0.models;

import com.aliyun.tea.*;

public class GetFormInstanceResponseBody extends TeaModel {
    @NameInMap("result")
    public GetFormInstanceResponseBodyResult result;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static GetFormInstanceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFormInstanceResponseBody self = new GetFormInstanceResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFormInstanceResponseBody setResult(GetFormInstanceResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetFormInstanceResponseBodyResult getResult() {
        return this.result;
    }

    public GetFormInstanceResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetFormInstanceResponseBodyResultForms extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>TextareaField_KGAW58AQ</p>
         */
        @NameInMap("key")
        public String key;

        /**
         * <strong>example:</strong>
         * <p>你希望的主题</p>
         */
        @NameInMap("label")
        public String label;

        /**
         * <strong>example:</strong>
         * <p>操作演示</p>
         */
        @NameInMap("value")
        public String value;

        public static GetFormInstanceResponseBodyResultForms build(java.util.Map<String, ?> map) throws Exception {
            GetFormInstanceResponseBodyResultForms self = new GetFormInstanceResponseBodyResultForms();
            return TeaModel.build(map, self);
        }

        public GetFormInstanceResponseBodyResultForms setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public GetFormInstanceResponseBodyResultForms setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public GetFormInstanceResponseBodyResultForms setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class GetFormInstanceResponseBodyResult extends TeaModel {
        /**
         * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
         * 
         * <strong>example:</strong>
         * <p>2022-07-27T18:53Z</p>
         */
        @NameInMap("createTime")
        public String createTime;

        /**
         * <strong>example:</strong>
         * <p>manager4220</p>
         */
        @NameInMap("creator")
        public String creator;

        /**
         * <strong>example:</strong>
         * <p>PROC-E5BD2166-B6F4-xxxx</p>
         */
        @NameInMap("formCode")
        public String formCode;

        @NameInMap("forms")
        public java.util.List<GetFormInstanceResponseBodyResultForms> forms;

        /**
         * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
         * 
         * <strong>example:</strong>
         * <p>2022-07-27T18:53Z</p>
         */
        @NameInMap("modifyTime")
        public String modifyTime;

        /**
         * <strong>example:</strong>
         * <p>智能填表测试</p>
         */
        @NameInMap("title")
        public String title;

        public static GetFormInstanceResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetFormInstanceResponseBodyResult self = new GetFormInstanceResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetFormInstanceResponseBodyResult setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public GetFormInstanceResponseBodyResult setCreator(String creator) {
            this.creator = creator;
            return this;
        }
        public String getCreator() {
            return this.creator;
        }

        public GetFormInstanceResponseBodyResult setFormCode(String formCode) {
            this.formCode = formCode;
            return this;
        }
        public String getFormCode() {
            return this.formCode;
        }

        public GetFormInstanceResponseBodyResult setForms(java.util.List<GetFormInstanceResponseBodyResultForms> forms) {
            this.forms = forms;
            return this;
        }
        public java.util.List<GetFormInstanceResponseBodyResultForms> getForms() {
            return this.forms;
        }

        public GetFormInstanceResponseBodyResult setModifyTime(String modifyTime) {
            this.modifyTime = modifyTime;
            return this;
        }
        public String getModifyTime() {
            return this.modifyTime;
        }

        public GetFormInstanceResponseBodyResult setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
