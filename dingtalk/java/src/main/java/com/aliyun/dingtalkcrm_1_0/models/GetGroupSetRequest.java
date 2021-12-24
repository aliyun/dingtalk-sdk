// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetGroupSetRequest extends TeaModel {
    @NameInMap("openGroupSetId")
    public String openGroupSetId;

    public static GetGroupSetRequest build(java.util.Map<String, ?> map) throws Exception {
        GetGroupSetRequest self = new GetGroupSetRequest();
        return TeaModel.build(map, self);
    }

    public GetGroupSetRequest setOpenGroupSetId(String openGroupSetId) {
        this.openGroupSetId = openGroupSetId;
        return this;
    }
    public String getOpenGroupSetId() {
        return this.openGroupSetId;
    }

}
