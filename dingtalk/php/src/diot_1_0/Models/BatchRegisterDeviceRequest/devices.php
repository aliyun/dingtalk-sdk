<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\BatchRegisterDeviceRequest;

use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\BatchRegisterDeviceRequest\devices\liveUrls;
use AlibabaCloud\Tea\Model;

class devices extends Model
{
    /**
     * @example 002
     *
     * @var string
     */
    public $deviceId;

    /**
     * @example 摄像头002
     *
     * @var string
     */
    public $deviceName;

    /**
     * @example 0
     *
     * @var int
     */
    public $deviceStatus;

    /**
     * @example Camera
     *
     * @var string
     */
    public $deviceType;

    /**
     * @example 摄像头
     *
     * @var string
     */
    public $deviceTypeName;

    /**
     * @var mixed[]
     */
    public $extraData;

    /**
     * @var liveUrls
     */
    public $liveUrls;

    /**
     * @example 社区南门
     *
     * @var string
     */
    public $location;

    /**
     * @example 001
     *
     * @var string
     */
    public $parentId;

    /**
     * @example CAMERA
     *
     * @var string
     */
    public $productType;
    protected $_name = [
        'deviceId'       => 'deviceId',
        'deviceName'     => 'deviceName',
        'deviceStatus'   => 'deviceStatus',
        'deviceType'     => 'deviceType',
        'deviceTypeName' => 'deviceTypeName',
        'extraData'      => 'extraData',
        'liveUrls'       => 'liveUrls',
        'location'       => 'location',
        'parentId'       => 'parentId',
        'productType'    => 'productType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deviceId) {
            $res['deviceId'] = $this->deviceId;
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
        if (null !== $this->extraData) {
            $res['extraData'] = $this->extraData;
        }
        if (null !== $this->liveUrls) {
            $res['liveUrls'] = null !== $this->liveUrls ? $this->liveUrls->toMap() : null;
        }
        if (null !== $this->location) {
            $res['location'] = $this->location;
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
     * @return devices
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deviceId'])) {
            $model->deviceId = $map['deviceId'];
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
        if (isset($map['extraData'])) {
            $model->extraData = $map['extraData'];
        }
        if (isset($map['liveUrls'])) {
            $model->liveUrls = liveUrls::fromMap($map['liveUrls']);
        }
        if (isset($map['location'])) {
            $model->location = $map['location'];
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
