// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class CreateFilterViewResponseBody extends TeaModel {
    @NameInMap("id")
    public String id;

    @NameInMap("name")
    public String name;

    @NameInMap("range")
    public String range;

    public static CreateFilterViewResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateFilterViewResponseBody self = new CreateFilterViewResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateFilterViewResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public CreateFilterViewResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateFilterViewResponseBody setRange(String range) {
        this.range = range;
        return this;
    }
    public String getRange() {
        return this.range;
    }

}
