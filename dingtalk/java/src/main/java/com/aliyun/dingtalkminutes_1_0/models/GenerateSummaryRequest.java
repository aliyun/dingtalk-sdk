// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class GenerateSummaryRequest extends TeaModel {
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

    public static GenerateSummaryRequest build(java.util.Map<String, ?> map) throws Exception {
        GenerateSummaryRequest self = new GenerateSummaryRequest();
        return TeaModel.build(map, self);
    }

    public GenerateSummaryRequest setDiyTemplateVersion(String diyTemplateVersion) {
        this.diyTemplateVersion = diyTemplateVersion;
        return this;
    }
    public String getDiyTemplateVersion() {
        return this.diyTemplateVersion;
    }

    public GenerateSummaryRequest setSummaryTemplateId(String summaryTemplateId) {
        this.summaryTemplateId = summaryTemplateId;
        return this;
    }
    public String getSummaryTemplateId() {
        return this.summaryTemplateId;
    }

    public GenerateSummaryRequest setSummaryTemplateType(String summaryTemplateType) {
        this.summaryTemplateType = summaryTemplateType;
        return this;
    }
    public String getSummaryTemplateType() {
        return this.summaryTemplateType;
    }

    public GenerateSummaryRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
