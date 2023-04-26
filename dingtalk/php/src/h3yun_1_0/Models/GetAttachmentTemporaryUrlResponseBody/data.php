<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\GetAttachmentTemporaryUrlResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @example http://h3yun-infrastructure.oss-cn-shenzhen.aliyuncs.com/mi4x54jcr54b0p8hwoad4wxo3/Formal/D000183te0qsxc20pulavqhgv8sky2p1/F0000041/21a42cb3-f679-4206-8314-597a59a7fd7a/01a27595-53ba-406f-8f39-cd31d99435d8?Expires=1641113859&OSSAccessKeyId=LTAI4G6TouCWDLHSHpAsM1eq&Signature=6FBbQbHMt7lrwi6wX1EsEo0Kr84%3D
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
