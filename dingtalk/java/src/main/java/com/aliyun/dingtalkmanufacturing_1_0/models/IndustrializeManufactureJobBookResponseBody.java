// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmanufacturing_1_0.models;

import com.aliyun.tea.*;

public class IndustrializeManufactureJobBookResponseBody extends TeaModel {
    // httpCode
    @NameInMap("httpCode")
    public String httpCode;

    // 此次报工记录的唯一标识
    @NameInMap("uuid")
    public String uuid;

    // content
    @NameInMap("content")
    public String content;

    // errorMsg
    @NameInMap("errorMsg")
    public String errorMsg;

    // errorLevel
    @NameInMap("errorLevel")
    public Integer errorLevel;

    // errorCode
    @NameInMap("errorCode")
    public String errorCode;

    // success
    @NameInMap("success")
    public Boolean success;

    public static IndustrializeManufactureJobBookResponseBody build(java.util.Map<String, ?> map) throws Exception {
        IndustrializeManufactureJobBookResponseBody self = new IndustrializeManufactureJobBookResponseBody();
        return TeaModel.build(map, self);
    }

    public IndustrializeManufactureJobBookResponseBody setHttpCode(String httpCode) {
        this.httpCode = httpCode;
        return this;
    }
    public String getHttpCode() {
        return this.httpCode;
    }

    public IndustrializeManufactureJobBookResponseBody setUuid(String uuid) {
        this.uuid = uuid;
        return this;
    }
    public String getUuid() {
        return this.uuid;
    }

    public IndustrializeManufactureJobBookResponseBody setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public IndustrializeManufactureJobBookResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public IndustrializeManufactureJobBookResponseBody setErrorLevel(Integer errorLevel) {
        this.errorLevel = errorLevel;
        return this;
    }
    public Integer getErrorLevel() {
        return this.errorLevel;
    }

    public IndustrializeManufactureJobBookResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public IndustrializeManufactureJobBookResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
