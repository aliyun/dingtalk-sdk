// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class OpenAgoalAlignDTO extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>COOPERATION</p>
     */
    @NameInMap("alignType")
    public String alignType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>662e006fe4b0f579bbcxxxxx</p>
     */
    @NameInMap("objectId")
    public String objectId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>objective</p>
     */
    @NameInMap("objectType")
    public String objectType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>662e006fe4b0f579bbcxxxxx</p>
     */
    @NameInMap("objectiveId")
    public String objectiveId;

    public static OpenAgoalAlignDTO build(java.util.Map<String, ?> map) throws Exception {
        OpenAgoalAlignDTO self = new OpenAgoalAlignDTO();
        return TeaModel.build(map, self);
    }

    public OpenAgoalAlignDTO setAlignType(String alignType) {
        this.alignType = alignType;
        return this;
    }
    public String getAlignType() {
        return this.alignType;
    }

    public OpenAgoalAlignDTO setObjectId(String objectId) {
        this.objectId = objectId;
        return this;
    }
    public String getObjectId() {
        return this.objectId;
    }

    public OpenAgoalAlignDTO setObjectType(String objectType) {
        this.objectType = objectType;
        return this;
    }
    public String getObjectType() {
        return this.objectType;
    }

    public OpenAgoalAlignDTO setObjectiveId(String objectiveId) {
        this.objectiveId = objectiveId;
        return this;
    }
    public String getObjectiveId() {
        return this.objectiveId;
    }

}
