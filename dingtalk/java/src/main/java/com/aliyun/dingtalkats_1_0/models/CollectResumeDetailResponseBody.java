// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class CollectResumeDetailResponseBody extends TeaModel {
    // 简历标识
    @NameInMap("resumeId")
    public String resumeId;

    public static CollectResumeDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CollectResumeDetailResponseBody self = new CollectResumeDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public CollectResumeDetailResponseBody setResumeId(String resumeId) {
        this.resumeId = resumeId;
        return this;
    }
    public String getResumeId() {
        return this.resumeId;
    }

}
