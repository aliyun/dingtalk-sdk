<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models;

use AlibabaCloud\Tea\Model;

class QuerySignTaskRequest extends Model
{
    /**
     * @var string
     */
    public $bizFlowId;

    /**
     * @var string
     */
    public $requestId;

    /**
     * @var string
     */
    public $signFlowId;
    protected $_name = [
        'bizFlowId' => 'bizFlowId',
        'requestId' => 'requestId',
        'signFlowId' => 'signFlowId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizFlowId) {
            $res['bizFlowId'] = $this->bizFlowId;
        }
        if (null !== $this->requestId) {
            $res['requestId'] = $this->requestId;
        }
        if (null !== $this->signFlowId) {
            $res['signFlowId'] = $this->signFlowId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QuerySignTaskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizFlowId'])) {
            $model->bizFlowId = $map['bizFlowId'];
        }
        if (isset($map['requestId'])) {
            $model->requestId = $map['requestId'];
        }
        if (isset($map['signFlowId'])) {
            $model->signFlowId = $map['signFlowId'];
        }

        return $model;
    }
}
