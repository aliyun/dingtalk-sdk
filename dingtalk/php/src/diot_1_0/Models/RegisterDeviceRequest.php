<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\RegisterDeviceRequest\liveUrls;
use AlibabaCloud\Tea\Model;

class RegisterDeviceRequest extends Model
{
    /**
     * @example ding123
     *
     * @var string
     */
    public $corpId;

    /**
     * @description This parameter is required.
     *
     * @example 摄像头1
     *
     * @var string
     */
    public $deviceName;

    /**
     * @description This parameter is required.
     *
     * @example 0
     *
     * @var int
     */
    public $deviceStatus;

    /**
     * @description This parameter is required.
     *
     * @example Camera
     *
     * @var string
     */
    public $deviceType;

    /**
     * @description This parameter is required.
     *
     * @example 摄像头
     *
     * @var string
     */
    public $deviceTypeName;

    /**
     * @description This parameter is required.
     *
     * @example 002
     *
     * @var string
     */
    public $id;

    /**
     * @var liveUrls
     */
    public $liveUrls;

    /**
     * @example 东南门
     *
     * @var string
     */
    public $location;

    /**
     * @example 摄像头1
     *
     * @var string
     */
    public $nickName;

    /**
     * @example 001
     *
     * @var string
     */
    public $parentId;

    /**
     * @description This parameter is required.
     *
     * @example CAMERA
     *
     * @var string
     */
    public $productType;
    protected $_name = [
        'corpId'         => 'corpId',
        'deviceName'     => 'deviceName',
        'deviceStatus'   => 'deviceStatus',
        'deviceType'     => 'deviceType',
        'deviceTypeName' => 'deviceTypeName',
        'id'             => 'id',
        'liveUrls'       => 'liveUrls',
        'location'       => 'location',
        'nickName'       => 'nickName',
        'parentId'       => 'parentId',
        'productType'    => 'productType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->deviceName) {
            $res['deviceName'] = $this->deviceName;
        }
        if (null !== $this->deviceStatus) {
            $res['deviceStatus'] = $this->deviceStatus;
        }
        if (null !== $this->deviceType) {
            $res['deviceType'] = $this->deviceType;
        }
        if (null !== $this->deviceTypeName) {
            $res['deviceTypeName'] = $this->deviceTypeName;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->liveUrls) {
            $res['liveUrls'] = null !== $this->liveUrls ? $this->liveUrls->toMap() : null;
        }
        if (null !== $this->location) {
            $res['location'] = $this->location;
        }
        if (null !== $this->nickName) {
            $res['nickName'] = $this->nickName;
        }
        if (null !== $this->parentId) {
            $res['parentId'] = $this->parentId;
        }
        if (null !== $this->productType) {
            $res['productType'] = $this->productType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RegisterDeviceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['deviceName'])) {
            $model->deviceName = $map['deviceName'];
        }
        if (isset($map['deviceStatus'])) {
            $model->deviceStatus = $map['deviceStatus'];
        }
        if (isset($map['deviceType'])) {
            $model->deviceType = $map['deviceType'];
        }
        if (isset($map['deviceTypeName'])) {
            $model->deviceTypeName = $map['deviceTypeName'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['liveUrls'])) {
            $model->liveUrls = liveUrls::fromMap($map['liveUrls']);
        }
        if (isset($map['location'])) {
            $model->location = $map['location'];
        }
        if (isset($map['nickName'])) {
            $model->nickName = $map['nickName'];
        }
        if (isset($map['parentId'])) {
            $model->parentId = $map['parentId'];
        }
        if (isset($map['productType'])) {
            $model->productType = $map['productType'];
        }

        return $model;
    }
}
