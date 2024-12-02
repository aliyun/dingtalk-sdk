// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class AnalysisReportRequest extends TeaModel {
    @NameInMap("reportId")
    public String reportId;

    public static AnalysisReportRequest build(java.util.Map<String, ?> map) throws Exception {
        AnalysisReportRequest self = new AnalysisReportRequest();
        return TeaModel.build(map, self);
    }

    public AnalysisReportRequest setReportId(String reportId) {
        this.reportId = reportId;
        return this;
    }
    public String getReportId() {
        return this.reportId;
    }

}
