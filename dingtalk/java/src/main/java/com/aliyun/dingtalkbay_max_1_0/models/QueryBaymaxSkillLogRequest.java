// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbay_max_1_0.models;

import com.aliyun.tea.*;

public class QueryBaymaxSkillLogRequest extends TeaModel {
    @NameInMap("from")
    public Integer from;

    @NameInMap("skillExecuteId")
    public String skillExecuteId;

    @NameInMap("to")
    public Integer to;

    public static QueryBaymaxSkillLogRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryBaymaxSkillLogRequest self = new QueryBaymaxSkillLogRequest();
        return TeaModel.build(map, self);
    }

    public QueryBaymaxSkillLogRequest setFrom(Integer from) {
        this.from = from;
        return this;
    }
    public Integer getFrom() {
        return this.from;
    }

    public QueryBaymaxSkillLogRequest setSkillExecuteId(String skillExecuteId) {
        this.skillExecuteId = skillExecuteId;
        return this;
    }
    public String getSkillExecuteId() {
        return this.skillExecuteId;
    }

    public QueryBaymaxSkillLogRequest setTo(Integer to) {
        this.to = to;
        return this;
    }
    public Integer getTo() {
        return this.to;
    }

}
