// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class ModifyFeedWhiteListResponseBody extends TeaModel {
    /**
     * <p>是否修改成功</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static ModifyFeedWhiteListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ModifyFeedWhiteListResponseBody self = new ModifyFeedWhiteListResponseBody();
        return TeaModel.build(map, self);
    }

    public ModifyFeedWhiteListResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
