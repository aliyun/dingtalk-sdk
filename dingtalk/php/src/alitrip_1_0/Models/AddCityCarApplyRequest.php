<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddCityCarApplyRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 杭州出差
     *
     * @var string
     */
    public $cause;

    /**
     * @description This parameter is required.
     *
     * @example 杭州
     *
     * @var string
     */
    public $city;

    /**
     * @description This parameter is required.
     *
     * @example corpx
     *
     * @var string
     */
    public $corpId;

    /**
     * @description This parameter is required.
     *
     * @example 2021-03-18 20:26:56
     *
     * @var string
     */
    public $date;

    /**
     * @example 2021-03-30 20:26:56
     *
     * @var string
     */
    public $finishedDate;

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
    public $projectName;

    /**
     * @description This parameter is required.
     *
     * @example 0
     *
     * @var int
     */
    public $status;

    /**
     * @description This parameter is required.
     *
     * @example apply1
     *
     * @var string
     */
    public $thirdPartApplyId;

    /**
     * @description This parameter is required.
     *
     * @example costcenter1
     *
     * @var string
     */
    public $thirdPartCostCenterId;

    /**
     * @description This parameter is required.
     *
     * @example invoice1
     *
     * @var string
     */
    public $thirdPartInvoiceId;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $timesTotal;

    /**
     * @description This parameter is required.
     *
     * @example 3
     *
     * @var int
     */
    public $timesType;

    /**
     * @description This parameter is required.
     *
     * @example 0
     *
     * @var int
     */
    public $timesUsed;

    /**
     * @description This parameter is required.
     *
     * @example 杭州出差
     *
     * @var string
     */
    public $title;

    /**
     * @description This parameter is required.
     *
     * @example user1
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'cause' => 'cause',
        'city' => 'city',
        'corpId' => 'corpId',
        'date' => 'date',
        'finishedDate' => 'finishedDate',
        'projectCode' => 'projectCode',
        'projectName' => 'projectName',
        'status' => 'status',
        'thirdPartApplyId' => 'thirdPartApplyId',
        'thirdPartCostCenterId' => 'thirdPartCostCenterId',
        'thirdPartInvoiceId' => 'thirdPartInvoiceId',
        'timesTotal' => 'timesTotal',
        'timesType' => 'timesType',
        'timesUsed' => 'timesUsed',
        'title' => 'title',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->cause) {
            $res['cause'] = $this->cause;
        }
        if (null !== $this->city) {
            $res['city'] = $this->city;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->date) {
            $res['date'] = $this->date;
        }
        if (null !== $this->finishedDate) {
            $res['finishedDate'] = $this->finishedDate;
        }
        if (null !== $this->projectCode) {
            $res['projectCode'] = $this->projectCode;
        }
        if (null !== $this->projectName) {
            $res['projectName'] = $this->projectName;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->thirdPartApplyId) {
            $res['thirdPartApplyId'] = $this->thirdPartApplyId;
        }
        if (null !== $this->thirdPartCostCenterId) {
            $res['thirdPartCostCenterId'] = $this->thirdPartCostCenterId;
        }
        if (null !== $this->thirdPartInvoiceId) {
            $res['thirdPartInvoiceId'] = $this->thirdPartInvoiceId;
        }
        if (null !== $this->timesTotal) {
            $res['timesTotal'] = $this->timesTotal;
        }
        if (null !== $this->timesType) {
            $res['timesType'] = $this->timesType;
        }
        if (null !== $this->timesUsed) {
            $res['timesUsed'] = $this->timesUsed;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddCityCarApplyRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cause'])) {
            $model->cause = $map['cause'];
        }
        if (isset($map['city'])) {
            $model->city = $map['city'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['date'])) {
            $model->date = $map['date'];
        }
        if (isset($map['finishedDate'])) {
            $model->finishedDate = $map['finishedDate'];
        }
        if (isset($map['projectCode'])) {
            $model->projectCode = $map['projectCode'];
        }
        if (isset($map['projectName'])) {
            $model->projectName = $map['projectName'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['thirdPartApplyId'])) {
            $model->thirdPartApplyId = $map['thirdPartApplyId'];
        }
        if (isset($map['thirdPartCostCenterId'])) {
            $model->thirdPartCostCenterId = $map['thirdPartCostCenterId'];
        }
        if (isset($map['thirdPartInvoiceId'])) {
            $model->thirdPartInvoiceId = $map['thirdPartInvoiceId'];
        }
        if (isset($map['timesTotal'])) {
            $model->timesTotal = $map['timesTotal'];
        }
        if (isset($map['timesType'])) {
            $model->timesType = $map['timesType'];
        }
        if (isset($map['timesUsed'])) {
            $model->timesUsed = $map['timesUsed'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
