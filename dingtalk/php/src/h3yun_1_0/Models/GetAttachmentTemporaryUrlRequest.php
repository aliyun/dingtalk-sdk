<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetAttachmentTemporaryUrlRequest extends Model
{
    /**
     * @description 附件id
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
