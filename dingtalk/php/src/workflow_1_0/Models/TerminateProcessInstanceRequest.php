<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class TerminateProcessInstanceRequest extends Model
{
    /**
     * @description 是否通过系统操作：
     *
     * false：由指定的操作者终止
     * @var bool
     */
    public $isSystem;

    /**
     * @description 操作人的userid。
     *
     * 当is_system为false时，该参数必传。
     * @var string
     */
    public $operatingUserId;

    /**
     * @description 审批实例ID，可通过调用获取审批实例ID列表接口获取。
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @description 终止说明。
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
