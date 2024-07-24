// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class AddUnfurlingRegisterResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("id")
    public Long id;

    @NameInMap("success")
    public Boolean success;

    public static AddUnfurlingRegisterResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddUnfurlingRegisterResponseBody self = new AddUnfurlingRegisterResponseBody();
        return TeaModel.build(map, self);
    }

    public AddUnfurlingRegisterResponseBody setId(Long id) {
        this.id = id;
        return this;
    }
    public Long getId() {
        return this.id;
    }

    public AddUnfurlingRegisterResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
