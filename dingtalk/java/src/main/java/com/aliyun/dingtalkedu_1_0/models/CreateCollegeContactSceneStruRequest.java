// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateCollegeContactSceneStruRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("hasStruFixedDept")
    public Boolean hasStruFixedDept;

    /**
     * <strong>example:</strong>
     * <p>20</p>
     */
    @NameInMap("order")
    public Long order;

    /**
     * <strong>example:</strong>
     * <p>场景架构标识</p>
     */
    @NameInMap("sourceIdentifier")
    public String sourceIdentifier;

    /**
     * <strong>example:</strong>
     * <p>这是场景架构简介</p>
     */
    @NameInMap("struBrief")
    public String struBrief;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>科研架构</p>
     */
    @NameInMap("struName")
    public String struName;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>stru_research_dept</p>
     */
    @NameInMap("struType")
    public String struType;

    public static CreateCollegeContactSceneStruRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateCollegeContactSceneStruRequest self = new CreateCollegeContactSceneStruRequest();
        return TeaModel.build(map, self);
    }

    public CreateCollegeContactSceneStruRequest setHasStruFixedDept(Boolean hasStruFixedDept) {
        this.hasStruFixedDept = hasStruFixedDept;
        return this;
    }
    public Boolean getHasStruFixedDept() {
        return this.hasStruFixedDept;
    }

    public CreateCollegeContactSceneStruRequest setOrder(Long order) {
        this.order = order;
        return this;
    }
    public Long getOrder() {
        return this.order;
    }

    public CreateCollegeContactSceneStruRequest setSourceIdentifier(String sourceIdentifier) {
        this.sourceIdentifier = sourceIdentifier;
        return this;
    }
    public String getSourceIdentifier() {
        return this.sourceIdentifier;
    }

    public CreateCollegeContactSceneStruRequest setStruBrief(String struBrief) {
        this.struBrief = struBrief;
        return this;
    }
    public String getStruBrief() {
        return this.struBrief;
    }

    public CreateCollegeContactSceneStruRequest setStruName(String struName) {
        this.struName = struName;
        return this;
    }
    public String getStruName() {
        return this.struName;
    }

    public CreateCollegeContactSceneStruRequest setStruType(String struType) {
        this.struType = struType;
        return this;
    }
    public String getStruType() {
        return this.struType;
    }

}
