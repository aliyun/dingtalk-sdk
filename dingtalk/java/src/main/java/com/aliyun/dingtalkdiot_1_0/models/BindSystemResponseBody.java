// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class BindSystemResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>d12345</p>
     */
    @NameInMap("clientId")
    public String clientId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ding12345</p>
     */
    @NameInMap("corpId")
    public String corpId;

    public static BindSystemResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BindSystemResponseBody self = new BindSystemResponseBody();
        return TeaModel.build(map, self);
    }

    public BindSystemResponseBody setClientId(String clientId) {
        this.clientId = clientId;
        return this;
    }
    public String getClientId() {
        return this.clientId;
    }

    public BindSystemResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

}
