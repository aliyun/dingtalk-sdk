// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateCustomfieldValueResponseBody extends TeaModel {
    @NameInMap("result")
    public UpdateCustomfieldValueResponseBodyResult result;

    public static UpdateCustomfieldValueResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateCustomfieldValueResponseBody self = new UpdateCustomfieldValueResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateCustomfieldValueResponseBody setResult(UpdateCustomfieldValueResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpdateCustomfieldValueResponseBodyResult getResult() {
        return this.result;
    }

    public static class UpdateCustomfieldValueResponseBodyResultCustomFieldsValue extends TeaModel {
        @NameInMap("id")
        public String id;

        @NameInMap("thumbUrl")
        public String thumbUrl;

        /**
         * <strong>example:</strong>
         * <p>我是具体显示值</p>
         */
        @NameInMap("title")
        public String title;

        public static UpdateCustomfieldValueResponseBodyResultCustomFieldsValue build(java.util.Map<String, ?> map) throws Exception {
            UpdateCustomfieldValueResponseBodyResultCustomFieldsValue self = new UpdateCustomfieldValueResponseBodyResultCustomFieldsValue();
            return TeaModel.build(map, self);
        }

        public UpdateCustomfieldValueResponseBodyResultCustomFieldsValue setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public UpdateCustomfieldValueResponseBodyResultCustomFieldsValue setThumbUrl(String thumbUrl) {
            this.thumbUrl = thumbUrl;
            return this;
        }
        public String getThumbUrl() {
            return this.thumbUrl;
        }

        public UpdateCustomfieldValueResponseBodyResultCustomFieldsValue setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class UpdateCustomfieldValueResponseBodyResultCustomFields extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>62fb0b77xxxxx</p>
         */
        @NameInMap("customFieldId")
        public String customFieldId;

        @NameInMap("value")
        public java.util.List<UpdateCustomfieldValueResponseBodyResultCustomFieldsValue> value;

        public static UpdateCustomfieldValueResponseBodyResultCustomFields build(java.util.Map<String, ?> map) throws Exception {
            UpdateCustomfieldValueResponseBodyResultCustomFields self = new UpdateCustomfieldValueResponseBodyResultCustomFields();
            return TeaModel.build(map, self);
        }

        public UpdateCustomfieldValueResponseBodyResultCustomFields setCustomFieldId(String customFieldId) {
            this.customFieldId = customFieldId;
            return this;
        }
        public String getCustomFieldId() {
            return this.customFieldId;
        }

        public UpdateCustomfieldValueResponseBodyResultCustomFields setValue(java.util.List<UpdateCustomfieldValueResponseBodyResultCustomFieldsValue> value) {
            this.value = value;
            return this;
        }
        public java.util.List<UpdateCustomfieldValueResponseBodyResultCustomFieldsValue> getValue() {
            return this.value;
        }

    }

    public static class UpdateCustomfieldValueResponseBodyResult extends TeaModel {
        @NameInMap("customFields")
        public java.util.List<UpdateCustomfieldValueResponseBodyResultCustomFields> customFields;

        public static UpdateCustomfieldValueResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateCustomfieldValueResponseBodyResult self = new UpdateCustomfieldValueResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateCustomfieldValueResponseBodyResult setCustomFields(java.util.List<UpdateCustomfieldValueResponseBodyResultCustomFields> customFields) {
            this.customFields = customFields;
            return this;
        }
        public java.util.List<UpdateCustomfieldValueResponseBodyResultCustomFields> getCustomFields() {
            return this.customFields;
        }

    }

}
