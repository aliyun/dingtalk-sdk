<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QuerySmartDeviceAiSceneByIdResponseBody\agent;
use AlibabaCloud\Tea\Model;

class QuerySmartDeviceAiSceneByIdResponseBody extends Model
{
    /**
     * @var agent
     */
    public $agent;
    protected $_name = [
        'agent' => 'agent',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->agent) {
            $res['agent'] = null !== $this->agent ? $this->agent->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QuerySmartDeviceAiSceneByIdResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agent'])) {
            $model->agent = agent::fromMap($map['agent']);
        }

        return $model;
    }
}
