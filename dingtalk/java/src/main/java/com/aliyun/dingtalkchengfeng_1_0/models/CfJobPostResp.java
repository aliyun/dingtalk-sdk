// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class CfJobPostResp extends TeaModel {
    /**
     * <p>职务编码</p>
     */
    @NameInMap("jobPostCode")
    public String jobPostCode;

    /**
     * <p>职务名称</p>
     */
    @NameInMap("name")
    public String name;

    public static CfJobPostResp build(java.util.Map<String, ?> map) throws Exception {
        CfJobPostResp self = new CfJobPostResp();
        return TeaModel.build(map, self);
    }

    public CfJobPostResp setJobPostCode(String jobPostCode) {
        this.jobPostCode = jobPostCode;
        return this;
    }
    public String getJobPostCode() {
        return this.jobPostCode;
    }

    public CfJobPostResp setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

}
