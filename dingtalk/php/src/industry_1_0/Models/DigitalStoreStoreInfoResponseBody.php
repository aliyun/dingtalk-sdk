<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class DigitalStoreStoreInfoResponseBody extends Model
{
    /**
     * @description 门店地址
     *
     * @var string
     */
    public $address;

    /**
     * @description 营业时间
     *
     * @var string
     */
    public $businessHours;

    /**
     * @description 纬度
     *
     * @var string
     */
    public $latitude;

    /**
     * @description 定位地址
     *
     * @var string
     */
    public $locationAddress;

    /**
     * @description 经度
     *
     * @var string
     */
    public $longitude;

    /**
     * @description 门店名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 上级节点id
     *
     * @var int
     */
    public $parentId;

    /**
     * @description 门店状态
     *
     * @var string
     */
    public $status;

    /**
     * @description 门店面积
     *
     * @var string
     */
    public $storeAcreage;

    /**
     * @description 门店带宽
     *
     * @var string
     */
    public $storeBandwidth;

    /**
     * @description 门店编号
     *
     * @var string
     */
    public $storeCode;

    /**
     * @description 门店Id
     *
     * @var int
     */
    public $storeId;

    /**
     * @description 门店电话
     *
     * @var string
     */
    public $telephone;
    protected $_name = [
        'address'         => 'address',
        'businessHours'   => 'businessHours',
        'latitude'        => 'latitude',
        'locationAddress' => 'locationAddress',
        'longitude'       => 'longitude',
        'name'            => 'name',
        'parentId'        => 'parentId',
        'status'          => 'status',
        'storeAcreage'    => 'storeAcreage',
        'storeBandwidth'  => 'storeBandwidth',
        'storeCode'       => 'storeCode',
        'storeId'         => 'storeId',
        'telephone'       => 'telephone',
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
        if (null !== $this->businessHours) {
            $res['businessHours'] = $this->businessHours;
        }
        if (null !== $this->latitude) {
            $res['latitude'] = $this->latitude;
        }
        if (null !== $this->locationAddress) {
            $res['locationAddress'] = $this->locationAddress;
        }
        if (null !== $this->longitude) {
            $res['longitude'] = $this->longitude;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->parentId) {
            $res['parentId'] = $this->parentId;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->storeAcreage) {
            $res['storeAcreage'] = $this->storeAcreage;
        }
        if (null !== $this->storeBandwidth) {
            $res['storeBandwidth'] = $this->storeBandwidth;
        }
        if (null !== $this->storeCode) {
            $res['storeCode'] = $this->storeCode;
        }
        if (null !== $this->storeId) {
            $res['storeId'] = $this->storeId;
        }
        if (null !== $this->telephone) {
            $res['telephone'] = $this->telephone;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DigitalStoreStoreInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['address'])) {
            $model->address = $map['address'];
        }
        if (isset($map['businessHours'])) {
            $model->businessHours = $map['businessHours'];
        }
        if (isset($map['latitude'])) {
            $model->latitude = $map['latitude'];
        }
        if (isset($map['locationAddress'])) {
            $model->locationAddress = $map['locationAddress'];
        }
        if (isset($map['longitude'])) {
            $model->longitude = $map['longitude'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['parentId'])) {
            $model->parentId = $map['parentId'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['storeAcreage'])) {
            $model->storeAcreage = $map['storeAcreage'];
        }
        if (isset($map['storeBandwidth'])) {
            $model->storeBandwidth = $map['storeBandwidth'];
        }
        if (isset($map['storeCode'])) {
            $model->storeCode = $map['storeCode'];
        }
        if (isset($map['storeId'])) {
            $model->storeId = $map['storeId'];
        }
        if (isset($map['telephone'])) {
            $model->telephone = $map['telephone'];
        }

        return $model;
    }
}
