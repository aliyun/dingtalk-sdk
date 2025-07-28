// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateCustomfieldValueRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>62a010c153c2ef52xxxx</p>
     */
    @NameInMap("customFieldId")
    public String customFieldId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>自定义字段-文本</p>
     */
    @NameInMap("customFieldName")
    public String customFieldName;

    @NameInMap("value")
    public java.util.List<UpdateCustomfieldValueRequestValue> value;

    public static UpdateCustomfieldValueRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateCustomfieldValueRequest self = new UpdateCustomfieldValueRequest();
        return TeaModel.build(map, self);
    }

    public UpdateCustomfieldValueRequest setCustomFieldId(String customFieldId) {
        this.customFieldId = customFieldId;
        return this;
    }
    public String getCustomFieldId() {
        return this.customFieldId;
    }

    public UpdateCustomfieldValueRequest setCustomFieldName(String customFieldName) {
        this.customFieldName = customFieldName;
        return this;
    }
    public String getCustomFieldName() {
        return this.customFieldName;
    }

    public UpdateCustomfieldValueRequest setValue(java.util.List<UpdateCustomfieldValueRequestValue> value) {
        this.value = value;
        return this;
    }
    public java.util.List<UpdateCustomfieldValueRequestValue> getValue() {
        return this.value;
    }

    public static class UpdateCustomfieldValueRequestValue extends TeaModel {
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

        public static UpdateCustomfieldValueRequestValue build(java.util.Map<String, ?> map) throws Exception {
            UpdateCustomfieldValueRequestValue self = new UpdateCustomfieldValueRequestValue();
            return TeaModel.build(map, self);
        }

        public UpdateCustomfieldValueRequestValue setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public UpdateCustomfieldValueRequestValue setThumbUrl(String thumbUrl) {
            this.thumbUrl = thumbUrl;
            return this;
        }
        public String getThumbUrl() {
            return this.thumbUrl;
        }

        public UpdateCustomfieldValueRequestValue setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
