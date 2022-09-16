// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class CleanProcessDataRequest extends TeaModel {
    // 企业的corpId。
    @NameInMap("corpId")
    public String corpId;

    // 模板唯一码。
    @NameInMap("processCode")
    public String processCode;

    public static CleanProcessDataRequest build(java.util.Map<String, ?> map) throws Exception {
        CleanProcessDataRequest self = new CleanProcessDataRequest();
        return TeaModel.build(map, self);
    }

    public CleanProcessDataRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public CleanProcessDataRequest setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

}
