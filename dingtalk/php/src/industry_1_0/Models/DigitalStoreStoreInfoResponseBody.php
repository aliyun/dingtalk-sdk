<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class DigitalStoreStoreInfoResponseBody extends Model
{
    /**
     * @example 余杭塘路xxxx号
     *
     * @var string
     */
    public $address;

    /**
     * @example 9:00-22:00
     *
     * @var string
     */
    public $businessHours;

    /**
     * @example 64266411
     *
     * @var int
     */
    public $dingDeptId;

    /**
     * @example 123
     *
     * @var string
     */
    public $latitude;

    /**
     * @example 余杭塘路xxxx号
     *
     * @var string
     */
    public $locationAddress;

    /**
     * @example 123
     *
     * @var string
     */
    public $longitude;

    /**
     * @example 华夏之心店
     *
     * @var string
     */
    public $name;

    /**
     * @example 873366531
     *
     * @var int
     */
    public $parentId;

    /**
     * @example CLOSED
     *
     * @var string
     */
    public $status;

    /**
     * @example 10平方米
     *
     * @var string
     */
    public $storeAcreage;

    /**
     * @example 1千兆
     *
     * @var string
     */
    public $storeBandwidth;

    /**
     * @example xxxxxxxxxxx
     *
     * @var string
     */
    public $storeCode;

    /**
     * @example 6756433
     *
     * @var int
     */
    public $storeId;

    /**
     * @example 0571-123456
     *
     * @var string
     */
    public $telephone;
    protected $_name = [
        'address'         => 'address',
        'businessHours'   => 'businessHours',
        'dingDeptId'      => 'dingDeptId',
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
        if (null !== $this->dingDeptId) {
            $res['dingDeptId'] = $this->dingDeptId;
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
        if (isset($map['dingDeptId'])) {
            $model->dingDeptId = $map['dingDeptId'];
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
