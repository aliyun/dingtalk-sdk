// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class QueryCreateEnterpriseAgentRequest extends TeaModel {
    @NameInMap("taskId")
    public String taskId;

    @NameInMap("userid")
    public String userid;

    public static QueryCreateEnterpriseAgentRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCreateEnterpriseAgentRequest self = new QueryCreateEnterpriseAgentRequest();
        return TeaModel.build(map, self);
    }

    public QueryCreateEnterpriseAgentRequest setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

    public QueryCreateEnterpriseAgentRequest setUserid(String userid) {
        this.userid = userid;
        return this;
    }
    public String getUserid() {
        return this.userid;
    }

}
