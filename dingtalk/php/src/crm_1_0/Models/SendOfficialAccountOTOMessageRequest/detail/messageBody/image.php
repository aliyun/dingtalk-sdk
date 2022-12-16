<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SendOfficialAccountOTOMessageRequest\detail\messageBody;

use AlibabaCloud\Tea\Model;

class image extends Model
{
    /**
     * @description 图片mediaId，可以通过上传媒体文件接口上传图片获取mediaId。
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
