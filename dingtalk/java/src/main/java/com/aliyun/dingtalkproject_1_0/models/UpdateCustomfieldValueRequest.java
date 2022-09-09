// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateCustomfieldValueRequest extends TeaModel {
    // 自定义字段id
    @NameInMap("customfieldId")
    public String customfieldId;

    // 自定义字段名
    @NameInMap("customfieldName")
    public String customfieldName;

    // 自定义字段值列表，最多10个
    @NameInMap("value")
    public java.util.List<UpdateCustomfieldValueRequestValue> value;

    public static UpdateCustomfieldValueRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateCustomfieldValueRequest self = new UpdateCustomfieldValueRequest();
        return TeaModel.build(map, self);
    }

    public UpdateCustomfieldValueRequest setCustomfieldId(String customfieldId) {
        this.customfieldId = customfieldId;
        return this;
    }
    public String getCustomfieldId() {
        return this.customfieldId;
    }

    public UpdateCustomfieldValueRequest setCustomfieldName(String customfieldName) {
        this.customfieldName = customfieldName;
        return this;
    }
    public String getCustomfieldName() {
        return this.customfieldName;
    }

    public UpdateCustomfieldValueRequest setValue(java.util.List<UpdateCustomfieldValueRequestValue> value) {
        this.value = value;
        return this;
    }
    public java.util.List<UpdateCustomfieldValueRequestValue> getValue() {
        return this.value;
    }

    public static class UpdateCustomfieldValueRequestValue extends TeaModel {
        // 自定义字段显示值
        @NameInMap("title")
        public String title;

        public static UpdateCustomfieldValueRequestValue build(java.util.Map<String, ?> map) throws Exception {
            UpdateCustomfieldValueRequestValue self = new UpdateCustomfieldValueRequestValue();
            return TeaModel.build(map, self);
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