<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QuerySignTaskResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QuerySignTaskResponseBody\result\data\signTasks;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var string
     */
    public $bizFlowId;

    /**
     * @var string
     */
    public $signFlowId;

    /**
     * @var string
     */
    public $signFlowStatus;

    /**
     * @var signTasks[]
     */
    public $signTasks;
    protected $_name = [
        'bizFlowId' => 'bizFlowId',
        'signFlowId' => 'signFlowId',
        'signFlowStatus' => 'signFlowStatus',
        'signTasks' => 'signTasks',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizFlowId) {
            $res['bizFlowId'] = $this->bizFlowId;
        }
        if (null !== $this->signFlowId) {
            $res['signFlowId'] = $this->signFlowId;
        }
        if (null !== $this->signFlowStatus) {
            $res['signFlowStatus'] = $this->signFlowStatus;
        }
        if (null !== $this->signTasks) {
            $res['signTasks'] = [];
            if (null !== $this->signTasks && \is_array($this->signTasks)) {
                $n = 0;
                foreach ($this->signTasks as $item) {
                    $res['signTasks'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizFlowId'])) {
            $model->bizFlowId = $map['bizFlowId'];
        }
        if (isset($map['signFlowId'])) {
            $model->signFlowId = $map['signFlowId'];
        }
        if (isset($map['signFlowStatus'])) {
            $model->signFlowStatus = $map['signFlowStatus'];
        }
        if (isset($map['signTasks'])) {
            if (!empty($map['signTasks'])) {
                $model->signTasks = [];
                $n = 0;
                foreach ($map['signTasks'] as $item) {
                    $model->signTasks[$n++] = null !== $item ? signTasks::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
