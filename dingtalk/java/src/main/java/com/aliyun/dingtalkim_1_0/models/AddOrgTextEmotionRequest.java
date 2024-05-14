// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class AddOrgTextEmotionRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("backgroundMediaId")
    public String backgroundMediaId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("backgroundMediaIdForPanel")
    public String backgroundMediaIdForPanel;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("deptId")
    public Long deptId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("emotionName")
    public String emotionName;

    public static AddOrgTextEmotionRequest build(java.util.Map<String, ?> map) throws Exception {
        AddOrgTextEmotionRequest self = new AddOrgTextEmotionRequest();
        return TeaModel.build(map, self);
    }

    public AddOrgTextEmotionRequest setBackgroundMediaId(String backgroundMediaId) {
        this.backgroundMediaId = backgroundMediaId;
        return this;
    }
    public String getBackgroundMediaId() {
        return this.backgroundMediaId;
    }

    public AddOrgTextEmotionRequest setBackgroundMediaIdForPanel(String backgroundMediaIdForPanel) {
        this.backgroundMediaIdForPanel = backgroundMediaIdForPanel;
        return this;
    }
    public String getBackgroundMediaIdForPanel() {
        return this.backgroundMediaIdForPanel;
    }

    public AddOrgTextEmotionRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public AddOrgTextEmotionRequest setEmotionName(String emotionName) {
        this.emotionName = emotionName;
        return this;
    }
    public String getEmotionName() {
        return this.emotionName;
    }

}
