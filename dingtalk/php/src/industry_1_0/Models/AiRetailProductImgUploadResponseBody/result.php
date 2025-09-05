<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\AiRetailProductImgUploadResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $ossFileId;

    /**
     * @var string
     */
    public $ossUploadUrl;
    protected $_name = [
        'ossFileId' => 'ossFileId',
        'ossUploadUrl' => 'ossUploadUrl',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->ossFileId) {
            $res['ossFileId'] = $this->ossFileId;
        }
        if (null !== $this->ossUploadUrl) {
            $res['ossUploadUrl'] = $this->ossUploadUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['ossFileId'])) {
            $model->ossFileId = $map['ossFileId'];
        }
        if (isset($map['ossUploadUrl'])) {
            $model->ossUploadUrl = $map['ossUploadUrl'];
        }

        return $model;
    }
}
