// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_2_0.models;

import com.aliyun.tea.*;

public class CreateFieldRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("name")
    public String name;

    @NameInMap("property")
    public java.util.Map<String, ?> property;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("type")
    public String type;

    public static CreateFieldRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateFieldRequest self = new CreateFieldRequest();
        return TeaModel.build(map, self);
    }

    public CreateFieldRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateFieldRequest setProperty(java.util.Map<String, ?> property) {
        this.property = property;
        return this;
    }
    public java.util.Map<String, ?> getProperty() {
        return this.property;
    }

    public CreateFieldRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

}
