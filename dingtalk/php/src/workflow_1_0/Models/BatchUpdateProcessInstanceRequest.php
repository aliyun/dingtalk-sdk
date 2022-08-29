<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\BatchUpdateProcessInstanceRequest\updateProcessInstanceRequests;
use AlibabaCloud\Tea\Model;

class BatchUpdateProcessInstanceRequest extends Model
{
    /**
     * @description 实列列表。
     *
     * @var updateProcessInstanceRequests[]
     */
    public $updateProcessInstanceRequests;
    protected $_name = [
        'updateProcessInstanceRequests' => 'updateProcessInstanceRequests',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->updateProcessInstanceRequests) {
            $res['updateProcessInstanceRequests'] = [];
            if (null !== $this->updateProcessInstanceRequests && \is_array($this->updateProcessInstanceRequests)) {
                $n = 0;
                foreach ($this->updateProcessInstanceRequests as $item) {
                    $res['updateProcessInstanceRequests'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchUpdateProcessInstanceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['updateProcessInstanceRequests'])) {
            if (!empty($map['updateProcessInstanceRequests'])) {
                $model->updateProcessInstanceRequests = [];
                $n                                    = 0;
                foreach ($map['updateProcessInstanceRequests'] as $item) {
                    $model->updateProcessInstanceRequests[$n++] = null !== $item ? updateProcessInstanceRequests::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
