<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateResidentInfoRequest extends Model
{
    /**
     * @var string
     */
    public $address;

    /**
     * @description 建筑面积，组多支持2位小数，总长不超过8位
     *
     * @var float
     */
    public $buildingArea;

    /**
     * @description 市的名字，有值时provName必填
     *
     * @var string
     */
    public $cityName;

    /**
     * @description 1纯住宅；2:商住混合；3:办公；4:办公商业混合；5:商业；6:公共场所；7:其他
     *
     * @var int
     */
    public $communityType;

    /**
     * @description 区/县名，有值是provName，cityName必填
     *
     * @var string
     */
    public $countyName;

    /**
     * @description 经纬度，格式：经度,纬度
     *
     * @var string
     */
    public $location;

    /**
     * @description 小区名
     *
     * @var string
     */
    public $name;

    /**
     * @description 省的名字
     *
     * @var string
     */
    public $provName;

    /**
     * @description 小区状态：0正常/1关闭/2作废
     *
     * @var int
     */
    public $state;

    /**
     * @description 小区服务电话
     *
     * @var string
     */
    public $telephone;
    protected $_name = [
        'address'       => 'address',
        'buildingArea'  => 'buildingArea',
        'cityName'      => 'cityName',
        'communityType' => 'communityType',
        'countyName'    => 'countyName',
        'location'      => 'location',
        'name'          => 'name',
        'provName'      => 'provName',
        'state'         => 'state',
        'telephone'     => 'telephone',
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
        if (null !== $this->buildingArea) {
            $res['buildingArea'] = $this->buildingArea;
        }
        if (null !== $this->cityName) {
            $res['cityName'] = $this->cityName;
        }
        if (null !== $this->communityType) {
            $res['communityType'] = $this->communityType;
        }
        if (null !== $this->countyName) {
            $res['countyName'] = $this->countyName;
        }
        if (null !== $this->location) {
            $res['location'] = $this->location;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->provName) {
            $res['provName'] = $this->provName;
        }
        if (null !== $this->state) {
            $res['state'] = $this->state;
        }
        if (null !== $this->telephone) {
            $res['telephone'] = $this->telephone;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateResidentInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['address'])) {
            $model->address = $map['address'];
        }
        if (isset($map['buildingArea'])) {
            $model->buildingArea = $map['buildingArea'];
        }
        if (isset($map['cityName'])) {
            $model->cityName = $map['cityName'];
        }
        if (isset($map['communityType'])) {
            $model->communityType = $map['communityType'];
        }
        if (isset($map['countyName'])) {
            $model->countyName = $map['countyName'];
        }
        if (isset($map['location'])) {
            $model->location = $map['location'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['provName'])) {
            $model->provName = $map['provName'];
        }
        if (isset($map['state'])) {
            $model->state = $map['state'];
        }
        if (isset($map['telephone'])) {
            $model->telephone = $map['telephone'];
        }

        return $model;
    }
}
