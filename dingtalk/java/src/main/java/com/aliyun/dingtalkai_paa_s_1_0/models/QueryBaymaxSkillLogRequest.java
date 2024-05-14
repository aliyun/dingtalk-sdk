// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class QueryBaymaxSkillLogRequest extends TeaModel {
    @NameInMap("from")
    public Integer from;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("logLevel")
    public String logLevel;

    /**
     * <p>This parameter is required.</p>
     */
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

    public QueryBaymaxSkillLogRequest setLogLevel(String logLevel) {
        this.logLevel = logLevel;
        return this;
    }
    public String getLogLevel() {
        return this.logLevel;
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
