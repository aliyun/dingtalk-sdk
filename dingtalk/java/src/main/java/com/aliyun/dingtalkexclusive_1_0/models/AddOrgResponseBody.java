// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class AddOrgResponseBody extends TeaModel {
    // 组织id
    @NameInMap("corpId")
    public String corpId;

    public static AddOrgResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddOrgResponseBody self = new AddOrgResponseBody();
        return TeaModel.build(map, self);
    }

    public AddOrgResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

}
