// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateSceneGroupTemplateMessageOpenStatusRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("status")
    public Integer status;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("templateIdList")
    public java.util.List<String> templateIdList;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static UpdateSceneGroupTemplateMessageOpenStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateSceneGroupTemplateMessageOpenStatusRequest self = new UpdateSceneGroupTemplateMessageOpenStatusRequest();
        return TeaModel.build(map, self);
    }

    public UpdateSceneGroupTemplateMessageOpenStatusRequest setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public UpdateSceneGroupTemplateMessageOpenStatusRequest setTemplateIdList(java.util.List<String> templateIdList) {
        this.templateIdList = templateIdList;
        return this;
    }
    public java.util.List<String> getTemplateIdList() {
        return this.templateIdList;
    }

    public UpdateSceneGroupTemplateMessageOpenStatusRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
