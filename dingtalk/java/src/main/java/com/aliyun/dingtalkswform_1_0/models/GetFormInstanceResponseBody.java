// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkswform_1_0.models;

import com.aliyun.tea.*;

public class GetFormInstanceResponseBody extends TeaModel {
    // 返回结果对象。
    @NameInMap("result")
    public GetFormInstanceResponseBodyResult result;

    // 是否成功。
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
        // 表单控件key。
        @NameInMap("key")
        public String key;

        // 表单主题。  当label字段为空或不存在时，忽略这个label和value。
        @NameInMap("label")
        public String label;

        // 表单的值。
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
        // 创建时间。iso8601格式。
        @NameInMap("createTime")
        public String createTime;

        // 创建者userid
        @NameInMap("creator")
        public String creator;

        // 填表code，用此code可调接口获取填表实例列表。
        @NameInMap("formCode")
        public String formCode;

        // 表单内容列表。
        @NameInMap("forms")
        public java.util.List<GetFormInstanceResponseBodyResultForms> forms;

        // 更新时间。iso8601格式。
        @NameInMap("modifyTime")
        public String modifyTime;

        // 填表名称。
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
