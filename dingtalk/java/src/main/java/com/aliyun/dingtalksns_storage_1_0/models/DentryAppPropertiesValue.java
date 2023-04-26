// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksns_storage_1_0.models;

import com.aliyun.tea.*;

public class DentryAppPropertiesValue extends TeaModel {
    @NameInMap("name")
    public String name;

    @NameInMap("value")
    public String value;

    @NameInMap("visibility")
    public String visibility;

    public static DentryAppPropertiesValue build(java.util.Map<String, ?> map) throws Exception {
        DentryAppPropertiesValue self = new DentryAppPropertiesValue();
        return TeaModel.build(map, self);
    }

    public DentryAppPropertiesValue setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public DentryAppPropertiesValue setValue(String value) {
        this.value = value;
        return this;
    }
    public String getValue() {
        return this.value;
    }

    public DentryAppPropertiesValue setVisibility(String visibility) {
        this.visibility = visibility;
        return this;
    }
    public String getVisibility() {
        return this.visibility;
    }

}
