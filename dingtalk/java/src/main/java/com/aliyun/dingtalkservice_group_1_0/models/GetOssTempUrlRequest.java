// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class GetOssTempUrlRequest extends TeaModel {
    // 团队开放ID
    @NameInMap("openTeamId")
    public String openTeamId;

    // oss文件key
    @NameInMap("key")
    public String key;

    // 文件名
    @NameInMap("fileName")
    public String fileName;

    // 访问模式 AUTO(自动，例如在浏览器中如果是图片，PDF等可以在线直接查看，不能在线看时自动下载)、DOWNLOAD（直接下载）
    @NameInMap("fetchMode")
    public String fetchMode;

    public static GetOssTempUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        GetOssTempUrlRequest self = new GetOssTempUrlRequest();
        return TeaModel.build(map, self);
    }

    public GetOssTempUrlRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public GetOssTempUrlRequest setKey(String key) {
        this.key = key;
        return this;
    }
    public String getKey() {
        return this.key;
    }

    public GetOssTempUrlRequest setFileName(String fileName) {
        this.fileName = fileName;
        return this;
    }
    public String getFileName() {
        return this.fileName;
    }

    public GetOssTempUrlRequest setFetchMode(String fetchMode) {
        this.fetchMode = fetchMode;
        return this;
    }
    public String getFetchMode() {
        return this.fetchMode;
    }

}
