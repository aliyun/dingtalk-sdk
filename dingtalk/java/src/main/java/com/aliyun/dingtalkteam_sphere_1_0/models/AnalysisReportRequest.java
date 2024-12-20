// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class AnalysisReportRequest extends TeaModel {
    @NameInMap("filter")
    public AnalysisReportRequestFilter filter;

    @NameInMap("reportId")
    public String reportId;

    public static AnalysisReportRequest build(java.util.Map<String, ?> map) throws Exception {
        AnalysisReportRequest self = new AnalysisReportRequest();
        return TeaModel.build(map, self);
    }

    public AnalysisReportRequest setFilter(AnalysisReportRequestFilter filter) {
        this.filter = filter;
        return this;
    }
    public AnalysisReportRequestFilter getFilter() {
        return this.filter;
    }

    public AnalysisReportRequest setReportId(String reportId) {
        this.reportId = reportId;
        return this;
    }
    public String getReportId() {
        return this.reportId;
    }

    public static class AnalysisReportRequestFilter extends TeaModel {
        @NameInMap("created")
        public String created;

        public static AnalysisReportRequestFilter build(java.util.Map<String, ?> map) throws Exception {
            AnalysisReportRequestFilter self = new AnalysisReportRequestFilter();
            return TeaModel.build(map, self);
        }

        public AnalysisReportRequestFilter setCreated(String created) {
            this.created = created;
            return this;
        }
        public String getCreated() {
            return this.created;
        }

    }

}
