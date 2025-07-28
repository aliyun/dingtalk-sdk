<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GroupAddRequest;

use AlibabaCloud\Tea\Model;

class positions extends Model
{
    /**
     * @example 生物科技产业园区经二路21号
     *
     * @var string
     */
    public $address;

    /**
     * @example 36.687495
     *
     * @var string
     */
    public $latitude;

    /**
     * @example 101.750329
     *
     * @var string
     */
    public $longitude;

    /**
     * @example 500
     *
     * @var int
     */
    public $offset;

    /**
     * @example 青藏高原自然博物馆
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'address' => 'address',
        'latitude' => 'latitude',
        'longitude' => 'longitude',
        'offset' => 'offset',
        'title' => 'title',
    ];

    public function validate() {}

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
