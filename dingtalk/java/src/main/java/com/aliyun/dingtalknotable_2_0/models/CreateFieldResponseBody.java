// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_2_0.models;

import com.aliyun.tea.*;

public class CreateFieldResponseBody extends TeaModel {
    @NameInMap("id")
    public String id;

    @NameInMap("name")
    public String name;

    @NameInMap("property")
    public java.util.Map<String, ?> property;

    @NameInMap("type")
    public String type;

    public static CreateFieldResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateFieldResponseBody self = new CreateFieldResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateFieldResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public CreateFieldResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateFieldResponseBody setProperty(java.util.Map<String, ?> property) {
        this.property = property;
        return this;
    }
    public java.util.Map<String, ?> getProperty() {
        return this.property;
    }

    public CreateFieldResponseBody setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

}
