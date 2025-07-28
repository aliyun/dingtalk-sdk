<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumBatchExecuteProcessInstancesRequest\taskInfoList;
use AlibabaCloud\Tea\Model;

class PremiumBatchExecuteProcessInstancesRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 67583405630
     *
     * @var string
     */
    public $actionerUserId;

    /**
     * @var string
     */
    public $remark;

    /**
     * @description This parameter is required.
     *
     * @example agree
     *
     * @var string
     */
    public $result;

    /**
     * @description This parameter is required.
     *
     * @var taskInfoList[]
     */
    public $taskInfoList;
    protected $_name = [
        'actionerUserId' => 'actionerUserId',
        'remark' => 'remark',
        'result' => 'result',
        'taskInfoList' => 'taskInfoList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionerUserId) {
            $res['actionerUserId'] = $this->actionerUserId;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->result) {
            $res['result'] = $this->result;
        }
        if (null !== $this->taskInfoList) {
            $res['taskInfoList'] = [];
            if (null !== $this->taskInfoList && \is_array($this->taskInfoList)) {
                $n = 0;
                foreach ($this->taskInfoList as $item) {
                    $res['taskInfoList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PremiumBatchExecuteProcessInstancesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionerUserId'])) {
            $model->actionerUserId = $map['actionerUserId'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['result'])) {
            $model->result = $map['result'];
        }
        if (isset($map['taskInfoList'])) {
            if (!empty($map['taskInfoList'])) {
                $model->taskInfoList = [];
                $n = 0;
                foreach ($map['taskInfoList'] as $item) {
                    $model->taskInfoList[$n++] = null !== $item ? taskInfoList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
