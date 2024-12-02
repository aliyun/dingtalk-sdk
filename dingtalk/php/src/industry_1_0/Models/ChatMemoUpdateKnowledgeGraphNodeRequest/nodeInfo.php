<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatMemoUpdateKnowledgeGraphNodeRequest;

use AlibabaCloud\Tea\Model;

class nodeInfo extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example xxxxxxx
     *
     * @var string
     */
    public $mediaId;

    /**
     * @example {"年龄"：43}
     *
     * @var string
     */
    public $propertiesString;
    protected $_name = [
        'mediaId'          => 'mediaId',
        'propertiesString' => 'propertiesString',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->mediaId) {
            $res['mediaId'] = $this->mediaId;
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
        if (isset($map['propertiesString'])) {
            $model->propertiesString = $map['propertiesString'];
        }

        return $model;
    }
}
