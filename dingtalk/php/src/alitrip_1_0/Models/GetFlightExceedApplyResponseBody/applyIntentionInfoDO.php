<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\GetFlightExceedApplyResponseBody;

use AlibabaCloud\Tea\Model;

class applyIntentionInfoDO extends Model
{
    /**
     * @description 到达城市三字码
     *
     * @var string
     */
    public $arrCity;

    /**
     * @description 到达城市名称
     *
     * @var string
     */
    public $arrCityName;

    /**
     * @description 到达时间
     *
     * @var string
     */
    public $arrTime;

    /**
     * @description 超标的舱位，F：头等舱 C：商务舱 Y：经济舱 P：超值经济舱
     *
     * @var string
     */
    public $cabin;

    /**
     * @description 申请超标的舱等 0：头等舱 1：商务舱 2：经济舱 3：超值经济舱
     *
     * @var int
     */
    public $cabinClass;

    /**
     * @description 舱等描述，头等舱，商务舱，经济舱，超值经济舱
     *
     * @var string
     */
    public $cabinClassStr;

    /**
     * @description 出发城市三字码
     *
     * @var string
     */
    public $depCity;

    /**
     * @description 出发城市名称
     *
     * @var string
     */
    public $depCityName;

    /**
     * @description 出发时间
     *
     * @var string
     */
    public $depTime;

    /**
     * @description 折扣
     *
     * @var float
     */
    public $discount;

    /**
     * @description 航班号
     *
     * @var string
     */
    public $flightNo;

    /**
     * @description 意向航班价格（元）
     *
     * @var int
     */
    public $price;

    /**
     * @description 超标类型，1:折扣 2,8,10:时间 3,9,11:折扣和时间
     *
     * @var int
     */
    public $type;
    protected $_name = [
        'arrCity'       => 'arrCity',
        'arrCityName'   => 'arrCityName',
        'arrTime'       => 'arrTime',
        'cabin'         => 'cabin',
        'cabinClass'    => 'cabinClass',
        'cabinClassStr' => 'cabinClassStr',
        'depCity'       => 'depCity',
        'depCityName'   => 'depCityName',
        'depTime'       => 'depTime',
        'discount'      => 'discount',
        'flightNo'      => 'flightNo',
        'price'         => 'price',
        'type'          => 'type',
    ];

    public function validate()
    {
    }

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
