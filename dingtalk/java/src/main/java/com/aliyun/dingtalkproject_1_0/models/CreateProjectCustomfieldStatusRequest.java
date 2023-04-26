// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreateProjectCustomfieldStatusRequest extends TeaModel {
    @NameInMap("customfieldId")
    public String customfieldId;

    @NameInMap("customfieldInstanceId")
    public String customfieldInstanceId;

    @NameInMap("customfieldName")
    public String customfieldName;

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
        @NameInMap("fieldvalueId")
        public String fieldvalueId;

        @NameInMap("metaString")
        public String metaString;

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
