<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\CreateMeetingRoomRequest;

use AlibabaCloud\Tea\Model;

class roomLocation extends Model
{
    /**
     * @description 位置详细信息
     *
     * @var string
     */
    public $desc;

    /**
     * @description 纬度
     *
     * @var string
     */
    public $latitude;

    /**
     * @description 经度
     *
     * @var string
     */
    public $longitude;

    /**
     * @description 位置标题
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'desc'      => 'desc',
        'latitude'  => 'latitude',
        'longitude' => 'longitude',
        'title'     => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->desc) {
            $res['desc'] = $this->desc;
        }
        if (null !== $this->latitude) {
            $res['latitude'] = $this->latitude;
        }
        if (null !== $this->longitude) {
            $res['longitude'] = $this->longitude;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return roomLocation
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['desc'])) {
            $model->desc = $map['desc'];
        }
        if (isset($map['latitude'])) {
            $model->latitude = $map['latitude'];
        }
        if (isset($map['longitude'])) {
            $model->longitude = $map['longitude'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
