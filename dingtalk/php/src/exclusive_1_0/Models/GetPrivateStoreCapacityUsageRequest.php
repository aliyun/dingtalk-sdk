<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetPrivateStoreCapacityUsageRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example ding1234
     *
     * @var string
     */
    public $targetCorpId;
    protected $_name = [
        'targetCorpId' => 'targetCorpId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->targetCorpId) {
            $res['targetCorpId'] = $this->targetCorpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetPrivateStoreCapacityUsageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['targetCorpId'])) {
            $model->targetCorpId = $map['targetCorpId'];
        }

        return $model;
    }
}
