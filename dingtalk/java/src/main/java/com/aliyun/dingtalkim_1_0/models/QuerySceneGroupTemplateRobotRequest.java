// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QuerySceneGroupTemplateRobotRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>cidCtneF+XyQjcyF2ROdgSeIg==</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <strong>example:</strong>
     * <p>ding5nbbeXXXXXXX</p>
     */
    @NameInMap("robotCode")
    public String robotCode;

    public static QuerySceneGroupTemplateRobotRequest build(java.util.Map<String, ?> map) throws Exception {
        QuerySceneGroupTemplateRobotRequest self = new QuerySceneGroupTemplateRobotRequest();
        return TeaModel.build(map, self);
    }

    public QuerySceneGroupTemplateRobotRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public QuerySceneGroupTemplateRobotRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

}
