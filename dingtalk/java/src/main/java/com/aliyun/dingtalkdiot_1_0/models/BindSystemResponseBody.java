// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class BindSystemResponseBody extends TeaModel {
    @NameInMap("clientId")
    public String clientId;

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
