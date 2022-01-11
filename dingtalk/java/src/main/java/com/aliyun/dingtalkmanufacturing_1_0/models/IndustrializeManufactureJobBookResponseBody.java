// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmanufacturing_1_0.models;

import com.aliyun.tea.*;

public class IndustrializeManufactureJobBookResponseBody extends TeaModel {
    // content
    @NameInMap("content")
    public String content;

    // errorCode
    @NameInMap("errorCode")
    public String errorCode;

    // errorLevel
    @NameInMap("errorLevel")
    public Integer errorLevel;

    // errorMsg
    @NameInMap("errorMsg")
    public String errorMsg;

    // httpCode
    @NameInMap("httpCode")
    public String httpCode;

    // success
    @NameInMap("success")
    public Boolean success;

    // 此次报工记录的唯一标识
    @NameInMap("uuid")
    public String uuid;

    public static IndustrializeManufactureJobBookResponseBody build(java.util.Map<String, ?> map) throws Exception {
        IndustrializeManufactureJobBookResponseBody self = new IndustrializeManufactureJobBookResponseBody();
        return TeaModel.build(map, self);
    }

    public IndustrializeManufactureJobBookResponseBody setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public IndustrializeManufactureJobBookResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public IndustrializeManufactureJobBookResponseBody setErrorLevel(Integer errorLevel) {
        this.errorLevel = errorLevel;
        return this;
    }
    public Integer getErrorLevel() {
        return this.errorLevel;
    }

    public IndustrializeManufactureJobBookResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public IndustrializeManufactureJobBookResponseBody setHttpCode(String httpCode) {
        this.httpCode = httpCode;
        return this;
    }
    public String getHttpCode() {
        return this.httpCode;
    }

    public IndustrializeManufactureJobBookResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public IndustrializeManufactureJobBookResponseBody setUuid(String uuid) {
        this.uuid = uuid;
        return this;
    }
    public String getUuid() {
        return this.uuid;
    }

}
