// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class PullDataByPkResponseBody extends TeaModel {
    // 数据创建时间。
    @NameInMap("dataGmtCreate")
    public Long dataGmtCreate;

    // 数据最后修改时间。
    @NameInMap("dataGmtModified")
    public Long dataGmtModified;

    // 创建数据的应用类型，isv应用为premium_microapp。
    @NameInMap("dataCreateAppType")
    public String dataCreateAppType;

    // 创建数据的应用id。
    @NameInMap("dataCreateAppId")
    public String dataCreateAppId;

    // 最后修改数据的应用类型，取值同dataCreateAppType。
    @NameInMap("dataModifiedAppType")
    public String dataModifiedAppType;

    // 最后修改数据的应用id。
    @NameInMap("dataModifiedAppId")
    public String dataModifiedAppId;

    // 数据完整内容。
    @NameInMap("jsonData")
    public String jsonData;

    public static PullDataByPkResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PullDataByPkResponseBody self = new PullDataByPkResponseBody();
        return TeaModel.build(map, self);
    }

    public PullDataByPkResponseBody setDataGmtCreate(Long dataGmtCreate) {
        this.dataGmtCreate = dataGmtCreate;
        return this;
    }
    public Long getDataGmtCreate() {
        return this.dataGmtCreate;
    }

    public PullDataByPkResponseBody setDataGmtModified(Long dataGmtModified) {
        this.dataGmtModified = dataGmtModified;
        return this;
    }
    public Long getDataGmtModified() {
        return this.dataGmtModified;
    }

    public PullDataByPkResponseBody setDataCreateAppType(String dataCreateAppType) {
        this.dataCreateAppType = dataCreateAppType;
        return this;
    }
    public String getDataCreateAppType() {
        return this.dataCreateAppType;
    }

    public PullDataByPkResponseBody setDataCreateAppId(String dataCreateAppId) {
        this.dataCreateAppId = dataCreateAppId;
        return this;
    }
    public String getDataCreateAppId() {
        return this.dataCreateAppId;
    }

    public PullDataByPkResponseBody setDataModifiedAppType(String dataModifiedAppType) {
        this.dataModifiedAppType = dataModifiedAppType;
        return this;
    }
    public String getDataModifiedAppType() {
        return this.dataModifiedAppType;
    }

    public PullDataByPkResponseBody setDataModifiedAppId(String dataModifiedAppId) {
        this.dataModifiedAppId = dataModifiedAppId;
        return this;
    }
    public String getDataModifiedAppId() {
        return this.dataModifiedAppId;
    }

    public PullDataByPkResponseBody setJsonData(String jsonData) {
        this.jsonData = jsonData;
        return this;
    }
    public String getJsonData() {
        return this.jsonData;
    }

}
