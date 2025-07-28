<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetMediaUrlsRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $mediaIds;

    /**
     * @example 86399
     *
     * @var int
     */
    public $urlExpireTime;
    protected $_name = [
        'mediaIds' => 'mediaIds',
        'urlExpireTime' => 'urlExpireTime',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->mediaIds) {
            $res['mediaIds'] = $this->mediaIds;
        }
        if (null !== $this->urlExpireTime) {
            $res['urlExpireTime'] = $this->urlExpireTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetMediaUrlsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['mediaIds'])) {
            if (!empty($map['mediaIds'])) {
                $model->mediaIds = $map['mediaIds'];
            }
        }
        if (isset($map['urlExpireTime'])) {
            $model->urlExpireTime = $map['urlExpireTime'];
        }

        return $model;
    }
}
