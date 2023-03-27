// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreateProjectCustomfieldStatusRequest extends TeaModel {
    /**
     * <p>自定义字段ID。</p>
     */
    @NameInMap("customfieldId")
    public String customfieldId;

    /**
     * <p>自定义字段InstanceId(如果提供自定义字段ID 或者 自定义字段名称 则忽略)。</p>
     */
    @NameInMap("customfieldInstanceId")
    public String customfieldInstanceId;

    /**
     * <p>自定义字段名称(如果提供自定义字段ID 则忽略)。</p>
     */
    @NameInMap("customfieldName")
    public String customfieldName;

    /**
     * <p>字段值集合。</p>
     */
    @NameInMap("value")
    public java.util.List<CreateProjectCustomfieldStatusRequestValue> value;

    public static CreateProjectCustomfieldStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateProjectCustomfieldStatusRequest self = new CreateProjectCustomfieldStatusRequest();
        return TeaModel.build(map, self);
    }

    public CreateProjectCustomfieldStatusRequest setCustomfieldId(String customfieldId) {
        this.customfieldId = customfieldId;
        return this;
    }
    public String getCustomfieldId() {
        return this.customfieldId;
    }

    public CreateProjectCustomfieldStatusRequest setCustomfieldInstanceId(String customfieldInstanceId) {
        this.customfieldInstanceId = customfieldInstanceId;
        return this;
    }
    public String getCustomfieldInstanceId() {
        return this.customfieldInstanceId;
    }

    public CreateProjectCustomfieldStatusRequest setCustomfieldName(String customfieldName) {
        this.customfieldName = customfieldName;
        return this;
    }
    public String getCustomfieldName() {
        return this.customfieldName;
    }

    public CreateProjectCustomfieldStatusRequest setValue(java.util.List<CreateProjectCustomfieldStatusRequestValue> value) {
        this.value = value;
        return this;
    }
    public java.util.List<CreateProjectCustomfieldStatusRequestValue> getValue() {
        return this.value;
    }

    public static class CreateProjectCustomfieldStatusRequestValue extends TeaModel {
        /**
         * <p>字段值id。</p>
         */
        @NameInMap("fieldvalueId")
        public String fieldvalueId;

        /**
         * <p>字段值元信息(json格式)。</p>
         */
        @NameInMap("metaString")
        public String metaString;

        /**
         * <p>字段值渲染值。</p>
         */
        @NameInMap("title")
        public String title;

        public static CreateProjectCustomfieldStatusRequestValue build(java.util.Map<String, ?> map) throws Exception {
            CreateProjectCustomfieldStatusRequestValue self = new CreateProjectCustomfieldStatusRequestValue();
            return TeaModel.build(map, self);
        }

        public CreateProjectCustomfieldStatusRequestValue setFieldvalueId(String fieldvalueId) {
            this.fieldvalueId = fieldvalueId;
            return this;
        }
        public String getFieldvalueId() {
            return this.fieldvalueId;
        }

        public CreateProjectCustomfieldStatusRequestValue setMetaString(String metaString) {
            this.metaString = metaString;
            return this;
        }
        public String getMetaString() {
            return this.metaString;
        }

        public CreateProjectCustomfieldStatusRequestValue setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
