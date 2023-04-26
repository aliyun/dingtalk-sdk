// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class ResultItemsDentryAppPropertiesValue extends TeaModel {
    @NameInMap("name")
    public String name;

    @NameInMap("value")
    public String value;

    @NameInMap("visibility")
    public String visibility;

    public static ResultItemsDentryAppPropertiesValue build(java.util.Map<String, ?> map) throws Exception {
        ResultItemsDentryAppPropertiesValue self = new ResultItemsDentryAppPropertiesValue();
        return TeaModel.build(map, self);
    }

    public ResultItemsDentryAppPropertiesValue setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public ResultItemsDentryAppPropertiesValue setValue(String value) {
        this.value = value;
        return this;
    }
    public String getValue() {
        return this.value;
    }

    public ResultItemsDentryAppPropertiesValue setVisibility(String visibility) {
        this.visibility = visibility;
        return this;
    }
    public String getVisibility() {
        return this.visibility;
    }

}
