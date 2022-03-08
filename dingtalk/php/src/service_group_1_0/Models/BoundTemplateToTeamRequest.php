<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class BoundTemplateToTeamRequest extends Model
{
    /**
     * @description 目标团队id
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @description 模板中的机器人配置信息
     *
     * @var string
     */
    public $robotConfig;

    /**
     * @description 模板描述信息
     *
     * @var string
     */
    public $templateDesc;

    /**
     * @description 模板id
     *
     * @var string
     */
    public $templateId;

    /**
     * @description 模板名字
     *
     * @var string
     */
    public $templateName;

    /**
     * @description 模板类型
     *
     * @var string
     */
    public $templateType;
    protected $_name = [
        'openTeamId'   => 'openTeamId',
        'robotConfig'  => 'robotConfig',
        'templateDesc' => 'templateDesc',
        'templateId'   => 'templateId',
        'templateName' => 'templateName',
        'templateType' => 'templateType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }
        if (null !== $this->robotConfig) {
            $res['robotConfig'] = $this->robotConfig;
        }
        if (null !== $this->templateDesc) {
            $res['templateDesc'] = $this->templateDesc;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }
        if (null !== $this->templateName) {
            $res['templateName'] = $this->templateName;
        }
        if (null !== $this->templateType) {
            $res['templateType'] = $this->templateType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BoundTemplateToTeamRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['robotConfig'])) {
            $model->robotConfig = $map['robotConfig'];
        }
        if (isset($map['templateDesc'])) {
            $model->templateDesc = $map['templateDesc'];
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }
        if (isset($map['templateName'])) {
            $model->templateName = $map['templateName'];
        }
        if (isset($map['templateType'])) {
            $model->templateType = $map['templateType'];
        }

        return $model;
    }
}
