// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QuerySummaryWithTemplateRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("diyTemplateVersion")
    public String diyTemplateVersion;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>meeting-assistant</p>
     */
    @NameInMap("summaryTemplateId")
    public String summaryTemplateId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("summaryTemplateType")
    public String summaryTemplateType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>lJcRnm39OsU4jlFVmRGXXXXX</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static QuerySummaryWithTemplateRequest build(java.util.Map<String, ?> map) throws Exception {
        QuerySummaryWithTemplateRequest self = new QuerySummaryWithTemplateRequest();
        return TeaModel.build(map, self);
    }

    public QuerySummaryWithTemplateRequest setDiyTemplateVersion(String diyTemplateVersion) {
        this.diyTemplateVersion = diyTemplateVersion;
        return this;
    }
    public String getDiyTemplateVersion() {
        return this.diyTemplateVersion;
    }

    public QuerySummaryWithTemplateRequest setSummaryTemplateId(String summaryTemplateId) {
        this.summaryTemplateId = summaryTemplateId;
        return this;
    }
    public String getSummaryTemplateId() {
        return this.summaryTemplateId;
    }

    public QuerySummaryWithTemplateRequest setSummaryTemplateType(String summaryTemplateType) {
        this.summaryTemplateType = summaryTemplateType;
        return this;
    }
    public String getSummaryTemplateType() {
        return this.summaryTemplateType;
    }

    public QuerySummaryWithTemplateRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
