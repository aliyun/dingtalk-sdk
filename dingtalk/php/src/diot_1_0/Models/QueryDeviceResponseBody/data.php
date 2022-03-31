<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\QueryDeviceResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\QueryDeviceResponseBody\data\liveUrls;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @description 设备id
     *
     * @var string
     */
    public $deviceId;

    /**
     * @description 设备昵称
     *
     * @var string
     */
    public $deviceName;

    /**
     * @description 设备状态 0:在线 1:离线
     *
     * @var int
     */
    public $deviceStatus;

    /**
     * @description 设备类型
     *
     * @var string
     */
    public $deviceType;

    /**
     * @description 设备类型名称
     *
     * @var string
     */
    public $deviceTypeName;

    /**
     * @description 直播地址
     *
     * @var liveUrls
     */
    public $liveUrls;

    /**
     * @description 设备地址
     *
     * @var string
     */
    public $location;

    /**
     * @description 设备父节点id
     *
     * @var string
     */
    public $parentId;

    /**
     * @description 产品类型 摄像头:CAMERA 其它:OTHERS
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
     * @return data
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
