<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\BatchUpdateProcessInstanceRequest;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\BatchUpdateProcessInstanceRequest\updateProcessInstanceRequests\notifiers;
use AlibabaCloud\Tea\Model;

class updateProcessInstanceRequests extends Model
{
    /**
     * @description 抄送列表，注意最大抄送人数量不能超过30。
     *
     * @var notifiers[]
     */
    public $notifiers;

    /**
     * @description 实例id
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @description 实例结果：
     * 实例状态为TERMINATED，必须设置代表含义，result取值agree和refuse均代表撤销审批流。
     * @var string
     */
    public $result;

    /**
     * @description 实例状态：
     * TERMINATED：终止审批流
     * @var string
     */
    public $status;
    protected $_name = [
        'notifiers'         => 'notifiers',
        'processInstanceId' => 'processInstanceId',
        'result'            => 'result',
        'status'            => 'status',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->notifiers) {
            $res['notifiers'] = [];
            if (null !== $this->notifiers && \is_array($this->notifiers)) {
                $n = 0;
                foreach ($this->notifiers as $item) {
                    $res['notifiers'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }
        if (null !== $this->result) {
            $res['result'] = $this->result;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return updateProcessInstanceRequests
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['notifiers'])) {
            if (!empty($map['notifiers'])) {
                $model->notifiers = [];
                $n                = 0;
                foreach ($map['notifiers'] as $item) {
                    $model->notifiers[$n++] = null !== $item ? notifiers::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }
        if (isset($map['result'])) {
            $model->result = $map['result'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
