// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class GetAllSheetsResponseBody extends TeaModel {
    @NameInMap("value")
    public java.util.List<GetAllSheetsResponseBodyValue> value;

    public static GetAllSheetsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAllSheetsResponseBody self = new GetAllSheetsResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAllSheetsResponseBody setValue(java.util.List<GetAllSheetsResponseBodyValue> value) {
        this.value = value;
        return this;
    }
    public java.util.List<GetAllSheetsResponseBodyValue> getValue() {
        return this.value;
    }

    public static class GetAllSheetsResponseBodyValueFields extends TeaModel {
        @NameInMap("id")
        public String id;

        @NameInMap("name")
        public String name;

        @NameInMap("property")
        public java.util.Map<String, ?> property;

        @NameInMap("type")
        public String type;

        public static GetAllSheetsResponseBodyValueFields build(java.util.Map<String, ?> map) throws Exception {
            GetAllSheetsResponseBodyValueFields self = new GetAllSheetsResponseBodyValueFields();
            return TeaModel.build(map, self);
        }

        public GetAllSheetsResponseBodyValueFields setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetAllSheetsResponseBodyValueFields setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetAllSheetsResponseBodyValueFields setProperty(java.util.Map<String, ?> property) {
            this.property = property;
            return this;
        }
        public java.util.Map<String, ?> getProperty() {
            return this.property;
        }

        public GetAllSheetsResponseBodyValueFields setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class GetAllSheetsResponseBodyValue extends TeaModel {
        @NameInMap("fields")
        public java.util.List<GetAllSheetsResponseBodyValueFields> fields;

        @NameInMap("id")
        public String id;

        @NameInMap("name")
        public String name;

        public static GetAllSheetsResponseBodyValue build(java.util.Map<String, ?> map) throws Exception {
            GetAllSheetsResponseBodyValue self = new GetAllSheetsResponseBodyValue();
            return TeaModel.build(map, self);
        }

        public GetAllSheetsResponseBodyValue setFields(java.util.List<GetAllSheetsResponseBodyValueFields> fields) {
            this.fields = fields;
            return this;
        }
        public java.util.List<GetAllSheetsResponseBodyValueFields> getFields() {
            return this.fields;
        }

        public GetAllSheetsResponseBodyValue setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetAllSheetsResponseBodyValue setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
