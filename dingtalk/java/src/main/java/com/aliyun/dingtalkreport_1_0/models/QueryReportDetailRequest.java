// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkreport_1_0.models;

import com.aliyun.tea.*;

public class QueryReportDetailRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>TEXT</p>
     */
    @NameInMap("format")
    public String format;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>18XXXX</p>
     */
    @NameInMap("reportId")
    public String reportId;

    public static QueryReportDetailRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryReportDetailRequest self = new QueryReportDetailRequest();
        return TeaModel.build(map, self);
    }

    public QueryReportDetailRequest setFormat(String format) {
        this.format = format;
        return this;
    }
    public String getFormat() {
        return this.format;
    }

    public QueryReportDetailRequest setReportId(String reportId) {
        this.reportId = reportId;
        return this;
    }
    public String getReportId() {
        return this.reportId;
    }

}
