<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryAcrossCloudStroageConfigsRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $targetCloudType;

    /**
     * @description This parameter is required.
     *
     * @example ding77b8cac4e026cc123xxxxxxxxeb6378f
     *
     * @var string
     */
    public $targetCorpId;
    protected $_name = [
        'targetCloudType' => 'targetCloudType',
        'targetCorpId' => 'targetCorpId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->targetCloudType) {
            $res['targetCloudType'] = $this->targetCloudType;
        }
        if (null !== $this->targetCorpId) {
            $res['targetCorpId'] = $this->targetCorpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryAcrossCloudStroageConfigsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['targetCloudType'])) {
            $model->targetCloudType = $map['targetCloudType'];
        }
        if (isset($map['targetCorpId'])) {
            $model->targetCorpId = $map['targetCorpId'];
        }

        return $model;
    }
}
