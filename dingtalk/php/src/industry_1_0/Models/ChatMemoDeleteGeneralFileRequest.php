<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class ChatMemoDeleteGeneralFileRequest extends Model
{
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
     * @example aaaa.doc
     *
     * @var string
     */
    public $mediaId;
    protected $_name = [
        'datasetId' => 'datasetId',
        'mediaId' => 'mediaId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->datasetId) {
            $res['datasetId'] = $this->datasetId;
        }
        if (null !== $this->mediaId) {
            $res['mediaId'] = $this->mediaId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ChatMemoDeleteGeneralFileRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['datasetId'])) {
            $model->datasetId = $map['datasetId'];
        }
        if (isset($map['mediaId'])) {
            $model->mediaId = $map['mediaId'];
        }

        return $model;
    }
}
