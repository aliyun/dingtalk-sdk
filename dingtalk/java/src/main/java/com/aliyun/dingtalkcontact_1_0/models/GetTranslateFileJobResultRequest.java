// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetTranslateFileJobResultRequest extends TeaModel {
    /**
     * <p>异步转译任务id</p>
     */
    @NameInMap("jobId")
    public String jobId;

    public static GetTranslateFileJobResultRequest build(java.util.Map<String, ?> map) throws Exception {
        GetTranslateFileJobResultRequest self = new GetTranslateFileJobResultRequest();
        return TeaModel.build(map, self);
    }

    public GetTranslateFileJobResultRequest setJobId(String jobId) {
        this.jobId = jobId;
        return this;
    }
    public String getJobId() {
        return this.jobId;
    }

}
