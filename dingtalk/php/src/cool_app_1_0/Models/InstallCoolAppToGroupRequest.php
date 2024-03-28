<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcool_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class InstallCoolAppToGroupRequest extends Model
{
    /**
     * @example cidxxxx
     *
     * @var string
     */
    public $conversationId;

    /**
     * @example CoolApp-xxx
     *
     * @var string
     */
    public $operateCoolAppCode;

    /**
     * @example staffid12
     *
     * @var string
     */
    public $operatorId;

    /**
     * @example template-id-xxx
     *
     * @var string
     */
    public $templateId;
    protected $_name = [
        'conversationId'     => 'conversationId',
        'operateCoolAppCode' => 'operateCoolAppCode',
        'operatorId'         => 'operatorId',
        'templateId'         => 'templateId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->conversationId) {
            $res['conversationId'] = $this->conversationId;
        }
        if (null !== $this->operateCoolAppCode) {
            $res['operateCoolAppCode'] = $this->operateCoolAppCode;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return InstallCoolAppToGroupRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['conversationId'])) {
            $model->conversationId = $map['conversationId'];
        }
        if (isset($map['operateCoolAppCode'])) {
            $model->operateCoolAppCode = $map['operateCoolAppCode'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }

        return $model;
    }
}
