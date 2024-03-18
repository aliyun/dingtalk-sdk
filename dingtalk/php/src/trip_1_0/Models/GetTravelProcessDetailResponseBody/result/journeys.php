<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\GetTravelProcessDetailResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\GetTravelProcessDetailResponseBody\result\journeys\arrival;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\GetTravelProcessDetailResponseBody\result\journeys\departure;
use AlibabaCloud\Tea\Model;

class journeys extends Model
{
    /**
     * @var arrival
     */
    public $arrival;

    /**
     * @example 成本中心一
     *
     * @var string
     */
    public $costCenter;

    /**
     * @example 123
     *
     * @var string
     */
    public $costCenterId;

    /**
     * @example c00001
     *
     * @var string
     */
    public $costCenterThirdPartyId;

    /**
     * @var departure
     */
    public $departure;

    /**
     * @example 2023-10-25
     *
     * @var string
     */
    public $endTime;

    /**
     * @example 2024-03-12 10:54:00
     *
     * @var string
     */
    public $endTimeAcc;

    /**
     * @example 发票抬头一
     *
     * @var string
     */
    public $invoiceTitle;

    /**
     * @example 123
     *
     * @var string
     */
    public $invoiceTitleId;

    /**
     * @example i0001
     *
     * @var string
     */
    public $invoiceTitleThirdPartyId;

    /**
     * @example 费用归属项目一
     *
     * @var string
     */
    public $itineraryProject;

    /**
     * @example 123
     *
     * @var string
     */
    public $itineraryProjectId;

    /**
     * @example y00001
     *
     * @var string
     */
    public $itineraryProjectThirdPartyId;

    /**
     * @example 123455xxxxxxxx
     *
     * @var string
     */
    public $journeyBizNo;

    /**
     * @example 2023-10-20
     *
     * @var string
     */
    public $startTime;

    /**
     * @example 2024-03-12 10:54:00
     *
     * @var string
     */
    public $startTimeAcc;

    /**
     * @example 天
     *
     * @var string
     */
    public $timeUnit;

    /**
     * @example 飞机
     *
     * @var string
     */
    public $travelType;

    /**
     * @example 单程
     *
     * @var string
     */
    public $tripWay;
    protected $_name = [
        'arrival'                      => 'arrival',
        'costCenter'                   => 'costCenter',
        'costCenterId'                 => 'costCenterId',
        'costCenterThirdPartyId'       => 'costCenterThirdPartyId',
        'departure'                    => 'departure',
        'endTime'                      => 'endTime',
        'endTimeAcc'                   => 'endTimeAcc',
        'invoiceTitle'                 => 'invoiceTitle',
        'invoiceTitleId'               => 'invoiceTitleId',
        'invoiceTitleThirdPartyId'     => 'invoiceTitleThirdPartyId',
        'itineraryProject'             => 'itineraryProject',
        'itineraryProjectId'           => 'itineraryProjectId',
        'itineraryProjectThirdPartyId' => 'itineraryProjectThirdPartyId',
        'journeyBizNo'                 => 'journeyBizNo',
        'startTime'                    => 'startTime',
        'startTimeAcc'                 => 'startTimeAcc',
        'timeUnit'                     => 'timeUnit',
        'travelType'                   => 'travelType',
        'tripWay'                      => 'tripWay',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->arrival) {
            $res['arrival'] = null !== $this->arrival ? $this->arrival->toMap() : null;
        }
        if (null !== $this->costCenter) {
            $res['costCenter'] = $this->costCenter;
        }
        if (null !== $this->costCenterId) {
            $res['costCenterId'] = $this->costCenterId;
        }
        if (null !== $this->costCenterThirdPartyId) {
            $res['costCenterThirdPartyId'] = $this->costCenterThirdPartyId;
        }
        if (null !== $this->departure) {
            $res['departure'] = null !== $this->departure ? $this->departure->toMap() : null;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->endTimeAcc) {
            $res['endTimeAcc'] = $this->endTimeAcc;
        }
        if (null !== $this->invoiceTitle) {
            $res['invoiceTitle'] = $this->invoiceTitle;
        }
        if (null !== $this->invoiceTitleId) {
            $res['invoiceTitleId'] = $this->invoiceTitleId;
        }
        if (null !== $this->invoiceTitleThirdPartyId) {
            $res['invoiceTitleThirdPartyId'] = $this->invoiceTitleThirdPartyId;
        }
        if (null !== $this->itineraryProject) {
            $res['itineraryProject'] = $this->itineraryProject;
        }
        if (null !== $this->itineraryProjectId) {
            $res['itineraryProjectId'] = $this->itineraryProjectId;
        }
        if (null !== $this->itineraryProjectThirdPartyId) {
            $res['itineraryProjectThirdPartyId'] = $this->itineraryProjectThirdPartyId;
        }
        if (null !== $this->journeyBizNo) {
            $res['journeyBizNo'] = $this->journeyBizNo;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->startTimeAcc) {
            $res['startTimeAcc'] = $this->startTimeAcc;
        }
        if (null !== $this->timeUnit) {
            $res['timeUnit'] = $this->timeUnit;
        }
        if (null !== $this->travelType) {
            $res['travelType'] = $this->travelType;
        }
        if (null !== $this->tripWay) {
            $res['tripWay'] = $this->tripWay;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return journeys
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['arrival'])) {
            $model->arrival = arrival::fromMap($map['arrival']);
        }
        if (isset($map['costCenter'])) {
            $model->costCenter = $map['costCenter'];
        }
        if (isset($map['costCenterId'])) {
            $model->costCenterId = $map['costCenterId'];
        }
        if (isset($map['costCenterThirdPartyId'])) {
            $model->costCenterThirdPartyId = $map['costCenterThirdPartyId'];
        }
        if (isset($map['departure'])) {
            $model->departure = departure::fromMap($map['departure']);
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['endTimeAcc'])) {
            $model->endTimeAcc = $map['endTimeAcc'];
        }
        if (isset($map['invoiceTitle'])) {
            $model->invoiceTitle = $map['invoiceTitle'];
        }
        if (isset($map['invoiceTitleId'])) {
            $model->invoiceTitleId = $map['invoiceTitleId'];
        }
        if (isset($map['invoiceTitleThirdPartyId'])) {
            $model->invoiceTitleThirdPartyId = $map['invoiceTitleThirdPartyId'];
        }
        if (isset($map['itineraryProject'])) {
            $model->itineraryProject = $map['itineraryProject'];
        }
        if (isset($map['itineraryProjectId'])) {
            $model->itineraryProjectId = $map['itineraryProjectId'];
        }
        if (isset($map['itineraryProjectThirdPartyId'])) {
            $model->itineraryProjectThirdPartyId = $map['itineraryProjectThirdPartyId'];
        }
        if (isset($map['journeyBizNo'])) {
            $model->journeyBizNo = $map['journeyBizNo'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['startTimeAcc'])) {
            $model->startTimeAcc = $map['startTimeAcc'];
        }
        if (isset($map['timeUnit'])) {
            $model->timeUnit = $map['timeUnit'];
        }
        if (isset($map['travelType'])) {
            $model->travelType = $map['travelType'];
        }
        if (isset($map['tripWay'])) {
            $model->tripWay = $map['tripWay'];
        }

        return $model;
    }
}
