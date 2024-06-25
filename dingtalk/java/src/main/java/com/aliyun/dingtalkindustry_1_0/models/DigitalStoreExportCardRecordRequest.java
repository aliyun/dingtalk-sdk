// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreExportCardRecordRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>1696917858123</p>
     */
    @NameInMap("beginTime")
    public Long beginTime;

    /**
     * <strong>example:</strong>
     * <p>1696918858123</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("ids")
    public java.util.List<Long> ids;

    /**
     * <strong>example:</strong>
     * <p>场景卡片名称</p>
     */
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
