<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetAgentIdByRelatedAppIdResponseBody extends Model
{
    /**
     * @description 微应用agentId。
     *
     * @var int
     */
    public $agentId;
    protected $_name = [
        'agentId' => 'agentId',
    ];

    public function validate()
    {
    }

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
     * @return GetAgentIdByRelatedAppIdResponseBody
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
