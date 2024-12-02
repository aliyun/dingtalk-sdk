<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatMemoQueryKnowledgeGraphRelationResponseBody\relationInfo;
use AlibabaCloud\Tea\Model;

class ChatMemoQueryKnowledgeGraphRelationResponseBody extends Model
{
    /**
     * @example xxxxx
     *
     * @var string
     */
    public $bizId;

    /**
     * @description This parameter is required.
     *
     * @var relationInfo
     */
    public $relationInfo;
    protected $_name = [
        'bizId'        => 'bizId',
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
        if (null !== $this->relationInfo) {
            $res['relationInfo'] = null !== $this->relationInfo ? $this->relationInfo->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ChatMemoQueryKnowledgeGraphRelationResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['relationInfo'])) {
            $model->relationInfo = relationInfo::fromMap($map['relationInfo']);
        }

        return $model;
    }
}
