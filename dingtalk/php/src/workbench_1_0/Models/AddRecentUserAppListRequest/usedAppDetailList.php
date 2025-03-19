<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\AddRecentUserAppListRequest;

use AlibabaCloud\Tea\Model;

class usedAppDetailList extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 2636835622
     *
     * @var string
     */
    public $agentId;
    protected $_name = [
        'agentId' => 'agentId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentId) {
            $res['agentId'] = $this->agentId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return usedAppDetailList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentId'])) {
            $model->agentId = $map['agentId'];
        }

        return $model;
    }
}
