<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ShareUrlResponseBody\shareUrlInfo;
use AlibabaCloud\Tea\Model;

class ShareUrlResponseBody extends Model
{
    /**
     * @example shareUrlInfo
     *
     * @var shareUrlInfo
     */
    public $shareUrlInfo;
    protected $_name = [
        'shareUrlInfo' => 'shareUrlInfo',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->shareUrlInfo) {
            $res['shareUrlInfo'] = null !== $this->shareUrlInfo ? $this->shareUrlInfo->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ShareUrlResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['shareUrlInfo'])) {
            $model->shareUrlInfo = shareUrlInfo::fromMap($map['shareUrlInfo']);
        }

        return $model;
    }
}
