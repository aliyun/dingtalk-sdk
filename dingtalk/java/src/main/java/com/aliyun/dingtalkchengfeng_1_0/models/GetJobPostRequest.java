// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class GetJobPostRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1234</p>
     */
    @NameInMap("jobPostCode")
    public String jobPostCode;

    public static GetJobPostRequest build(java.util.Map<String, ?> map) throws Exception {
        GetJobPostRequest self = new GetJobPostRequest();
        return TeaModel.build(map, self);
    }

    public GetJobPostRequest setJobPostCode(String jobPostCode) {
        this.jobPostCode = jobPostCode;
        return this;
    }
    public String getJobPostCode() {
        return this.jobPostCode;
    }

}
