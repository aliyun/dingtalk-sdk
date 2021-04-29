// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class CloseVideoConferenceRequest extends TeaModel {
    // 员工在当前开发者企业账号范围内的唯一标识
    @NameInMap("unionId")
    public String unionId;

    public static CloseVideoConferenceRequest build(java.util.Map<String, ?> map) throws Exception {
        CloseVideoConferenceRequest self = new CloseVideoConferenceRequest();
        return TeaModel.build(map, self);
    }

    public CloseVideoConferenceRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
