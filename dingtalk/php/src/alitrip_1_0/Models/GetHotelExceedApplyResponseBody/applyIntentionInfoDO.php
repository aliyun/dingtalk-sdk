<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\GetHotelExceedApplyResponseBody;

use AlibabaCloud\Tea\Model;

class applyIntentionInfoDO extends Model
{
    /**
     * @description 入住日期
     *
     * @var string
     */
    public $checkIn;

    /**
     * @description 离店日期
     *
     * @var string
     */
    public $checkOut;

    /**
     * @description 入住城市三字码
     *
     * @var string
     */
    public $cityCode;

    /**
     * @description 入住城市名称
     *
     * @var string
     */
    public $cityName;

    /**
     * @description 意向酒店金额（分）
     *
     * @var int
     */
    public $price;

    /**
     * @description 是否合住
     *
     * @var bool
     */
    public $together;

    /**
     * @description 超标类型，32：金额超标
     *
     * @var int
     */
    public $type;
    protected $_name = [
        'checkIn'  => 'checkIn',
        'checkOut' => 'checkOut',
        'cityCode' => 'cityCode',
        'cityName' => 'cityName',
        'price'    => 'price',
        'together' => 'together',
        'type'     => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->checkIn) {
            $res['checkIn'] = $this->checkIn;
        }
        if (null !== $this->checkOut) {
            $res['checkOut'] = $this->checkOut;
        }
        if (null !== $this->cityCode) {
            $res['cityCode'] = $this->cityCode;
        }
        if (null !== $this->cityName) {
            $res['cityName'] = $this->cityName;
        }
        if (null !== $this->price) {
            $res['price'] = $this->price;
        }
        if (null !== $this->together) {
            $res['together'] = $this->together;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return applyIntentionInfoDO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['checkIn'])) {
            $model->checkIn = $map['checkIn'];
        }
        if (isset($map['checkOut'])) {
            $model->checkOut = $map['checkOut'];
        }
        if (isset($map['cityCode'])) {
            $model->cityCode = $map['cityCode'];
        }
        if (isset($map['cityName'])) {
            $model->cityName = $map['cityName'];
        }
        if (isset($map['price'])) {
            $model->price = $map['price'];
        }
        if (isset($map['together'])) {
            $model->together = $map['together'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
