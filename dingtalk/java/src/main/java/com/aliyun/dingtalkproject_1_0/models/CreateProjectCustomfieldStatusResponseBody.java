// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreateProjectCustomfieldStatusResponseBody extends TeaModel {
    @NameInMap("result")
    public CreateProjectCustomfieldStatusResponseBodyResult result;

    public static CreateProjectCustomfieldStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateProjectCustomfieldStatusResponseBody self = new CreateProjectCustomfieldStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateProjectCustomfieldStatusResponseBody setResult(CreateProjectCustomfieldStatusResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreateProjectCustomfieldStatusResponseBodyResult getResult() {
        return this.result;
    }

    public static class CreateProjectCustomfieldStatusResponseBodyResultValue extends TeaModel {
        @NameInMap("customFieldValueId")
        public String customFieldValueId;

        @NameInMap("metaString")
        public String metaString;

        @NameInMap("title")
        public String title;

        public static CreateProjectCustomfieldStatusResponseBodyResultValue build(java.util.Map<String, ?> map) throws Exception {
            CreateProjectCustomfieldStatusResponseBodyResultValue self = new CreateProjectCustomfieldStatusResponseBodyResultValue();
            return TeaModel.build(map, self);
        }

        public CreateProjectCustomfieldStatusResponseBodyResultValue setCustomFieldValueId(String customFieldValueId) {
            this.customFieldValueId = customFieldValueId;
            return this;
        }
        public String getCustomFieldValueId() {
            return this.customFieldValueId;
        }

        public CreateProjectCustomfieldStatusResponseBodyResultValue setMetaString(String metaString) {
            this.metaString = metaString;
            return this;
        }
        public String getMetaString() {
            return this.metaString;
        }

        public CreateProjectCustomfieldStatusResponseBodyResultValue setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class CreateProjectCustomfieldStatusResponseBodyResult extends TeaModel {
        @NameInMap("advancedCustomFieldObjectType")
        public String advancedCustomFieldObjectType;

        @NameInMap("customFieldId")
        public String customFieldId;

        @NameInMap("name")
        public String name;

        @NameInMap("originalId")
        public String originalId;

        @NameInMap("type")
        public String type;

        @NameInMap("value")
        public java.util.List<CreateProjectCustomfieldStatusResponseBodyResultValue> value;

        public static CreateProjectCustomfieldStatusResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateProjectCustomfieldStatusResponseBodyResult self = new CreateProjectCustomfieldStatusResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateProjectCustomfieldStatusResponseBodyResult setAdvancedCustomFieldObjectType(String advancedCustomFieldObjectType) {
            this.advancedCustomFieldObjectType = advancedCustomFieldObjectType;
            return this;
        }
        public String getAdvancedCustomFieldObjectType() {
            return this.advancedCustomFieldObjectType;
        }

        public CreateProjectCustomfieldStatusResponseBodyResult setCustomFieldId(String customFieldId) {
            this.customFieldId = customFieldId;
            return this;
        }
        public String getCustomFieldId() {
            return this.customFieldId;
        }

        public CreateProjectCustomfieldStatusResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CreateProjectCustomfieldStatusResponseBodyResult setOriginalId(String originalId) {
            this.originalId = originalId;
            return this;
        }
        public String getOriginalId() {
            return this.originalId;
        }

        public CreateProjectCustomfieldStatusResponseBodyResult setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public CreateProjectCustomfieldStatusResponseBodyResult setValue(java.util.List<CreateProjectCustomfieldStatusResponseBodyResultValue> value) {
            this.value = value;
            return this;
        }
        public java.util.List<CreateProjectCustomfieldStatusResponseBodyResultValue> getValue() {
            return this.value;
        }

    }

}
