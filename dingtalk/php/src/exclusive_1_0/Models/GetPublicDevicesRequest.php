<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetPublicDevicesRequest extends Model
{
    /**
     * @description 注册/申请时间止
     *
     * @var int
     */
    public $endTime;

    /**
     * @description 设备mac地址
     *
     * @var string
     */
    public $macAddress;

    /**
     * @description 页码
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description 单页条目数
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description 系统
     *
     * @var string
     */
    public $platform;

    /**
     * @description 注册/申请时间起
     *
     * @var int
     */
    public $startTime;

    /**
     * @description 设备标题
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'endTime'    => 'endTime',
        'macAddress' => 'macAddress',
        'pageNumber' => 'pageNumber',
        'pageSize'   => 'pageSize',
        'platform'   => 'platform',
        'startTime'  => 'startTime',
        'title'      => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
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
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
