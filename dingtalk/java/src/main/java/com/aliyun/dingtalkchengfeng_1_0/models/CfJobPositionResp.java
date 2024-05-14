// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class CfJobPositionResp extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("jobPositionCode")
    public String jobPositionCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("name")
    public String name;

    public static CfJobPositionResp build(java.util.Map<String, ?> map) throws Exception {
        CfJobPositionResp self = new CfJobPositionResp();
        return TeaModel.build(map, self);
    }

    public CfJobPositionResp setJobPositionCode(String jobPositionCode) {
        this.jobPositionCode = jobPositionCode;
        return this;
    }
    public String getJobPositionCode() {
        return this.jobPositionCode;
    }

    public CfJobPositionResp setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

}
