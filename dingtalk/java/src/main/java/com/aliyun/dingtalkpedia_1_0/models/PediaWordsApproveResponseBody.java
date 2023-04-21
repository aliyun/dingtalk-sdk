// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpedia_1_0.models;

import com.aliyun.tea.*;

public class PediaWordsApproveResponseBody extends TeaModel {
    /**
     * <p>返回结果</p>
     * <p>false，失败</p>
     * <p>true，成功</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static PediaWordsApproveResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PediaWordsApproveResponseBody self = new PediaWordsApproveResponseBody();
        return TeaModel.build(map, self);
    }

    public PediaWordsApproveResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
