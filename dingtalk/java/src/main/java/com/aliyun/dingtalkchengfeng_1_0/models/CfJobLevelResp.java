// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class CfJobLevelResp extends TeaModel {
    /**
     * <p>级别</p>
     */
    @NameInMap("level")
    public Long level;

    /**
     * <p>名称</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>生效日期</p>
     */
    @NameInMap("startDate")
    public String startDate;

    /**
     * <p>失效日期</p>
     */
    @NameInMap("stopDate")
    public String stopDate;

    public static CfJobLevelResp build(java.util.Map<String, ?> map) throws Exception {
        CfJobLevelResp self = new CfJobLevelResp();
        return TeaModel.build(map, self);
    }

    public CfJobLevelResp setLevel(Long level) {
        this.level = level;
        return this;
    }
    public Long getLevel() {
        return this.level;
    }

    public CfJobLevelResp setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CfJobLevelResp setStartDate(String startDate) {
        this.startDate = startDate;
        return this;
    }
    public String getStartDate() {
        return this.startDate;
    }

    public CfJobLevelResp setStopDate(String stopDate) {
        this.stopDate = stopDate;
        return this;
    }
    public String getStopDate() {
        return this.stopDate;
    }

}
