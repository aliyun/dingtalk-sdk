<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetPublicDevicesRequest extends Model
{
    /**
     * @var string
     */
    public $deviceUuid;

    /**
     * @example 1671767361000
     *
     * @var int
     */
    public $endTime;

    /**
     * @example 88:66:5a:07:2b:04
     *
     * @var string
     */
    public $macAddress;

    /**
     * @example 1
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @example 100
     *
     * @var int
     */
    public $pageSize;

    /**
     * @example Mac
     *
     * @var string
     */
    public $platform;

    /**
     * @example 11-22-33-44
     *
     * @var string
     */
    public $serialNumber;

    /**
     * @example 1671767361000
     *
     * @var int
     */
    public $startTime;

    /**
     * @example 这是标题
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'deviceUuid' => 'deviceUuid',
        'endTime' => 'endTime',
        'macAddress' => 'macAddress',
        'pageNumber' => 'pageNumber',
        'pageSize' => 'pageSize',
        'platform' => 'platform',
        'serialNumber' => 'serialNumber',
        'startTime' => 'startTime',
        'title' => 'title',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->deviceUuid) {
            $res['deviceUuid'] = $this->deviceUuid;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->macAddress) {
            $res['macAddress'] = $this->macAddress;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->platform) {
            $res['platform'] = $this->platform;
        }
        if (null !== $this->serialNumber) {
            $res['serialNumber'] = $this->serialNumber;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetPublicDevicesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deviceUuid'])) {
            $model->deviceUuid = $map['deviceUuid'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['macAddress'])) {
            $model->macAddress = $map['macAddress'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['platform'])) {
            $model->platform = $map['platform'];
        }
        if (isset($map['serialNumber'])) {
            $model->serialNumber = $map['serialNumber'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
