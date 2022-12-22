<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\SendAgentOTOMessageRequest\detail\messageBody;

use AlibabaCloud\Tea\Model;

class image extends Model
{
    /**
     * @description 图片mediaId信息
     *
     * @var string
     */
    public $mediaId;
    protected $_name = [
        'mediaId' => 'mediaId',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return image
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['mediaId'])) {
            $model->mediaId = $map['mediaId'];
        }

        return $model;
    }
}
