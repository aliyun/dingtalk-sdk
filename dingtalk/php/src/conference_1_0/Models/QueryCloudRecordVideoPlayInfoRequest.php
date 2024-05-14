<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryCloudRecordVideoPlayInfoRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $mediaId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $regionId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'mediaId'  => 'mediaId',
        'regionId' => 'regionId',
        'unionId'  => 'unionId',
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
        if (null !== $this->regionId) {
            $res['regionId'] = $this->regionId;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryCloudRecordVideoPlayInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['mediaId'])) {
            $model->mediaId = $map['mediaId'];
        }
        if (isset($map['regionId'])) {
            $model->regionId = $map['regionId'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
