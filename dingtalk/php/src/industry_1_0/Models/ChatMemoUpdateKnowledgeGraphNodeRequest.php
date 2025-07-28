<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatMemoUpdateKnowledgeGraphNodeRequest\nodeInfo;
use AlibabaCloud\Tea\Model;

class ChatMemoUpdateKnowledgeGraphNodeRequest extends Model
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
     * @var nodeInfo
     */
    public $nodeInfo;
    protected $_name = [
        'bizId' => 'bizId',
        'datasetId' => 'datasetId',
        'nodeInfo' => 'nodeInfo',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->datasetId) {
            $res['datasetId'] = $this->datasetId;
        }
        if (null !== $this->nodeInfo) {
            $res['nodeInfo'] = null !== $this->nodeInfo ? $this->nodeInfo->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ChatMemoUpdateKnowledgeGraphNodeRequest
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
        if (isset($map['nodeInfo'])) {
            $model->nodeInfo = nodeInfo::fromMap($map['nodeInfo']);
        }

        return $model;
    }
}
