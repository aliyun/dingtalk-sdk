<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateDataDeliverRequest extends Model
{
    /**
     * @var string
     */
    public $bizcode;

    /**
     * @var string
     */
    public $param;

    /**
     * @var string
     */
    public $userId;

    /**
     * @var string
     */
    public $dispatchingCycle;

    /**
     * @var string
     */
    public $dispatchingItemType;

    /**
     * @var int
     */
    public $dispatchingStartDate;
    protected $_name = [
        'bizcode' => 'bizcode',
        'param' => 'param',
        'userId' => 'userId',
        'dispatchingCycle' => 'dispatchingCycle',
        'dispatchingItemType' => 'dispatchingItemType',
        'dispatchingStartDate' => 'dispatchingStartDate',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizcode) {
            $res['bizcode'] = $this->bizcode;
        }
        if (null !== $this->param) {
            $res['param'] = $this->param;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->dispatchingCycle) {
            $res['dispatchingCycle'] = $this->dispatchingCycle;
        }
        if (null !== $this->dispatchingItemType) {
            $res['dispatchingItemType'] = $this->dispatchingItemType;
        }
        if (null !== $this->dispatchingStartDate) {
            $res['dispatchingStartDate'] = $this->dispatchingStartDate;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateDataDeliverRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizcode'])) {
            $model->bizcode = $map['bizcode'];
        }
        if (isset($map['param'])) {
            $model->param = $map['param'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['dispatchingCycle'])) {
            $model->dispatchingCycle = $map['dispatchingCycle'];
        }
        if (isset($map['dispatchingItemType'])) {
            $model->dispatchingItemType = $map['dispatchingItemType'];
        }
        if (isset($map['dispatchingStartDate'])) {
            $model->dispatchingStartDate = $map['dispatchingStartDate'];
        }

        return $model;
    }
}
