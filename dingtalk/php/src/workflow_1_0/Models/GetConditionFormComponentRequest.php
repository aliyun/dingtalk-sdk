<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetConditionFormComponentRequest extends Model
{
    /**
     * @description 应用ID (三方应用为AppID)，可在开发者管理后台后台的应用详情页面获取。
     *
     * @var int
     */
    public $agentId;

    /**
     * @description 审批模板ID。
     *
     * processCode需要OA管理后台，在编辑审批表单的URL中获取。
     * @var string
     */
    public $processCode;
    protected $_name = [
        'agentId'     => 'agentId',
        'processCode' => 'processCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentId) {
            $res['agentId'] = $this->agentId;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetConditionFormComponentRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentId'])) {
            $model->agentId = $map['agentId'];
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }

        return $model;
    }
}
