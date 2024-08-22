// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ExportDocResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>12345678</p>
     */
    @NameInMap("jobId")
    public String jobId;

    /**
     * <strong>example:</strong>
     * <p>init</p>
     */
    @NameInMap("status")
    public String status;

    public static ExportDocResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ExportDocResponseBody self = new ExportDocResponseBody();
        return TeaModel.build(map, self);
    }

    public ExportDocResponseBody setJobId(String jobId) {
        this.jobId = jobId;
        return this;
    }
    public String getJobId() {
        return this.jobId;
    }

    public ExportDocResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

}
