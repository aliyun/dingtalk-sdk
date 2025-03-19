<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetConditionFormComponentRequest extends Model
{
    /**
     * @example 10
     *
     * @var int
     */
    public $agentId;

    /**
     * @description This parameter is required.
     *
     * @example PROC-xxx
     *
     * @var string
     */
    public $processCode;
    protected $_name = [
        'agentId' => 'agentId',
        'processCode' => 'processCode',
    ];

    public function validate() {}

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
