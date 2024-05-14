<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetAttachmentTemporaryUrlRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 006f870b-4d1c-4cd0-85b3-2e866798e947
     *
     * @var string
     */
    public $attachmentId;
    protected $_name = [
        'attachmentId' => 'attachmentId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->attachmentId) {
            $res['attachmentId'] = $this->attachmentId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetAttachmentTemporaryUrlRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attachmentId'])) {
            $model->attachmentId = $map['attachmentId'];
        }

        return $model;
    }
}
