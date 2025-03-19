<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatMemoQueryKnowledgeGraphNodeResponseBody\nodeInfo;
use AlibabaCloud\Tea\Model;

class ChatMemoQueryKnowledgeGraphNodeResponseBody extends Model
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
     * @var nodeInfo
     */
    public $nodeInfo;
    protected $_name = [
        'bizId' => 'bizId',
        'nodeInfo' => 'nodeInfo',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->nodeInfo) {
            $res['nodeInfo'] = null !== $this->nodeInfo ? $this->nodeInfo->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ChatMemoQueryKnowledgeGraphNodeResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['nodeInfo'])) {
            $model->nodeInfo = nodeInfo::fromMap($map['nodeInfo']);
        }

        return $model;
    }
}
