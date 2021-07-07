<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetMediaUrlRequest extends Model
{
    /**
     * @description 多媒体id
     *
     * @var string
     */
    public $mediaId;

    /**
     * @description 过期时间
     *
     * @var int
     */
    public $urlExpireTime;
    protected $_name = [
        'mediaId'       => 'mediaId',
        'urlExpireTime' => 'urlExpireTime',
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
        if (null !== $this->urlExpireTime) {
            $res['urlExpireTime'] = $this->urlExpireTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetMediaUrlRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['mediaId'])) {
            $model->mediaId = $map['mediaId'];
        }
        if (isset($map['urlExpireTime'])) {
            $model->urlExpireTime = $map['urlExpireTime'];
        }

        return $model;
    }
}
