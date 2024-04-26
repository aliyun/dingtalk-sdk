// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class CreateSheetRequest extends TeaModel {
    @NameInMap("fields")
    public java.util.List<CreateSheetRequestFields> fields;

    @NameInMap("name")
    public String name;

    @NameInMap("operatorId")
    public String operatorId;

    public static CreateSheetRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateSheetRequest self = new CreateSheetRequest();
        return TeaModel.build(map, self);
    }

    public CreateSheetRequest setFields(java.util.List<CreateSheetRequestFields> fields) {
        this.fields = fields;
        return this;
    }
    public java.util.List<CreateSheetRequestFields> getFields() {
        return this.fields;
    }

    public CreateSheetRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateSheetRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class CreateSheetRequestFields extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("property")
        public java.util.Map<String, ?> property;

        @NameInMap("type")
        public String type;

        public static CreateSheetRequestFields build(java.util.Map<String, ?> map) throws Exception {
            CreateSheetRequestFields self = new CreateSheetRequestFields();
            return TeaModel.build(map, self);
        }

        public CreateSheetRequestFields setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CreateSheetRequestFields setProperty(java.util.Map<String, ?> property) {
            this.property = property;
            return this;
        }
        public java.util.Map<String, ?> getProperty() {
            return this.property;
        }

        public CreateSheetRequestFields setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

}
