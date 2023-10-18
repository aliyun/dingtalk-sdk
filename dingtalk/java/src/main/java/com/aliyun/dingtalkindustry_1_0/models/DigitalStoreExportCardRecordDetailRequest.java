// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreExportCardRecordDetailRequest extends TeaModel {
    @NameInMap("beginTime")
    public Long beginTime;

    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("ids")
    public java.util.List<Long> ids;

    @NameInMap("sceneCardName")
    public String sceneCardName;

    public static DigitalStoreExportCardRecordDetailRequest build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreExportCardRecordDetailRequest self = new DigitalStoreExportCardRecordDetailRequest();
        return TeaModel.build(map, self);
    }

    public DigitalStoreExportCardRecordDetailRequest setBeginTime(Long beginTime) {
        this.beginTime = beginTime;
        return this;
    }
    public Long getBeginTime() {
        return this.beginTime;
    }

    public DigitalStoreExportCardRecordDetailRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public DigitalStoreExportCardRecordDetailRequest setIds(java.util.List<Long> ids) {
        this.ids = ids;
        return this;
    }
    public java.util.List<Long> getIds() {
        return this.ids;
    }

    public DigitalStoreExportCardRecordDetailRequest setSceneCardName(String sceneCardName) {
        this.sceneCardName = sceneCardName;
        return this;
    }
    public String getSceneCardName() {
        return this.sceneCardName;
    }

}
