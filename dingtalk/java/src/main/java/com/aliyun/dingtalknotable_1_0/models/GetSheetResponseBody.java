// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class GetSheetResponseBody extends TeaModel {
    @NameInMap("fields")
    public java.util.List<GetSheetResponseBodyFields> fields;

    public static GetSheetResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSheetResponseBody self = new GetSheetResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSheetResponseBody setFields(java.util.List<GetSheetResponseBodyFields> fields) {
        this.fields = fields;
        return this;
    }
    public java.util.List<GetSheetResponseBodyFields> getFields() {
        return this.fields;
    }

    public static class GetSheetResponseBodyFields extends TeaModel {
        @NameInMap("id")
        public String id;

        @NameInMap("name")
        public String name;

        @NameInMap("property")
        public java.util.Map<String, ?> property;

        @NameInMap("type")
        public String type;

        public static GetSheetResponseBodyFields build(java.util.Map<String, ?> map) throws Exception {
            GetSheetResponseBodyFields self = new GetSheetResponseBodyFields();
            return TeaModel.build(map, self);
        }

        public GetSheetResponseBodyFields setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetSheetResponseBodyFields setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetSheetResponseBodyFields setProperty(java.util.Map<String, ?> property) {
            this.property = property;
            return this;
        }
        public java.util.Map<String, ?> getProperty() {
            return this.property;
        }

        public GetSheetResponseBodyFields setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

}
