<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models;

use AlibabaCloud\Tea\Model;

class UploadVideosShrinkRequest extends Model
{
    /**
     * @var string
     */
    public $videoListShrink;
    protected $_name = [
        'videoListShrink' => 'videoList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->videoListShrink) {
            $res['videoList'] = $this->videoListShrink;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UploadVideosShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['videoList'])) {
            $model->videoListShrink = $map['videoList'];
        }

        return $model;
    }
}
