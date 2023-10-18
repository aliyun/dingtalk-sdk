// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreExportCardRecordRequest extends TeaModel {
    @NameInMap("beginTime")
    public Long beginTime;

    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("ids")
    public java.util.List<Long> ids;

    @NameInMap("sceneCardName")
    public String sceneCardName;

    public static DigitalStoreExportCardRecordRequest build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreExportCardRecordRequest self = new DigitalStoreExportCardRecordRequest();
        return TeaModel.build(map, self);
    }

    public DigitalStoreExportCardRecordRequest setBeginTime(Long beginTime) {
        this.beginTime = beginTime;
        return this;
    }
    public Long getBeginTime() {
        return this.beginTime;
    }

    public DigitalStoreExportCardRecordRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public DigitalStoreExportCardRecordRequest setIds(java.util.List<Long> ids) {
        this.ids = ids;
        return this;
    }
    public java.util.List<Long> getIds() {
        return this.ids;
    }

    public DigitalStoreExportCardRecordRequest setSceneCardName(String sceneCardName) {
        this.sceneCardName = sceneCardName;
        return this;
    }
    public String getSceneCardName() {
        return this.sceneCardName;
    }

}
