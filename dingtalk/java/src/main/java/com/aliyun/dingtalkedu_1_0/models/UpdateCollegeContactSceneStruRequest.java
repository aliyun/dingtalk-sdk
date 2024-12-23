// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateCollegeContactSceneStruRequest extends TeaModel {
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
     * <p>20</p>
     */
    @NameInMap("struId")
    public Long struId;

    /**
     * <strong>example:</strong>
     * <p>科研架构</p>
     */
    @NameInMap("struName")
    public String struName;

    /**
     * <strong>example:</strong>
     * <p>stru_research_dept</p>
     */
    @NameInMap("struType")
    public String struType;

    public static UpdateCollegeContactSceneStruRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateCollegeContactSceneStruRequest self = new UpdateCollegeContactSceneStruRequest();
        return TeaModel.build(map, self);
    }

    public UpdateCollegeContactSceneStruRequest setOrder(Long order) {
        this.order = order;
        return this;
    }
    public Long getOrder() {
        return this.order;
    }

    public UpdateCollegeContactSceneStruRequest setSourceIdentifier(String sourceIdentifier) {
        this.sourceIdentifier = sourceIdentifier;
        return this;
    }
    public String getSourceIdentifier() {
        return this.sourceIdentifier;
    }

    public UpdateCollegeContactSceneStruRequest setStruBrief(String struBrief) {
        this.struBrief = struBrief;
        return this;
    }
    public String getStruBrief() {
        return this.struBrief;
    }

    public UpdateCollegeContactSceneStruRequest setStruId(Long struId) {
        this.struId = struId;
        return this;
    }
    public Long getStruId() {
        return this.struId;
    }

    public UpdateCollegeContactSceneStruRequest setStruName(String struName) {
        this.struName = struName;
        return this;
    }
    public String getStruName() {
        return this.struName;
    }

    public UpdateCollegeContactSceneStruRequest setStruType(String struType) {
        this.struType = struType;
        return this;
    }
    public String getStruType() {
        return this.struType;
    }

}
