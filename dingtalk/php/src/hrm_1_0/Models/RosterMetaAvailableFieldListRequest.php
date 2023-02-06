<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class RosterMetaAvailableFieldListRequest extends Model
{
    /**
     * @description 应用的agentId
     *
     * @var int
     */
    public $appAgentId;
    protected $_name = [
        'appAgentId' => 'appAgentId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appAgentId) {
            $res['appAgentId'] = $this->appAgentId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RosterMetaAvailableFieldListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appAgentId'])) {
            $model->appAgentId = $map['appAgentId'];
        }

        return $model;
    }
}
