// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetProjectResponseBody extends TeaModel {
    // 项目code
    @NameInMap("code")
    public String code;

    // 创建时间
    @NameInMap("createTime")
    public Long createTime;

    // 创建人工号
    @NameInMap("creator")
    public String creator;

    // 项目描述
    @NameInMap("description")
    public String description;

    // 项目名字
    @NameInMap("name")
    public String name;

    // 项目code，废弃，请使用code
    @NameInMap("projectCode")
    public String projectCode;

    // 项目名称，废弃，请使用name
    @NameInMap("projectName")
    public String projectName;

    // 状态:valid, invalid, deleted
    @NameInMap("status")
    public String status;

    // 用户自定义code
    @NameInMap("userDefineCode")
    public String userDefineCode;

    public static GetProjectResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetProjectResponseBody self = new GetProjectResponseBody();
        return TeaModel.build(map, self);
    }

    public GetProjectResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public GetProjectResponseBody setCreateTime(Long createTime) {
        this.createTime = createTime;
        return this;
    }
    public Long getCreateTime() {
        return this.createTime;
    }

    public GetProjectResponseBody setCreator(String creator) {
        this.creator = creator;
        return this;
    }
    public String getCreator() {
        return this.creator;
    }

    public GetProjectResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public GetProjectResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetProjectResponseBody setProjectCode(String projectCode) {
        this.projectCode = projectCode;
        return this;
    }
    public String getProjectCode() {
        return this.projectCode;
    }

    public GetProjectResponseBody setProjectName(String projectName) {
        this.projectName = projectName;
        return this;
    }
    public String getProjectName() {
        return this.projectName;
    }

    public GetProjectResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public GetProjectResponseBody setUserDefineCode(String userDefineCode) {
        this.userDefineCode = userDefineCode;
        return this;
    }
    public String getUserDefineCode() {
        return this.userDefineCode;
    }

}
