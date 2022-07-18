<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class DigitalStoreRightsInfoResponseBody extends Model
{
    /**
     * @description 权益过期时间
     *
     * @var int
     */
    public $endTime;

    /**
     * @description 门店通通讯录根节点Id
     *
     * @var int
     */
    public $quantity;

    /**
     * @description 门店通通讯录名称
     *
     * @var string
     */
    public $rightsCode;

    /**
     * @description 门店通通讯录Code
     *
     * @var string
     */
    public $rightsName;

    /**
     * @description 权益开始时间
     *
     * @var int
     */
    public $startTime;
    protected $_name = [
        'endTime'    => 'endTime',
        'quantity'   => 'quantity',
        'rightsCode' => 'rightsCode',
        'rightsName' => 'rightsName',
        'startTime'  => 'startTime',
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
        if (null !== $this->quantity) {
            $res['quantity'] = $this->quantity;
        }
        if (null !== $this->rightsCode) {
            $res['rightsCode'] = $this->rightsCode;
        }
        if (null !== $this->rightsName) {
            $res['rightsName'] = $this->rightsName;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DigitalStoreRightsInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['quantity'])) {
            $model->quantity = $map['quantity'];
        }
        if (isset($map['rightsCode'])) {
            $model->rightsCode = $map['rightsCode'];
        }
        if (isset($map['rightsName'])) {
            $model->rightsName = $map['rightsName'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }

        return $model;
    }
}
