<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\GetFlightExceedApplyResponseBody;

use AlibabaCloud\Tea\Model;

class applyIntentionInfoDO extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example HGH
     *
     * @var string
     */
    public $arrCity;

    /**
     * @description This parameter is required.
     *
     * @example 杭州
     *
     * @var string
     */
    public $arrCityName;

    /**
     * @description This parameter is required.
     *
     * @example 2021-07-08 15:23:56
     *
     * @var string
     */
    public $arrTime;

    /**
     * @description This parameter is required.
     *
     * @example F
     *
     * @var string
     */
    public $cabin;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $cabinClass;

    /**
     * @description This parameter is required.
     *
     * @example 经济舱
     *
     * @var string
     */
    public $cabinClassStr;

    /**
     * @description This parameter is required.
     *
     * @example SHA
     *
     * @var string
     */
    public $depCity;

    /**
     * @description This parameter is required.
     *
     * @example 上海
     *
     * @var string
     */
    public $depCityName;

    /**
     * @description This parameter is required.
     *
     * @example 2021-07-08 15:23:56
     *
     * @var string
     */
    public $depTime;

    /**
     * @description This parameter is required.
     *
     * @example 4.1
     *
     * @var float
     */
    public $discount;

    /**
     * @description This parameter is required.
     *
     * @example MU2759
     *
     * @var string
     */
    public $flightNo;

    /**
     * @description This parameter is required.
     *
     * @example 1000
     *
     * @var int
     */
    public $price;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $type;
    protected $_name = [
        'arrCity' => 'arrCity',
        'arrCityName' => 'arrCityName',
        'arrTime' => 'arrTime',
        'cabin' => 'cabin',
        'cabinClass' => 'cabinClass',
        'cabinClassStr' => 'cabinClassStr',
        'depCity' => 'depCity',
        'depCityName' => 'depCityName',
        'depTime' => 'depTime',
        'discount' => 'discount',
        'flightNo' => 'flightNo',
        'price' => 'price',
        'type' => 'type',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->arrCity) {
            $res['arrCity'] = $this->arrCity;
        }
        if (null !== $this->arrCityName) {
            $res['arrCityName'] = $this->arrCityName;
        }
        if (null !== $this->arrTime) {
            $res['arrTime'] = $this->arrTime;
        }
        if (null !== $this->cabin) {
            $res['cabin'] = $this->cabin;
        }
        if (null !== $this->cabinClass) {
            $res['cabinClass'] = $this->cabinClass;
        }
        if (null !== $this->cabinClassStr) {
            $res['cabinClassStr'] = $this->cabinClassStr;
        }
        if (null !== $this->depCity) {
            $res['depCity'] = $this->depCity;
        }
        if (null !== $this->depCityName) {
            $res['depCityName'] = $this->depCityName;
        }
        if (null !== $this->depTime) {
            $res['depTime'] = $this->depTime;
        }
        if (null !== $this->discount) {
            $res['discount'] = $this->discount;
        }
        if (null !== $this->flightNo) {
            $res['flightNo'] = $this->flightNo;
        }
        if (null !== $this->price) {
            $res['price'] = $this->price;
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
        if (isset($map['arrCity'])) {
            $model->arrCity = $map['arrCity'];
        }
        if (isset($map['arrCityName'])) {
            $model->arrCityName = $map['arrCityName'];
        }
        if (isset($map['arrTime'])) {
            $model->arrTime = $map['arrTime'];
        }
        if (isset($map['cabin'])) {
            $model->cabin = $map['cabin'];
        }
        if (isset($map['cabinClass'])) {
            $model->cabinClass = $map['cabinClass'];
        }
        if (isset($map['cabinClassStr'])) {
            $model->cabinClassStr = $map['cabinClassStr'];
        }
        if (isset($map['depCity'])) {
            $model->depCity = $map['depCity'];
        }
        if (isset($map['depCityName'])) {
            $model->depCityName = $map['depCityName'];
        }
        if (isset($map['depTime'])) {
            $model->depTime = $map['depTime'];
        }
        if (isset($map['discount'])) {
            $model->discount = $map['discount'];
        }
        if (isset($map['flightNo'])) {
            $model->flightNo = $map['flightNo'];
        }
        if (isset($map['price'])) {
            $model->price = $map['price'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
