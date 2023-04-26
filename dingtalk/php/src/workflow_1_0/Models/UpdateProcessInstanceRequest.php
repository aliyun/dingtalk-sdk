<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\UpdateProcessInstanceRequest\notifiers;
use AlibabaCloud\Tea\Model;

class UpdateProcessInstanceRequest extends Model
{
    /**
     * @var notifiers[]
     */
    public $notifiers;

    /**
     * @example abc
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @example agree
     *
     * @var string
     */
    public $result;

    /**
     * @example COMPLETED
     *
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
     * @return UpdateProcessInstanceRequest
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
