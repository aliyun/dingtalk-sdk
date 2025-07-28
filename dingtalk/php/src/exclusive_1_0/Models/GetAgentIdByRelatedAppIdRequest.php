<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetAgentIdByRelatedAppIdRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 10000
     *
     * @var int
     */
    public $appId;

    /**
     * @description This parameter is required.
     *
     * @example ding24f2f5ccxxxxxxxx
     *
     * @var string
     */
    public $targetCorpId;
    protected $_name = [
        'appId' => 'appId',
        'targetCorpId' => 'targetCorpId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->appId) {
            $res['appId'] = $this->appId;
        }
        if (null !== $this->targetCorpId) {
            $res['targetCorpId'] = $this->targetCorpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetAgentIdByRelatedAppIdRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appId'])) {
            $model->appId = $map['appId'];
        }
        if (isset($map['targetCorpId'])) {
            $model->targetCorpId = $map['targetCorpId'];
        }

        return $model;
    }
}
