<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetTrustDeviceListRequest extends Model
{
    /**
     * @example 1721718854814
     *
     * @var int
     */
    public $gmtCreateEnd;

    /**
     * @example 1721718854814
     *
     * @var int
     */
    public $gmtCreateStart;

    /**
     * @example 1721718854814
     *
     * @var int
     */
    public $gmtModifiedEnd;

    /**
     * @example 1721718854814
     *
     * @var int
     */
    public $gmtModifiedStart;

    /**
     * @example xx:xx:xx:xx:xx:xx
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
     * @example 500
     *
     * @var int
     */
    public $pageSize;

    /**
     * @example Android
     *
     * @var string
     */
    public $platform;

    /**
     * @var int
     */
    public $status;

    /**
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'gmtCreateEnd' => 'gmtCreateEnd',
        'gmtCreateStart' => 'gmtCreateStart',
        'gmtModifiedEnd' => 'gmtModifiedEnd',
        'gmtModifiedStart' => 'gmtModifiedStart',
        'macAddress' => 'macAddress',
        'pageNumber' => 'pageNumber',
        'pageSize' => 'pageSize',
        'platform' => 'platform',
        'status' => 'status',
        'userIds' => 'userIds',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->gmtCreateEnd) {
            $res['gmtCreateEnd'] = $this->gmtCreateEnd;
        }
        if (null !== $this->gmtCreateStart) {
            $res['gmtCreateStart'] = $this->gmtCreateStart;
        }
        if (null !== $this->gmtModifiedEnd) {
            $res['gmtModifiedEnd'] = $this->gmtModifiedEnd;
        }
        if (null !== $this->gmtModifiedStart) {
            $res['gmtModifiedStart'] = $this->gmtModifiedStart;
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
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetTrustDeviceListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['gmtCreateEnd'])) {
            $model->gmtCreateEnd = $map['gmtCreateEnd'];
        }
        if (isset($map['gmtCreateStart'])) {
            $model->gmtCreateStart = $map['gmtCreateStart'];
        }
        if (isset($map['gmtModifiedEnd'])) {
            $model->gmtModifiedEnd = $map['gmtModifiedEnd'];
        }
        if (isset($map['gmtModifiedStart'])) {
            $model->gmtModifiedStart = $map['gmtModifiedStart'];
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
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }

        return $model;
    }
}
