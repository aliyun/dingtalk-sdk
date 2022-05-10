<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryAcrossCloudStroageConfigsRequest extends Model
{
    /**
     * @description 云厂商类型
     *
     * @var int
     */
    public $targetCloudType;

    /**
     * @description 企业的corpId
     *
     * @var string
     */
    public $targetCorpId;
    protected $_name = [
        'targetCloudType' => 'targetCloudType',
        'targetCorpId'    => 'targetCorpId',
    ];

    public function validate()
    {
    }

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
