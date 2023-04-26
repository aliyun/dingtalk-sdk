// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkswform_1_0.models;

import com.aliyun.tea.*;

public class GetFormInstanceResponseBody extends TeaModel {
    @NameInMap("result")
    public GetFormInstanceResponseBodyResult result;

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
        @NameInMap("key")
        public String key;

        @NameInMap("label")
        public String label;

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
        @NameInMap("createTime")
        public String createTime;

        @NameInMap("creator")
        public String creator;

        @NameInMap("formCode")
        public String formCode;

        @NameInMap("forms")
        public java.util.List<GetFormInstanceResponseBodyResultForms> forms;

        @NameInMap("modifyTime")
        public String modifyTime;

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
