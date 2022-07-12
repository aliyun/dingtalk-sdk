<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListActivateDevicesRequest extends Model
{
    /**
     * @description 设备分类（0：设备，1 : 助手）
     *
     * @var int
     */
    public $deviceCategory;

    /**
     * @description deviceCode
     *
     * @var string
     */
    public $deviceCode;

    /**
     * @description deviceTypeId
     *
     * @var string
     */
    public $deviceTypeId;

    /**
     * @description groupId
     *
     * @var string
     */
    public $groupId;

    /**
     * @description pageNo
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description pageSize
     *
     * @var int
     */
    public $pageSize;
    protected $_name = [
        'deviceCategory' => 'deviceCategory',
        'deviceCode'     => 'deviceCode',
        'deviceTypeId'   => 'deviceTypeId',
        'groupId'        => 'groupId',
        'pageNumber'     => 'pageNumber',
        'pageSize'       => 'pageSize',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deviceCategory) {
            $res['deviceCategory'] = $this->deviceCategory;
        }
        if (null !== $this->deviceCode) {
            $res['deviceCode'] = $this->deviceCode;
        }
        if (null !== $this->deviceTypeId) {
            $res['deviceTypeId'] = $this->deviceTypeId;
        }
        if (null !== $this->groupId) {
            $res['groupId'] = $this->groupId;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
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
        if (isset($map['deviceCategory'])) {
            $model->deviceCategory = $map['deviceCategory'];
        }
        if (isset($map['deviceCode'])) {
            $model->deviceCode = $map['deviceCode'];
        }
        if (isset($map['deviceTypeId'])) {
            $model->deviceTypeId = $map['deviceTypeId'];
        }
        if (isset($map['groupId'])) {
            $model->groupId = $map['groupId'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }

        return $model;
    }
}
