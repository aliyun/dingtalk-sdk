<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class AISaleAttachmentPermissonRequest extends Model
{
    /**
     * @var string
     */
    public $fileId;

    /**
     * @var string
     */
    public $spaceId;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'fileId' => 'fileId',
        'spaceId' => 'spaceId',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->fileId) {
            $res['fileId'] = $this->fileId;
        }
        if (null !== $this->spaceId) {
            $res['spaceId'] = $this->spaceId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AISaleAttachmentPermissonRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fileId'])) {
            $model->fileId = $map['fileId'];
        }
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
