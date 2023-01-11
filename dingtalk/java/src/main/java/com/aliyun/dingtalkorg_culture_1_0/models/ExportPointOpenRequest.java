// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class ExportPointOpenRequest extends TeaModel {
    /**
     * <p>exportType为1时不需要传此参数，目前仅exportType=3时必须传入此参数,必须为七日内某一天且不能选择当日，格式yyyyMmdd。</p>
     */
    @NameInMap("exportDate")
    public String exportDate;

    /**
     * <p>导出类型 1为七日内明细，3为七日内某一天榜单，且都不包含当日</p>
     */
    @NameInMap("exportType")
    public Long exportType;

    /**
     * <p>操作人userId 必须为管理员</p>
     */
    @NameInMap("userId")
    public String userId;

    public static ExportPointOpenRequest build(java.util.Map<String, ?> map) throws Exception {
        ExportPointOpenRequest self = new ExportPointOpenRequest();
        return TeaModel.build(map, self);
    }

    public ExportPointOpenRequest setExportDate(String exportDate) {
        this.exportDate = exportDate;
        return this;
    }
    public String getExportDate() {
        return this.exportDate;
    }

    public ExportPointOpenRequest setExportType(Long exportType) {
        this.exportType = exportType;
        return this;
    }
    public Long getExportType() {
        return this.exportType;
    }

    public ExportPointOpenRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
