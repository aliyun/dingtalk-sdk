// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetConfBaseInfoByLogicalIdRequest extends TeaModel {
    @NameInMap("logicalConferenceId")
    public String logicalConferenceId;

    public static GetConfBaseInfoByLogicalIdRequest build(java.util.Map<String, ?> map) throws Exception {
        GetConfBaseInfoByLogicalIdRequest self = new GetConfBaseInfoByLogicalIdRequest();
        return TeaModel.build(map, self);
    }

    public GetConfBaseInfoByLogicalIdRequest setLogicalConferenceId(String logicalConferenceId) {
        this.logicalConferenceId = logicalConferenceId;
        return this;
    }
    public String getLogicalConferenceId() {
        return this.logicalConferenceId;
    }

}
