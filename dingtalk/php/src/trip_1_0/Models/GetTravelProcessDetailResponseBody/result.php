<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\GetTravelProcessDetailResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\GetTravelProcessDetailResponseBody\result\extFormComponent;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\GetTravelProcessDetailResponseBody\result\journeys;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example alitrip.business
     *
     * @var string
     */
    public $bizCategoryId;

    /**
     * @example 202310231720000276784
     *
     * @var string
     */
    public $businessId;

    /**
     * @example ding123456xxxx
     *
     * @var string
     */
    public $corpId;

    /**
     * @example it成本中心
     *
     * @var string
     */
    public $costCenter;

    /**
     * @example 成本中心id
     *
     * @var string
     */
    public $costCenterId;

    /**
     * @var extFormComponent[]
     */
    public $extFormComponent;

    /**
     * @example 部门费用
     *
     * @var string
     */
    public $feeType;

    /**
     * @example 发票抬头
     *
     * @var string
     */
    public $invoiceTitle;

    /**
     * @example 发票抬头id
     *
     * @var string
     */
    public $invoiceTitleId;

    /**
     * @example 电商对接项目
     *
     * @var string
     */
    public $itineraryProject;

    /**
     * @var journeys[]
     */
    public $journeys;

    /**
     * @example AG3WERxWRFex63xxxxx
     *
     * @var string
     */
    public $mainProcessInstanceId;

    /**
     * @example 坐飞机出差
     *
     * @var string
     */
    public $memo;

    /**
     * @example staffidxxxxx
     *
     * @var string
     */
    public $originatorId;

    /**
     * @example AG3U12xWRFex63hxxxxx
     *
     * @var string
     */
    public $processInstanceId;

    /**
     * @example agree
     *
     * @var string
     */
    public $processResult;

    /**
     * @example COMPLETED
     *
     * @var string
     */
    public $processStatus;

    /**
     * @example 因公出差
     *
     * @var string
     */
    public $remark;

    /**
     * @example 费用归属部门
     *
     * @var string
     */
    public $travelCategory;

    /**
     * @var string[]
     */
    public $travelers;
    protected $_name = [
        'bizCategoryId'         => 'bizCategoryId',
        'businessId'            => 'businessId',
        'corpId'                => 'corpId',
        'costCenter'            => 'costCenter',
        'costCenterId'          => 'costCenterId',
        'extFormComponent'      => 'extFormComponent',
        'feeType'               => 'feeType',
        'invoiceTitle'          => 'invoiceTitle',
        'invoiceTitleId'        => 'invoiceTitleId',
        'itineraryProject'      => 'itineraryProject',
        'journeys'              => 'journeys',
        'mainProcessInstanceId' => 'mainProcessInstanceId',
        'memo'                  => 'memo',
        'originatorId'          => 'originatorId',
        'processInstanceId'     => 'processInstanceId',
        'processResult'         => 'processResult',
        'processStatus'         => 'processStatus',
        'remark'                => 'remark',
        'travelCategory'        => 'travelCategory',
        'travelers'             => 'travelers',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizCategoryId) {
            $res['bizCategoryId'] = $this->bizCategoryId;
        }
        if (null !== $this->businessId) {
            $res['businessId'] = $this->businessId;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->costCenter) {
            $res['costCenter'] = $this->costCenter;
        }
        if (null !== $this->costCenterId) {
            $res['costCenterId'] = $this->costCenterId;
        }
        if (null !== $this->extFormComponent) {
            $res['extFormComponent'] = [];
            if (null !== $this->extFormComponent && \is_array($this->extFormComponent)) {
                $n = 0;
                foreach ($this->extFormComponent as $item) {
                    $res['extFormComponent'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->feeType) {
            $res['feeType'] = $this->feeType;
        }
        if (null !== $this->invoiceTitle) {
            $res['invoiceTitle'] = $this->invoiceTitle;
        }
        if (null !== $this->invoiceTitleId) {
            $res['invoiceTitleId'] = $this->invoiceTitleId;
        }
        if (null !== $this->itineraryProject) {
            $res['itineraryProject'] = $this->itineraryProject;
        }
        if (null !== $this->journeys) {
            $res['journeys'] = [];
            if (null !== $this->journeys && \is_array($this->journeys)) {
                $n = 0;
                foreach ($this->journeys as $item) {
                    $res['journeys'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->mainProcessInstanceId) {
            $res['mainProcessInstanceId'] = $this->mainProcessInstanceId;
        }
        if (null !== $this->memo) {
            $res['memo'] = $this->memo;
        }
        if (null !== $this->originatorId) {
            $res['originatorId'] = $this->originatorId;
        }
        if (null !== $this->processInstanceId) {
            $res['processInstanceId'] = $this->processInstanceId;
        }
        if (null !== $this->processResult) {
            $res['processResult'] = $this->processResult;
        }
        if (null !== $this->processStatus) {
            $res['processStatus'] = $this->processStatus;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->travelCategory) {
            $res['travelCategory'] = $this->travelCategory;
        }
        if (null !== $this->travelers) {
            $res['travelers'] = $this->travelers;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizCategoryId'])) {
            $model->bizCategoryId = $map['bizCategoryId'];
        }
        if (isset($map['businessId'])) {
            $model->businessId = $map['businessId'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['costCenter'])) {
            $model->costCenter = $map['costCenter'];
        }
        if (isset($map['costCenterId'])) {
            $model->costCenterId = $map['costCenterId'];
        }
        if (isset($map['extFormComponent'])) {
            if (!empty($map['extFormComponent'])) {
                $model->extFormComponent = [];
                $n                       = 0;
                foreach ($map['extFormComponent'] as $item) {
                    $model->extFormComponent[$n++] = null !== $item ? extFormComponent::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['feeType'])) {
            $model->feeType = $map['feeType'];
        }
        if (isset($map['invoiceTitle'])) {
            $model->invoiceTitle = $map['invoiceTitle'];
        }
        if (isset($map['invoiceTitleId'])) {
            $model->invoiceTitleId = $map['invoiceTitleId'];
        }
        if (isset($map['itineraryProject'])) {
            $model->itineraryProject = $map['itineraryProject'];
        }
        if (isset($map['journeys'])) {
            if (!empty($map['journeys'])) {
                $model->journeys = [];
                $n               = 0;
                foreach ($map['journeys'] as $item) {
                    $model->journeys[$n++] = null !== $item ? journeys::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['mainProcessInstanceId'])) {
            $model->mainProcessInstanceId = $map['mainProcessInstanceId'];
        }
        if (isset($map['memo'])) {
            $model->memo = $map['memo'];
        }
        if (isset($map['originatorId'])) {
            $model->originatorId = $map['originatorId'];
        }
        if (isset($map['processInstanceId'])) {
            $model->processInstanceId = $map['processInstanceId'];
        }
        if (isset($map['processResult'])) {
            $model->processResult = $map['processResult'];
        }
        if (isset($map['processStatus'])) {
            $model->processStatus = $map['processStatus'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['travelCategory'])) {
            $model->travelCategory = $map['travelCategory'];
        }
        if (isset($map['travelers'])) {
            if (!empty($map['travelers'])) {
                $model->travelers = $map['travelers'];
            }
        }

        return $model;
    }
}
