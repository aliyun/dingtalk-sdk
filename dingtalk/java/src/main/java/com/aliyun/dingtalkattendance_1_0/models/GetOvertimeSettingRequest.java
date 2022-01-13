// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetOvertimeSettingRequest extends TeaModel {
    @NameInMap("overtimeSettingIds")
    public java.util.List<Long> overtimeSettingIds;

    public static GetOvertimeSettingRequest build(java.util.Map<String, ?> map) throws Exception {
        GetOvertimeSettingRequest self = new GetOvertimeSettingRequest();
        return TeaModel.build(map, self);
    }

    public GetOvertimeSettingRequest setOvertimeSettingIds(java.util.List<Long> overtimeSettingIds) {
        this.overtimeSettingIds = overtimeSettingIds;
        return this;
    }
    public java.util.List<Long> getOvertimeSettingIds() {
        return this.overtimeSettingIds;
    }

}
