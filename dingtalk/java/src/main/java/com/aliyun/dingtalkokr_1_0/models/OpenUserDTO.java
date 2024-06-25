// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class OpenUserDTO extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>0342464558835299</p>
     */
    @NameInMap("dingUserId")
    public String dingUserId;

    /**
     * <strong>example:</strong>
     * <p>小明</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <strong>example:</strong>
     * <p>64cd2e9bb80efb17244c650d</p>
     */
    @NameInMap("userUid")
    public String userUid;

    /**
     * <strong>example:</strong>
     * <p>2639402752-1812711657</p>
     */
    @NameInMap("workNo")
    public String workNo;

    public static OpenUserDTO build(java.util.Map<String, ?> map) throws Exception {
        OpenUserDTO self = new OpenUserDTO();
        return TeaModel.build(map, self);
    }

    public OpenUserDTO setDingUserId(String dingUserId) {
        this.dingUserId = dingUserId;
        return this;
    }
    public String getDingUserId() {
        return this.dingUserId;
    }

    public OpenUserDTO setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public OpenUserDTO setUserUid(String userUid) {
        this.userUid = userUid;
        return this;
    }
    public String getUserUid() {
        return this.userUid;
    }

    public OpenUserDTO setWorkNo(String workNo) {
        this.workNo = workNo;
        return this;
    }
    public String getWorkNo() {
        return this.workNo;
    }

}
