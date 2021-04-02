<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\QueryCityCarApplyResponseBody\applyList;

use AlibabaCloud\Tea\Model;

class itineraryList extends Model
{
    /**
     * @description 目的地城市
     *
     * @var string
     */
    public $arrCity;

    /**
     * @description 目的地城市三字码
     *
     * @var string
     */
    public $arrCityCode;

    /**
     * @description 到达目的地城市时间
     *
     * @var string
     */
    public $arrDate;

    /**
     * @description 商旅内部成本中心ID
     *
     * @var int
     */
    public $costCenterId;

    /**
     * @description 成本中心名称
     *
     * @var string
     */
    public $costCenterName;

    /**
     * @description 出发城市
     *
     * @var string
     */
    public $depCity;

    /**
     * @description 出发城市三字码
     *
     * @var string
     */
    public $depCityCode;

    /**
     * @description 出发时间
     *
     * @var string
     */
    public $depDate;

    /**
     * @description 商旅内部发票抬头ID
     *
     * @var int
     */
    public $invoiceId;

    /**
     * @description 发票抬头名称
     *
     * @var string
     */
    public $invoiceName;

    /**
     * @description 商旅内部行程单ID
     *
     * @var string
     */
    public $itineraryId;

    /**
     * @description 项目code
     *
     * @var string
     */
    public $projectCode;

    /**
     * @description 项目名称
     *
     * @var string
     */
    public $projectTitle;

    /**
     * @description 交通方式：4-市内交通
     *
     * @var int
     */
    public $trafficType;
    protected $_name = [
        'arrCity'        => 'arrCity',
        'arrCityCode'    => 'arrCityCode',
        'arrDate'        => 'arrDate',
        'costCenterId'   => 'costCenterId',
        'costCenterName' => 'costCenterName',
        'depCity'        => 'depCity',
        'depCityCode'    => 'depCityCode',
        'depDate'        => 'depDate',
        'invoiceId'      => 'invoiceId',
        'invoiceName'    => 'invoiceName',
        'itineraryId'    => 'itineraryId',
        'projectCode'    => 'projectCode',
        'projectTitle'   => 'projectTitle',
        'trafficType'    => 'trafficType',
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
        if (null !== $this->arrCityCode) {
            $res['arrCityCode'] = $this->arrCityCode;
        }
        if (null !== $this->arrDate) {
            $res['arrDate'] = $this->arrDate;
        }
        if (null !== $this->costCenterId) {
            $res['costCenterId'] = $this->costCenterId;
        }
        if (null !== $this->costCenterName) {
            $res['costCenterName'] = $this->costCenterName;
        }
        if (null !== $this->depCity) {
            $res['depCity'] = $this->depCity;
        }
        if (null !== $this->depCityCode) {
            $res['depCityCode'] = $this->depCityCode;
        }
        if (null !== $this->depDate) {
            $res['depDate'] = $this->depDate;
        }
        if (null !== $this->invoiceId) {
            $res['invoiceId'] = $this->invoiceId;
        }
        if (null !== $this->invoiceName) {
            $res['invoiceName'] = $this->invoiceName;
        }
        if (null !== $this->itineraryId) {
            $res['itineraryId'] = $this->itineraryId;
        }
        if (null !== $this->projectCode) {
            $res['projectCode'] = $this->projectCode;
        }
        if (null !== $this->projectTitle) {
            $res['projectTitle'] = $this->projectTitle;
        }
        if (null !== $this->trafficType) {
            $res['trafficType'] = $this->trafficType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return itineraryList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['arrCity'])) {
            $model->arrCity = $map['arrCity'];
        }
        if (isset($map['arrCityCode'])) {
            $model->arrCityCode = $map['arrCityCode'];
        }
        if (isset($map['arrDate'])) {
            $model->arrDate = $map['arrDate'];
        }
        if (isset($map['costCenterId'])) {
            $model->costCenterId = $map['costCenterId'];
        }
        if (isset($map['costCenterName'])) {
            $model->costCenterName = $map['costCenterName'];
        }
        if (isset($map['depCity'])) {
            $model->depCity = $map['depCity'];
        }
        if (isset($map['depCityCode'])) {
            $model->depCityCode = $map['depCityCode'];
        }
        if (isset($map['depDate'])) {
            $model->depDate = $map['depDate'];
        }
        if (isset($map['invoiceId'])) {
            $model->invoiceId = $map['invoiceId'];
        }
        if (isset($map['invoiceName'])) {
            $model->invoiceName = $map['invoiceName'];
        }
        if (isset($map['itineraryId'])) {
            $model->itineraryId = $map['itineraryId'];
        }
        if (isset($map['projectCode'])) {
            $model->projectCode = $map['projectCode'];
        }
        if (isset($map['projectTitle'])) {
            $model->projectTitle = $map['projectTitle'];
        }
        if (isset($map['trafficType'])) {
            $model->trafficType = $map['trafficType'];
        }

        return $model;
    }
}
