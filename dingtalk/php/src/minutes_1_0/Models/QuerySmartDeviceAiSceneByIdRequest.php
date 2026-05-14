<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models;

use AlibabaCloud\Tea\Model;

class QuerySmartDeviceAiSceneByIdRequest extends Model
{
    /**
     * @var string
     */
    public $agentInstanceId;
    protected $_name = [
        'agentInstanceId' => 'agentInstanceId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentInstanceId) {
            $res['agentInstanceId'] = $this->agentInstanceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QuerySmartDeviceAiSceneByIdRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentInstanceId'])) {
            $model->agentInstanceId = $map['agentInstanceId'];
        }

        return $model;
    }
}
