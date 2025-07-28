<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetFlowIdByRelationEntityIdResponseBody extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example xxx
     *
     * @var string
     */
    public $flowId;
    protected $_name = [
        'flowId' => 'flowId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->flowId) {
            $res['flowId'] = $this->flowId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetFlowIdByRelationEntityIdResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['flowId'])) {
            $model->flowId = $map['flowId'];
        }

        return $model;
    }
}
