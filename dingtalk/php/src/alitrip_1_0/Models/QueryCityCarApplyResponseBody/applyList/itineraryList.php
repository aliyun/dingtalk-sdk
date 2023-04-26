<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\QueryCityCarApplyResponseBody\applyList;

use AlibabaCloud\Tea\Model;

class itineraryList extends Model
{
    /**
     * @example 杭州
     *
     * @var string
     */
    public $arrCity;

    /**
     * @example HGH
     *
     * @var string
     */
    public $arrCityCode;

    /**
     * @example 2021-03-18 20:26:56
     *
     * @var string
     */
    public $arrDate;

    /**
     * @example 1
     *
     * @var int
     */
    public $costCenterId;

    /**
     * @example 成本中心1
     *
     * @var string
     */
    public $costCenterName;

    /**
     * @example 杭州
     *
     * @var string
     */
    public $depCity;

    /**
     * @example HGH
     *
     * @var string
     */
    public $depCityCode;

    /**
     * @example 2021-03-18 20:26:56
     *
     * @var string
     */
    public $depDate;

    /**
     * @example 1
     *
     * @var int
     */
    public $invoiceId;

    /**
     * @example 发票抬头1
     *
     * @var string
     */
    public $invoiceName;

    /**
     * @example 1
     *
     * @var string
     */
    public $itineraryId;

    /**
     * @example projectx
     *
     * @var string
     */
    public $projectCode;

    /**
     * @example 项目x
     *
     * @var string
     */
    public $projectTitle;

    /**
     * @example 4
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
