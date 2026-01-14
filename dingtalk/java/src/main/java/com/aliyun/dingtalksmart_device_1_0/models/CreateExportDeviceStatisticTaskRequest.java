// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class CreateExportDeviceStatisticTaskRequest extends TeaModel {
    @NameInMap("aiSheetTemplateId")
    public Long aiSheetTemplateId;

    @NameInMap("creatorCorpId")
    public String creatorCorpId;

    @NameInMap("creatorUnionId")
    public String creatorUnionId;

    @NameInMap("taskName")
    public String taskName;

    public static CreateExportDeviceStatisticTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateExportDeviceStatisticTaskRequest self = new CreateExportDeviceStatisticTaskRequest();
        return TeaModel.build(map, self);
    }

    public CreateExportDeviceStatisticTaskRequest setAiSheetTemplateId(Long aiSheetTemplateId) {
        this.aiSheetTemplateId = aiSheetTemplateId;
        return this;
    }
    public Long getAiSheetTemplateId() {
        return this.aiSheetTemplateId;
    }

    public CreateExportDeviceStatisticTaskRequest setCreatorCorpId(String creatorCorpId) {
        this.creatorCorpId = creatorCorpId;
        return this;
    }
    public String getCreatorCorpId() {
        return this.creatorCorpId;
    }

    public CreateExportDeviceStatisticTaskRequest setCreatorUnionId(String creatorUnionId) {
        this.creatorUnionId = creatorUnionId;
        return this;
    }
    public String getCreatorUnionId() {
        return this.creatorUnionId;
    }

    public CreateExportDeviceStatisticTaskRequest setTaskName(String taskName) {
        this.taskName = taskName;
        return this;
    }
    public String getTaskName() {
        return this.taskName;
    }

}
