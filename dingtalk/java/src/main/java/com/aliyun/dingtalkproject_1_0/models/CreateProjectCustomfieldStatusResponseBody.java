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
        @NameInMap("fieldvalueId")
        public String fieldvalueId;

        @NameInMap("metaString")
        public String metaString;

        @NameInMap("title")
        public String title;

        public static CreateProjectCustomfieldStatusResponseBodyResultValue build(java.util.Map<String, ?> map) throws Exception {
            CreateProjectCustomfieldStatusResponseBodyResultValue self = new CreateProjectCustomfieldStatusResponseBodyResultValue();
            return TeaModel.build(map, self);
        }

        public CreateProjectCustomfieldStatusResponseBodyResultValue setFieldvalueId(String fieldvalueId) {
            this.fieldvalueId = fieldvalueId;
            return this;
        }
        public String getFieldvalueId() {
            return this.fieldvalueId;
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
        @NameInMap("advCfObjectType")
        public String advCfObjectType;

        @NameInMap("customfieldId")
        public String customfieldId;

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

        public CreateProjectCustomfieldStatusResponseBodyResult setAdvCfObjectType(String advCfObjectType) {
            this.advCfObjectType = advCfObjectType;
            return this;
        }
        public String getAdvCfObjectType() {
            return this.advCfObjectType;
        }

        public CreateProjectCustomfieldStatusResponseBodyResult setCustomfieldId(String customfieldId) {
            this.customfieldId = customfieldId;
            return this;
        }
        public String getCustomfieldId() {
            return this.customfieldId;
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
