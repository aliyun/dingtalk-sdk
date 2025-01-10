// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class OpenAgoalOrgObjectiveListDTO extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("objectiveList")
    public java.util.List<OpenAgoalOrgObjectiveDTO> objectiveList;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("totalCount")
    public Long totalCount;

    public static OpenAgoalOrgObjectiveListDTO build(java.util.Map<String, ?> map) throws Exception {
        OpenAgoalOrgObjectiveListDTO self = new OpenAgoalOrgObjectiveListDTO();
        return TeaModel.build(map, self);
    }

    public OpenAgoalOrgObjectiveListDTO setObjectiveList(java.util.List<OpenAgoalOrgObjectiveDTO> objectiveList) {
        this.objectiveList = objectiveList;
        return this;
    }
    public java.util.List<OpenAgoalOrgObjectiveDTO> getObjectiveList() {
        return this.objectiveList;
    }

    public OpenAgoalOrgObjectiveListDTO setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

}
