// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TranslateFileResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>fXrgPrvsNiZNa8RWis9Nk1SY</p>
     */
    @NameInMap("jobId")
    public String jobId;

    public static TranslateFileResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TranslateFileResponseBody self = new TranslateFileResponseBody();
        return TeaModel.build(map, self);
    }

    public TranslateFileResponseBody setJobId(String jobId) {
        this.jobId = jobId;
        return this;
    }
    public String getJobId() {
        return this.jobId;
    }

}
