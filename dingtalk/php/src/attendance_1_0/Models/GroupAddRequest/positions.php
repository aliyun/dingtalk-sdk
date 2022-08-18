<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupAddRequest;

use AlibabaCloud\Tea\Model;

class positions extends Model
{
    /**
     * @description 考勤地址。
     *
     * @var string
     */
    public $address;

    /**
     * @description 纬度。
     *
     * @var string
     */
    public $latitude;

    /**
     * @description 经度。
     *
     * @var string
     */
    public $longitude;

    /**
     * @description 考勤范围。
     *
     * @var int
     */
    public $offset;

    /**
     * @description 考勤标题。
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'address'   => 'address',
        'latitude'  => 'latitude',
        'longitude' => 'longitude',
        'offset'    => 'offset',
        'title'     => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->address) {
            $res['address'] = $this->address;
        }
        if (null !== $this->latitude) {
            $res['latitude'] = $this->latitude;
        }
        if (null !== $this->longitude) {
            $res['longitude'] = $this->longitude;
        }
        if (null !== $this->offset) {
            $res['offset'] = $this->offset;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return positions
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['address'])) {
            $model->address = $map['address'];
        }
        if (isset($map['latitude'])) {
            $model->latitude = $map['latitude'];
        }
        if (isset($map['longitude'])) {
            $model->longitude = $map['longitude'];
        }
        if (isset($map['offset'])) {
            $model->offset = $map['offset'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
