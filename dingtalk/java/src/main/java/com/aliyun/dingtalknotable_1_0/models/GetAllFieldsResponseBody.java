// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class GetAllFieldsResponseBody extends TeaModel {
    @NameInMap("value")
    public java.util.List<GetAllFieldsResponseBodyValue> value;

    public static GetAllFieldsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAllFieldsResponseBody self = new GetAllFieldsResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAllFieldsResponseBody setValue(java.util.List<GetAllFieldsResponseBodyValue> value) {
        this.value = value;
        return this;
    }
    public java.util.List<GetAllFieldsResponseBodyValue> getValue() {
        return this.value;
    }

    public static class GetAllFieldsResponseBodyValue extends TeaModel {
        @NameInMap("id")
        public String id;

        @NameInMap("name")
        public String name;

        @NameInMap("property")
        public java.util.Map<String, ?> property;

        @NameInMap("type")
        public String type;

        public static GetAllFieldsResponseBodyValue build(java.util.Map<String, ?> map) throws Exception {
            GetAllFieldsResponseBodyValue self = new GetAllFieldsResponseBodyValue();
            return TeaModel.build(map, self);
        }

        public GetAllFieldsResponseBodyValue setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetAllFieldsResponseBodyValue setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetAllFieldsResponseBodyValue setProperty(java.util.Map<String, ?> property) {
            this.property = property;
            return this;
        }
        public java.util.Map<String, ?> getProperty() {
            return this.property;
        }

        public GetAllFieldsResponseBodyValue setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

}
