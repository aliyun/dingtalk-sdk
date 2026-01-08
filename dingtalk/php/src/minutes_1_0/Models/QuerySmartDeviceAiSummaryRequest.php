<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models;

use AlibabaCloud\Tea\Model;

class QuerySmartDeviceAiSummaryRequest extends Model
{
    /**
     * @var string
     */
    public $agentId;

    /**
     * @var string
     */
    public $openFileId;
    protected $_name = [
        'agentId' => 'agentId',
        'openFileId' => 'openFileId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentId) {
            $res['agentId'] = $this->agentId;
        }
        if (null !== $this->openFileId) {
            $res['openFileId'] = $this->openFileId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QuerySmartDeviceAiSummaryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentId'])) {
            $model->agentId = $map['agentId'];
        }
        if (isset($map['openFileId'])) {
            $model->openFileId = $map['openFileId'];
        }

        return $model;
    }
}
