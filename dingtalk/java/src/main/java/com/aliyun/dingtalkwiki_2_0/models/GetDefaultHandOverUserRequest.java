// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_2_0.models;

import com.aliyun.tea.*;

public class GetDefaultHandOverUserRequest extends TeaModel {
    @NameInMap("operatorId")
    public String operatorId;

    public static GetDefaultHandOverUserRequest build(java.util.Map<String, ?> map) throws Exception {
        GetDefaultHandOverUserRequest self = new GetDefaultHandOverUserRequest();
        return TeaModel.build(map, self);
    }

    public GetDefaultHandOverUserRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
