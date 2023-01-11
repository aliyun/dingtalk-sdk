// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class PushOfficialAccountMessageResponseBody extends TeaModel {
    /**
     * <p>推送queryKey</p>
     */
    @NameInMap("result")
    public String result;

    public static PushOfficialAccountMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PushOfficialAccountMessageResponseBody self = new PushOfficialAccountMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public PushOfficialAccountMessageResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
