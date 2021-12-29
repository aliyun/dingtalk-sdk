<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListActivateDevicesRequest extends Model
{
    /**
     * @description deviceTypeId
     *
     * @var string
     */
    public $deviceTypeId;

    /**
     * @description pageNo
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description groupId
     *
     * @var string
     */
    public $groupId;

    /**
     * @description pageSize
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description deviceCode
     *
     * @var string
     */
    public $deviceCode;
    protected $_name = [
        'deviceTypeId' => 'deviceTypeId',
        'pageNumber'   => 'pageNumber',
        'groupId'      => 'groupId',
        'pageSize'     => 'pageSize',
        'deviceCode'   => 'deviceCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deviceTypeId) {
            $res['deviceTypeId'] = $this->deviceTypeId;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->groupId) {
            $res['groupId'] = $this->groupId;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->deviceCode) {
            $res['deviceCode'] = $this->deviceCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListActivateDevicesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deviceTypeId'])) {
            $model->deviceTypeId = $map['deviceTypeId'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['groupId'])) {
            $model->groupId = $map['groupId'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['deviceCode'])) {
            $model->deviceCode = $map['deviceCode'];
        }

        return $model;
    }
}
