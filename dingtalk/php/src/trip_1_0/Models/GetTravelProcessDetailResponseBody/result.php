<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\GetTravelProcessDetailResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\GetTravelProcessDetailResponseBody\result\extFormComponent;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\GetTravelProcessDetailResponseBody\result\journeys;
use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\GetTravelProcessDetailResponseBody\result\tasks;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 2024-07-18 00:00:00
     *
     * @var string
     */
    public $archiveTime;

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
     * @example c00001
     *
     * @var string
     */
    public $costCenterThirdPartyId;

    /**
     * @example 2024-03-18 17:07:00
     *
     * @var string
     */
    public $createTime;

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
     * @example i0001
     *
     * @var string
     */
    public $invoiceTitleThirdPartyId;

    /**
     * @example 电商对接项目
     *
     * @var string
     */
    public $itineraryProject;

    /**
     * @example y00001
     *
     * @var string
     */
    public $itineraryProjectThirdPartyId;

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
     * @example staffIdxyy
     *
     * @var string
     */
    public $originatorIdOnBehalf;

    /**
     * @example NONE
     *
     * @var string
     */
    public $processBizAction;

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
     * @var tasks[]
     */
    public $tasks;

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

    /**
     * @example 2
     *
     * @var string
     */
    public $tripDays;
    protected $_name = [
        'archiveTime' => 'archiveTime',
        'bizCategoryId' => 'bizCategoryId',
        'businessId' => 'businessId',
        'corpId' => 'corpId',
        'costCenter' => 'costCenter',
        'costCenterId' => 'costCenterId',
        'costCenterThirdPartyId' => 'costCenterThirdPartyId',
        'createTime' => 'createTime',
        'extFormComponent' => 'extFormComponent',
        'feeType' => 'feeType',
        'invoiceTitle' => 'invoiceTitle',
        'invoiceTitleId' => 'invoiceTitleId',
        'invoiceTitleThirdPartyId' => 'invoiceTitleThirdPartyId',
        'itineraryProject' => 'itineraryProject',
        'itineraryProjectThirdPartyId' => 'itineraryProjectThirdPartyId',
        'journeys' => 'journeys',
        'mainProcessInstanceId' => 'mainProcessInstanceId',
        'memo' => 'memo',
        'originatorId' => 'originatorId',
        'originatorIdOnBehalf' => 'originatorIdOnBehalf',
        'processBizAction' => 'processBizAction',
        'processInstanceId' => 'processInstanceId',
        'processResult' => 'processResult',
        'processStatus' => 'processStatus',
        'remark' => 'remark',
        'tasks' => 'tasks',
        'travelCategory' => 'travelCategory',
        'travelers' => 'travelers',
        'tripDays' => 'tripDays',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->archiveTime) {
            $res['archiveTime'] = $this->archiveTime;
        }
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
        if (null !== $this->costCenterThirdPartyId) {
            $res['costCenterThirdPartyId'] = $this->costCenterThirdPartyId;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
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
        if (null !== $this->invoiceTitleThirdPartyId) {
            $res['invoiceTitleThirdPartyId'] = $this->invoiceTitleThirdPartyId;
        }
        if (null !== $this->itineraryProject) {
            $res['itineraryProject'] = $this->itineraryProject;
        }
        if (null !== $this->itineraryProjectThirdPartyId) {
            $res['itineraryProjectThirdPartyId'] = $this->itineraryProjectThirdPartyId;
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
        if (null !== $this->originatorIdOnBehalf) {
            $res['originatorIdOnBehalf'] = $this->originatorIdOnBehalf;
        }
        if (null !== $this->processBizAction) {
            $res['processBizAction'] = $this->processBizAction;
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
        if (null !== $this->tasks) {
            $res['tasks'] = [];
            if (null !== $this->tasks && \is_array($this->tasks)) {
                $n = 0;
                foreach ($this->tasks as $item) {
                    $res['tasks'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->travelCategory) {
            $res['travelCategory'] = $this->travelCategory;
        }
        if (null !== $this->travelers) {
            $res['travelers'] = $this->travelers;
        }
        if (null !== $this->tripDays) {
            $res['tripDays'] = $this->tripDays;
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
        if (isset($map['archiveTime'])) {
            $model->archiveTime = $map['archiveTime'];
        }
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
        if (isset($map['costCenterThirdPartyId'])) {
            $model->costCenterThirdPartyId = $map['costCenterThirdPartyId'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['extFormComponent'])) {
            if (!empty($map['extFormComponent'])) {
                $model->extFormComponent = [];
                $n = 0;
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
        if (isset($map['invoiceTitleThirdPartyId'])) {
            $model->invoiceTitleThirdPartyId = $map['invoiceTitleThirdPartyId'];
        }
        if (isset($map['itineraryProject'])) {
            $model->itineraryProject = $map['itineraryProject'];
        }
        if (isset($map['itineraryProjectThirdPartyId'])) {
            $model->itineraryProjectThirdPartyId = $map['itineraryProjectThirdPartyId'];
        }
        if (isset($map['journeys'])) {
            if (!empty($map['journeys'])) {
                $model->journeys = [];
                $n = 0;
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
        if (isset($map['originatorIdOnBehalf'])) {
            $model->originatorIdOnBehalf = $map['originatorIdOnBehalf'];
        }
        if (isset($map['processBizAction'])) {
            $model->processBizAction = $map['processBizAction'];
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
        if (isset($map['tasks'])) {
            if (!empty($map['tasks'])) {
                $model->tasks = [];
                $n = 0;
                foreach ($map['tasks'] as $item) {
                    $model->tasks[$n++] = null !== $item ? tasks::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['travelCategory'])) {
            $model->travelCategory = $map['travelCategory'];
        }
        if (isset($map['travelers'])) {
            if (!empty($map['travelers'])) {
                $model->travelers = $map['travelers'];
            }
        }
        if (isset($map['tripDays'])) {
            $model->tripDays = $map['tripDays'];
        }

        return $model;
    }
}
