<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatMemoUpdateKnowledgeGraphRelationRequest\relationInfo;
use AlibabaCloud\Tea\Model;

class ChatMemoUpdateKnowledgeGraphRelationRequest extends Model
{
    /**
     * @example xxxxxx
     *
     * @var string
     */
    public $bizId;

    /**
     * @description This parameter is required.
     *
     * @example 111111
     *
     * @var int
     */
    public $datasetId;

    /**
     * @description This parameter is required.
     *
     * @var relationInfo
     */
    public $relationInfo;
    protected $_name = [
        'bizId'        => 'bizId',
        'datasetId'    => 'datasetId',
        'relationInfo' => 'relationInfo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->datasetId) {
            $res['datasetId'] = $this->datasetId;
        }
        if (null !== $this->relationInfo) {
            $res['relationInfo'] = null !== $this->relationInfo ? $this->relationInfo->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ChatMemoUpdateKnowledgeGraphRelationRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['datasetId'])) {
            $model->datasetId = $map['datasetId'];
        }
        if (isset($map['relationInfo'])) {
            $model->relationInfo = relationInfo::fromMap($map['relationInfo']);
        }

        return $model;
    }
}
