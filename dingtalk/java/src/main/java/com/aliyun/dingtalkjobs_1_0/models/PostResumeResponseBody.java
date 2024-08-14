// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjobs_1_0.models;

import com.aliyun.tea.*;

public class PostResumeResponseBody extends TeaModel {
    @NameInMap("jobId")
    public Long jobId;

    @NameInMap("userIdentify")
    public String userIdentify;

    public static PostResumeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PostResumeResponseBody self = new PostResumeResponseBody();
        return TeaModel.build(map, self);
    }

    public PostResumeResponseBody setJobId(Long jobId) {
        this.jobId = jobId;
        return this;
    }
    public Long getJobId() {
        return this.jobId;
    }

    public PostResumeResponseBody setUserIdentify(String userIdentify) {
        this.userIdentify = userIdentify;
        return this;
    }
    public String getUserIdentify() {
        return this.userIdentify;
    }

}
