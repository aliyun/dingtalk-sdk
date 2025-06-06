<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class PremiumAppendTaskRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example ALL
     *
     * @var string
     */
    public $activateType;

    /**
     * @var bool
     */
    public $agreeAll;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $appenderUserIds;

    /**
     * @description This parameter is required.
     *
     * @example manager001
     *
     * @var string
     */
    public $operateUserId;

    /**
     * @description This parameter is required.
     *
     * @example processInstanceId123
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @example 请XX帮忙审批一下
     *
     * @var string
     */
    public $remark;

    /**
     * @description This parameter is required.
     *
     * @example 1234567
     *
     * @var int
     */
    public $taskId;

    /**
     * @description This parameter is required.
     *
     * @example after
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'activateType' => 'activateType',
        'agreeAll' => 'agreeAll',
        'appenderUserIds' => 'appenderUserIds',
        'operateUserId' => 'operateUserId',
        'processInstanceId' => 'processInstanceId',
        'remark' => 'remark',
        'taskId' => 'taskId',
        'type' => 'type',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->activateType) {
            $res['activateType'] = $this->activateType;
        }
        if (null !== $this->agreeAll) {
            $res['agreeAll'] = $this->agreeAll;
        }
        if (null !== $this->appenderUserIds) {
            $res['appenderUserIds'] = $this->appenderUserIds;
        }
        if (null !== $this->operateUserId) {
            $res['operateUserId'] = $this->operateUserId;
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PremiumAppendTaskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['activateType'])) {
            $model->activateType = $map['activateType'];
        }
        if (isset($map['agreeAll'])) {
            $model->agreeAll = $map['agreeAll'];
        }
        if (isset($map['appenderUserIds'])) {
            if (!empty($map['appenderUserIds'])) {
                $model->appenderUserIds = $map['appenderUserIds'];
            }
        }
        if (isset($map['operateUserId'])) {
            $model->operateUserId = $map['operateUserId'];
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
