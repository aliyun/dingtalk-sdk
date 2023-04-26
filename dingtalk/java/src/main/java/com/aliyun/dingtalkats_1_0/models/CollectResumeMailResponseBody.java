// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class CollectResumeMailResponseBody extends TeaModel {
    @NameInMap("resumeId")
    public String resumeId;

    public static CollectResumeMailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CollectResumeMailResponseBody self = new CollectResumeMailResponseBody();
        return TeaModel.build(map, self);
    }

    public CollectResumeMailResponseBody setResumeId(String resumeId) {
        this.resumeId = resumeId;
        return this;
    }
    public String getResumeId() {
        return this.resumeId;
    }

}
