// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalCreateProgressRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>64bf87f8d7ace3616f0a1971</p>
     */
    @NameInMap("krId")
    public String krId;

    /**
     * <strong>if can be null:</strong>
     * <p>false</p>
     */
    @NameInMap("mergeIntoLatestProgress")
    public Boolean mergeIntoLatestProgress;

    /**
     * <strong>example:</strong>
     * <p>662e006fe4b0f579bbcb10cf</p>
     */
    @NameInMap("objectiveId")
    public String objectiveId;

    /**
     * <strong>example:</strong>
     * <p>这是一条目标进展文本</p>
     */
    @NameInMap("plainText")
    public String plainText;

    /**
     * <strong>example:</strong>
     * <p>30</p>
     */
    @NameInMap("progress")
    public Integer progress;

    /**
     * <strong>example:</strong>
     * <p>naturalWeek</p>
     */
    @NameInMap("progressMergePeriod")
    public String progressMergePeriod;

    public static AgoalCreateProgressRequest build(java.util.Map<String, ?> map) throws Exception {
        AgoalCreateProgressRequest self = new AgoalCreateProgressRequest();
        return TeaModel.build(map, self);
    }

    public AgoalCreateProgressRequest setKrId(String krId) {
        this.krId = krId;
        return this;
    }
    public String getKrId() {
        return this.krId;
    }

    public AgoalCreateProgressRequest setMergeIntoLatestProgress(Boolean mergeIntoLatestProgress) {
        this.mergeIntoLatestProgress = mergeIntoLatestProgress;
        return this;
    }
    public Boolean getMergeIntoLatestProgress() {
        return this.mergeIntoLatestProgress;
    }

    public AgoalCreateProgressRequest setObjectiveId(String objectiveId) {
        this.objectiveId = objectiveId;
        return this;
    }
    public String getObjectiveId() {
        return this.objectiveId;
    }

    public AgoalCreateProgressRequest setPlainText(String plainText) {
        this.plainText = plainText;
        return this;
    }
    public String getPlainText() {
        return this.plainText;
    }

    public AgoalCreateProgressRequest setProgress(Integer progress) {
        this.progress = progress;
        return this;
    }
    public Integer getProgress() {
        return this.progress;
    }

    public AgoalCreateProgressRequest setProgressMergePeriod(String progressMergePeriod) {
        this.progressMergePeriod = progressMergePeriod;
        return this;
    }
    public String getProgressMergePeriod() {
        return this.progressMergePeriod;
    }

}
