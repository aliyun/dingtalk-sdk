<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models;

use AlibabaCloud\Tea\Model;

class ExtractFacialFeatureRequest extends Model
{
    /**
     * @var string
     */
    public $userid;

    /**
     * @var string
     */
    public $mediaId;
    protected $_name = [
        'userid'  => 'userid',
        'mediaId' => 'mediaId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->userid) {
            $res['userid'] = $this->userid;
        }
        if (null !== $this->mediaId) {
            $res['mediaId'] = $this->mediaId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ExtractFacialFeatureRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['userid'])) {
            $model->userid = $map['userid'];
        }
        if (isset($map['mediaId'])) {
            $model->mediaId = $map['mediaId'];
        }

        return $model;
    }
}
