<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatMemoQueryKnowledgeGraphNodeResponseBody;

use AlibabaCloud\Tea\Model;

class nodeInfo extends Model
{
    /**
     * @example xxxxxx
     *
     * @var string
     */
    public $mediaId;

    /**
     * @description This parameter is required.
     *
     * @example 人物
     *
     * @var string
     */
    public $nodeLabel;

    /**
     * @description This parameter is required.
     *
     * @example 刘备
     *
     * @var string
     */
    public $nodeName;

    /**
     * @example {"年龄"：43}
     *
     * @var string
     */
    public $propertiesString;
    protected $_name = [
        'mediaId' => 'mediaId',
        'nodeLabel' => 'nodeLabel',
        'nodeName' => 'nodeName',
        'propertiesString' => 'propertiesString',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->mediaId) {
            $res['mediaId'] = $this->mediaId;
        }
        if (null !== $this->nodeLabel) {
            $res['nodeLabel'] = $this->nodeLabel;
        }
        if (null !== $this->nodeName) {
            $res['nodeName'] = $this->nodeName;
        }
        if (null !== $this->propertiesString) {
            $res['propertiesString'] = $this->propertiesString;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return nodeInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['mediaId'])) {
            $model->mediaId = $map['mediaId'];
        }
        if (isset($map['nodeLabel'])) {
            $model->nodeLabel = $map['nodeLabel'];
        }
        if (isset($map['nodeName'])) {
            $model->nodeName = $map['nodeName'];
        }
        if (isset($map['propertiesString'])) {
            $model->propertiesString = $map['propertiesString'];
        }

        return $model;
    }
}
