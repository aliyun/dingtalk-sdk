// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class CreateCooperateOrgResponseBody extends TeaModel {
    // result
    @NameInMap("cooperateCorpId")
    public String cooperateCorpId;

    public static CreateCooperateOrgResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateCooperateOrgResponseBody self = new CreateCooperateOrgResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateCooperateOrgResponseBody setCooperateCorpId(String cooperateCorpId) {
        this.cooperateCorpId = cooperateCorpId;
        return this;
    }
    public String getCooperateCorpId() {
        return this.cooperateCorpId;
    }

}
