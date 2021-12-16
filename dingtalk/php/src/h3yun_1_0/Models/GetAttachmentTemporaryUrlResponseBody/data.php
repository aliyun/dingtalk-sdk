<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\GetAttachmentTemporaryUrlResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @description 附件临时免登地址。有效期为30分钟
     *
     * @var string
     */
    public $attachmentUrl;
    protected $_name = [
        'attachmentUrl' => 'attachmentUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->attachmentUrl) {
            $res['attachmentUrl'] = $this->attachmentUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attachmentUrl'])) {
            $model->attachmentUrl = $map['attachmentUrl'];
        }

        return $model;
    }
}
