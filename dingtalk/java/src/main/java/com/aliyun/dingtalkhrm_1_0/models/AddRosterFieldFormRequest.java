// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AddRosterFieldFormRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("detail")
    public Boolean detail;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("name")
    public String name;

    public static AddRosterFieldFormRequest build(java.util.Map<String, ?> map) throws Exception {
        AddRosterFieldFormRequest self = new AddRosterFieldFormRequest();
        return TeaModel.build(map, self);
    }

    public AddRosterFieldFormRequest setDetail(Boolean detail) {
        this.detail = detail;
        return this;
    }
    public Boolean getDetail() {
        return this.detail;
    }

    public AddRosterFieldFormRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

}
