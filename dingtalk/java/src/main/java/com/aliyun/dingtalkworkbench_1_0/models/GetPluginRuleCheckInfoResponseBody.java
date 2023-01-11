// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkbench_1_0.models;

import com.aliyun.tea.*;

public class GetPluginRuleCheckInfoResponseBody extends TeaModel {
    /**
     * <p>权限包code</p>
     */
    @NameInMap("packCode")
    public String packCode;

    /**
     * <p>校验规则</p>
     */
    @NameInMap("pluginRuleCheckDetail")
    public String pluginRuleCheckDetail;

    public static GetPluginRuleCheckInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetPluginRuleCheckInfoResponseBody self = new GetPluginRuleCheckInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetPluginRuleCheckInfoResponseBody setPackCode(String packCode) {
        this.packCode = packCode;
        return this;
    }
    public String getPackCode() {
        return this.packCode;
    }

    public GetPluginRuleCheckInfoResponseBody setPluginRuleCheckDetail(String pluginRuleCheckDetail) {
        this.pluginRuleCheckDetail = pluginRuleCheckDetail;
        return this;
    }
    public String getPluginRuleCheckDetail() {
        return this.pluginRuleCheckDetail;
    }

}
