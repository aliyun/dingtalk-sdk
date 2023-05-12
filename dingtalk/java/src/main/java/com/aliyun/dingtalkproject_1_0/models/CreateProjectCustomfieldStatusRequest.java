// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreateProjectCustomfieldStatusRequest extends TeaModel {
    @NameInMap("customFieldId")
    public String customFieldId;

    @NameInMap("customFieldInstanceId")
    public String customFieldInstanceId;

    @NameInMap("customFieldName")
    public String customFieldName;

    @NameInMap("value")
    public java.util.List<CreateProjectCustomfieldStatusRequestValue> value;

    public static CreateProjectCustomfieldStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateProjectCustomfieldStatusRequest self = new CreateProjectCustomfieldStatusRequest();
        return TeaModel.build(map, self);
    }

    public CreateProjectCustomfieldStatusRequest setCustomFieldId(String customFieldId) {
        this.customFieldId = customFieldId;
        return this;
    }
    public String getCustomFieldId() {
        return this.customFieldId;
    }

    public CreateProjectCustomfieldStatusRequest setCustomFieldInstanceId(String customFieldInstanceId) {
        this.customFieldInstanceId = customFieldInstanceId;
        return this;
    }
    public String getCustomFieldInstanceId() {
        return this.customFieldInstanceId;
    }

    public CreateProjectCustomfieldStatusRequest setCustomFieldName(String customFieldName) {
        this.customFieldName = customFieldName;
        return this;
    }
    public String getCustomFieldName() {
        return this.customFieldName;
    }

    public CreateProjectCustomfieldStatusRequest setValue(java.util.List<CreateProjectCustomfieldStatusRequestValue> value) {
        this.value = value;
        return this;
    }
    public java.util.List<CreateProjectCustomfieldStatusRequestValue> getValue() {
        return this.value;
    }

    public static class CreateProjectCustomfieldStatusRequestValue extends TeaModel {
        @NameInMap("customFieldValueId")
        public String customFieldValueId;

        @NameInMap("metaString")
        public String metaString;

        @NameInMap("title")
        public String title;

        public static CreateProjectCustomfieldStatusRequestValue build(java.util.Map<String, ?> map) throws Exception {
            CreateProjectCustomfieldStatusRequestValue self = new CreateProjectCustomfieldStatusRequestValue();
            return TeaModel.build(map, self);
        }

        public CreateProjectCustomfieldStatusRequestValue setCustomFieldValueId(String customFieldValueId) {
            this.customFieldValueId = customFieldValueId;
            return this;
        }
        public String getCustomFieldValueId() {
            return this.customFieldValueId;
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
