<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class TerminateProcessInstanceRequest extends Model
{
    /**
     * @var bool
     */
    public $isSystem;

    /**
     * @example 133743186427339452
     *
     * @var string
     */
    public $operatingUserId;

    /**
     * @example a171de6c-8bxxxx
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @example 终止说明。
     *
     * @var string
     */
    public $remark;
    protected $_name = [
        'isSystem'          => 'isSystem',
        'operatingUserId'   => 'operatingUserId',
        'processInstanceId' => 'processInstanceId',
        'remark'            => 'remark',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->isSystem) {
            $res['isSystem'] = $this->isSystem;
        }
        if (null !== $this->operatingUserId) {
            $res['operatingUserId'] = $this->operatingUserId;
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return TerminateProcessInstanceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['isSystem'])) {
            $model->isSystem = $map['isSystem'];
        }
        if (isset($map['operatingUserId'])) {
            $model->operatingUserId = $map['operatingUserId'];
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }

        return $model;
    }
}
