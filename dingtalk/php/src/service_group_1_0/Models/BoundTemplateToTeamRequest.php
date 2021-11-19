<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class BoundTemplateToTeamRequest extends Model
{
    /**
     * @var int
     */
    public $dingOrgId;

    /**
     * @var string
     */
    public $dingSuiteKey;

    /**
     * @var int
     */
    public $dingTokenGrantType;

    /**
     * @var int
     */
    public $dingIsvOrgId;

    /**
     * @description 目标团队id
     *
     * @var string
     */
    public $openTeamId;

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

    /**
     * @description 模板描述信息
     *
     * @var string
     */
    public $templateDesc;

    /**
     * @description 模板中的机器人配置信息
     *
     * @var string
     */
    public $robotConfig;
    protected $_name = [
        'dingOrgId'          => 'dingOrgId',
        'dingSuiteKey'       => 'dingSuiteKey',
        'dingTokenGrantType' => 'dingTokenGrantType',
        'dingIsvOrgId'       => 'dingIsvOrgId',
        'openTeamId'         => 'openTeamId',
        'templateId'         => 'templateId',
        'templateName'       => 'templateName',
        'templateType'       => 'templateType',
        'templateDesc'       => 'templateDesc',
        'robotConfig'        => 'robotConfig',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }
        if (null !== $this->dingTokenGrantType) {
            $res['dingTokenGrantType'] = $this->dingTokenGrantType;
        }
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
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
        if (null !== $this->templateDesc) {
            $res['templateDesc'] = $this->templateDesc;
        }
        if (null !== $this->robotConfig) {
            $res['robotConfig'] = $this->robotConfig;
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
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }
        if (isset($map['dingTokenGrantType'])) {
            $model->dingTokenGrantType = $map['dingTokenGrantType'];
        }
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
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
        if (isset($map['templateDesc'])) {
            $model->templateDesc = $map['templateDesc'];
        }
        if (isset($map['robotConfig'])) {
            $model->robotConfig = $map['robotConfig'];
        }

        return $model;
    }
}
