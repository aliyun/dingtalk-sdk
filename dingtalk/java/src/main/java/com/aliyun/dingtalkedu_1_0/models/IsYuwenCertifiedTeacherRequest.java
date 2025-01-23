// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class IsYuwenCertifiedTeacherRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizCode")
    public String bizCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static IsYuwenCertifiedTeacherRequest build(java.util.Map<String, ?> map) throws Exception {
        IsYuwenCertifiedTeacherRequest self = new IsYuwenCertifiedTeacherRequest();
        return TeaModel.build(map, self);
    }

    public IsYuwenCertifiedTeacherRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

    public IsYuwenCertifiedTeacherRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
