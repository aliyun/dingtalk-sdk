// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalOrgObjectiveListRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>853530516</p>
     * 
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("dingTeamId")
    public String dingTeamId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <strong>example:</strong>
     * <p>662e006fe4b0f579bbcxxxxx</p>
     * 
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("periodId")
    public String periodId;

    public static AgoalOrgObjectiveListRequest build(java.util.Map<String, ?> map) throws Exception {
        AgoalOrgObjectiveListRequest self = new AgoalOrgObjectiveListRequest();
        return TeaModel.build(map, self);
    }

    public AgoalOrgObjectiveListRequest setDingTeamId(String dingTeamId) {
        this.dingTeamId = dingTeamId;
        return this;
    }
    public String getDingTeamId() {
        return this.dingTeamId;
    }

    public AgoalOrgObjectiveListRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public AgoalOrgObjectiveListRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public AgoalOrgObjectiveListRequest setPeriodId(String periodId) {
        this.periodId = periodId;
        return this;
    }
    public String getPeriodId() {
        return this.periodId;
    }

}
