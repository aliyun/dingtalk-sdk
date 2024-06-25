// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksearch_1_0.models;

import com.aliyun.tea.*;

public class CreateSearchTabResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>3333</p>
     */
    @NameInMap("tabId")
    public Integer tabId;

    public static CreateSearchTabResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateSearchTabResponseBody self = new CreateSearchTabResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateSearchTabResponseBody setTabId(Integer tabId) {
        this.tabId = tabId;
        return this;
    }
    public Integer getTabId() {
        return this.tabId;
    }

}
