// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreateProjectByTemplateRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>这是项目描述</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <strong>example:</strong>
     * <p>2021-08-13T07:36:50.318Z</p>
     */
    @NameInMap("endDate")
    public String endDate;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>项目1</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <strong>example:</strong>
     * <p>578cae9dbf83e5xxxx</p>
     */
    @NameInMap("programId")
    public String programId;

    /**
     * <strong>example:</strong>
     * <p>通过名称填写项目集</p>
     */
    @NameInMap("programName")
    public String programName;

    /**
     * <strong>example:</strong>
     * <p>2021-08-13T07:36:50.318Z</p>
     */
    @NameInMap("startDate")
    public String startDate;

    /**
     * <strong>example:</strong>
     * <p>578cae9dbf83e5xxxx</p>
     */
    @NameInMap("templateId")
    public String templateId;

    /**
     * <strong>example:</strong>
     * <p>通过名称填写项目模板</p>
     */
    @NameInMap("templateName")
    public String templateName;

    /**
     * <strong>example:</strong>
     * <p>project</p>
     */
    @NameInMap("visibility")
    public String visibility;

    public static CreateProjectByTemplateRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateProjectByTemplateRequest self = new CreateProjectByTemplateRequest();
        return TeaModel.build(map, self);
    }

    public CreateProjectByTemplateRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public CreateProjectByTemplateRequest setEndDate(String endDate) {
        this.endDate = endDate;
        return this;
    }
    public String getEndDate() {
        return this.endDate;
    }

    public CreateProjectByTemplateRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateProjectByTemplateRequest setProgramId(String programId) {
        this.programId = programId;
        return this;
    }
    public String getProgramId() {
        return this.programId;
    }

    public CreateProjectByTemplateRequest setProgramName(String programName) {
        this.programName = programName;
        return this;
    }
    public String getProgramName() {
        return this.programName;
    }

    public CreateProjectByTemplateRequest setStartDate(String startDate) {
        this.startDate = startDate;
        return this;
    }
    public String getStartDate() {
        return this.startDate;
    }

    public CreateProjectByTemplateRequest setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

    public CreateProjectByTemplateRequest setTemplateName(String templateName) {
        this.templateName = templateName;
        return this;
    }
    public String getTemplateName() {
        return this.templateName;
    }

    public CreateProjectByTemplateRequest setVisibility(String visibility) {
        this.visibility = visibility;
        return this;
    }
    public String getVisibility() {
        return this.visibility;
    }

}
