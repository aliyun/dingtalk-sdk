// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetSimpleOvertimeSettingRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pageSize")
    public Long pageSize;

    public static GetSimpleOvertimeSettingRequest build(java.util.Map<String, ?> map) throws Exception {
        GetSimpleOvertimeSettingRequest self = new GetSimpleOvertimeSettingRequest();
        return TeaModel.build(map, self);
    }

    public GetSimpleOvertimeSettingRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public GetSimpleOvertimeSettingRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

}
