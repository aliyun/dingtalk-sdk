<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\GetTrainExceedApplyResponseBody;

use AlibabaCloud\Tea\Model;

class applyIntentionInfoDO extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example BJS
     *
     * @var string
     */
    public $arrCity;

    /**
     * @description This parameter is required.
     *
     * @example 北京
     *
     * @var string
     */
    public $arrCityName;

    /**
     * @description This parameter is required.
     *
     * @example 上海南
     *
     * @var string
     */
    public $arrStation;

    /**
     * @description This parameter is required.
     *
     * @example 2021-07-13 15:06:13
     *
     * @var string
     */
    public $arrTime;

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
     * @example 北京南
     *
     * @var string
     */
    public $depStation;

    /**
     * @description This parameter is required.
     *
     * @example 2021-07-13 15:06:13
     *
     * @var string
     */
    public $depTime;

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
     * @example 一等座
     *
     * @var string
     */
    public $seatName;

    /**
     * @description This parameter is required.
     *
     * @example G39
     *
     * @var string
     */
    public $trainNo;

    /**
     * @description This parameter is required.
     *
     * @example 高铁
     *
     * @var string
     */
    public $trainTypeDesc;
    protected $_name = [
        'arrCity' => 'arrCity',
        'arrCityName' => 'arrCityName',
        'arrStation' => 'arrStation',
        'arrTime' => 'arrTime',
        'depCity' => 'depCity',
        'depCityName' => 'depCityName',
        'depStation' => 'depStation',
        'depTime' => 'depTime',
        'price' => 'price',
        'seatName' => 'seatName',
        'trainNo' => 'trainNo',
        'trainTypeDesc' => 'trainTypeDesc',
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
        if (null !== $this->arrStation) {
            $res['arrStation'] = $this->arrStation;
        }
        if (null !== $this->arrTime) {
            $res['arrTime'] = $this->arrTime;
        }
        if (null !== $this->depCity) {
            $res['depCity'] = $this->depCity;
        }
        if (null !== $this->depCityName) {
            $res['depCityName'] = $this->depCityName;
        }
        if (null !== $this->depStation) {
            $res['depStation'] = $this->depStation;
        }
        if (null !== $this->depTime) {
            $res['depTime'] = $this->depTime;
        }
        if (null !== $this->price) {
            $res['price'] = $this->price;
        }
        if (null !== $this->seatName) {
            $res['seatName'] = $this->seatName;
        }
        if (null !== $this->trainNo) {
            $res['trainNo'] = $this->trainNo;
        }
        if (null !== $this->trainTypeDesc) {
            $res['trainTypeDesc'] = $this->trainTypeDesc;
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
        if (isset($map['arrStation'])) {
            $model->arrStation = $map['arrStation'];
        }
        if (isset($map['arrTime'])) {
            $model->arrTime = $map['arrTime'];
        }
        if (isset($map['depCity'])) {
            $model->depCity = $map['depCity'];
        }
        if (isset($map['depCityName'])) {
            $model->depCityName = $map['depCityName'];
        }
        if (isset($map['depStation'])) {
            $model->depStation = $map['depStation'];
        }
        if (isset($map['depTime'])) {
            $model->depTime = $map['depTime'];
        }
        if (isset($map['price'])) {
            $model->price = $map['price'];
        }
        if (isset($map['seatName'])) {
            $model->seatName = $map['seatName'];
        }
        if (isset($map['trainNo'])) {
            $model->trainNo = $map['trainNo'];
        }
        if (isset($map['trainTypeDesc'])) {
            $model->trainTypeDesc = $map['trainTypeDesc'];
        }

        return $model;
    }
}
