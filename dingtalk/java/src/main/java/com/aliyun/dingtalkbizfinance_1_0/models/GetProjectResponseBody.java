// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetProjectResponseBody extends TeaModel {
    /**
     * <p>项目code</p>
     */
    @NameInMap("code")
    public String code;

    /**
     * <p>创建时间</p>
     */
    @NameInMap("createTime")
    public Long createTime;

    /**
     * <p>创建人工号</p>
     */
    @NameInMap("creator")
    public String creator;

    /**
     * <p>项目描述</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <p>项目名字</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>项目code，废弃，请使用code</p>
     */
    @NameInMap("projectCode")
    public String projectCode;

    /**
     * <p>项目名称，废弃，请使用name</p>
     */
    @NameInMap("projectName")
    public String projectName;

    /**
     * <p>状态:valid, invalid, deleted</p>
     */
    @NameInMap("status")
    public String status;

    /**
     * <p>用户自定义code</p>
     */
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
