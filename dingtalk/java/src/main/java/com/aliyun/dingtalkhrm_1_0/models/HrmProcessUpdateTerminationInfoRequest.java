// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class HrmProcessUpdateTerminationInfoRequest extends TeaModel {
    /**
     * <p>离职备注</p>
     */
    @NameInMap("dismissionMemo")
    public String dismissionMemo;

    /**
     * <p>最后工作日(离职日期)</p>
     */
    @NameInMap("lastWorkDate")
    public Long lastWorkDate;

    /**
     * <p>员工id</p>
     */
    @NameInMap("userId")
    public String userId;

    public static HrmProcessUpdateTerminationInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        HrmProcessUpdateTerminationInfoRequest self = new HrmProcessUpdateTerminationInfoRequest();
        return TeaModel.build(map, self);
    }

    public HrmProcessUpdateTerminationInfoRequest setDismissionMemo(String dismissionMemo) {
        this.dismissionMemo = dismissionMemo;
        return this;
    }
    public String getDismissionMemo() {
        return this.dismissionMemo;
    }

    public HrmProcessUpdateTerminationInfoRequest setLastWorkDate(Long lastWorkDate) {
        this.lastWorkDate = lastWorkDate;
        return this;
    }
    public Long getLastWorkDate() {
        return this.lastWorkDate;
    }

    public HrmProcessUpdateTerminationInfoRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
