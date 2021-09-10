<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryCloudRecordVideoPlayInfoRequest extends Model
{
    /**
     * @description 用户id
     *
     * @var string
     */
    public $unionId;

    /**
     * @description 媒体文件id
     *
     * @var string
     */
    public $mediaId;

    /**
     * @description 集群id
     *
     * @var string
     */
    public $regionId;
    protected $_name = [
        'unionId'  => 'unionId',
        'mediaId'  => 'mediaId',
        'regionId' => 'regionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->mediaId) {
            $res['mediaId'] = $this->mediaId;
        }
        if (null !== $this->regionId) {
            $res['regionId'] = $this->regionId;
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
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['mediaId'])) {
            $model->mediaId = $map['mediaId'];
        }
        if (isset($map['regionId'])) {
            $model->regionId = $map['regionId'];
        }

        return $model;
    }
}
