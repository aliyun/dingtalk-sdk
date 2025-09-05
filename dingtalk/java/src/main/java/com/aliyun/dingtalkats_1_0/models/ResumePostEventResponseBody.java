// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class ResumePostEventResponseBody extends TeaModel {
    @NameInMap("bizId")
    public String bizId;

    public static ResumePostEventResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ResumePostEventResponseBody self = new ResumePostEventResponseBody();
        return TeaModel.build(map, self);
    }

    public ResumePostEventResponseBody setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

}
