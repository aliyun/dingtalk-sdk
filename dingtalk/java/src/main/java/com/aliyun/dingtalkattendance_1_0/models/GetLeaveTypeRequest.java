// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetLeaveTypeRequest extends TeaModel {
    /**
     * <p>操作者ID</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    /**
     * <p>空:开放接口定义假期类型;all:所有假期类型</p>
     */
    @NameInMap("vacationSource")
    public String vacationSource;

    public static GetLeaveTypeRequest build(java.util.Map<String, ?> map) throws Exception {
        GetLeaveTypeRequest self = new GetLeaveTypeRequest();
        return TeaModel.build(map, self);
    }

    public GetLeaveTypeRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public GetLeaveTypeRequest setVacationSource(String vacationSource) {
        this.vacationSource = vacationSource;
        return this;
    }
    public String getVacationSource() {
        return this.vacationSource;
    }

}
