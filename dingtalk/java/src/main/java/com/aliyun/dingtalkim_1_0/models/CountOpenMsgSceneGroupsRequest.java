// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CountOpenMsgSceneGroupsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>f6xxxxx</p>
     */
    @NameInMap("templateId")
    public String templateId;

    public static CountOpenMsgSceneGroupsRequest build(java.util.Map<String, ?> map) throws Exception {
        CountOpenMsgSceneGroupsRequest self = new CountOpenMsgSceneGroupsRequest();
        return TeaModel.build(map, self);
    }

    public CountOpenMsgSceneGroupsRequest setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

}
