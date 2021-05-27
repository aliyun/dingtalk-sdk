// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class CancelCorpAuthRequest extends TeaModel {
    @NameInMap("dingCorpId")
    public String dingCorpId;

    public static CancelCorpAuthRequest build(java.util.Map<String, ?> map) throws Exception {
        CancelCorpAuthRequest self = new CancelCorpAuthRequest();
        return TeaModel.build(map, self);
    }

    public CancelCorpAuthRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

}
