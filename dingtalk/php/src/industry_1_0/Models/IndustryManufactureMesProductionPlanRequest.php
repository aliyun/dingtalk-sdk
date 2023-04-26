<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesProductionPlanRequest\extendData;
use AlibabaCloud\Tea\Model;

class IndustryManufactureMesProductionPlanRequest extends Model
{
    /**
     * @example add
     *
     * @var string
     */
    public $action;

    /**
     * @example 2021-03-12 00:00:00
     *
     * @var string
     */
    public $actualEndTime;

    /**
     * @example 2021-03-12 00:00:00
     *
     * @var string
     */
    public $actualStartTime;

    /**
     * @example opsoft
     *
     * @var string
     */
    public $appKey;

    /**
     * @example productionplan
     *
     * @var string
     */
    public $baseDataName;

    /**
     * @example 39C1E213-86B2-706B-9615-5B957DF8C15D
     *
     * @var string
     */
    public $bomUuid;

    /**
     * @var string[]
     */
    public $events;

    /**
     * @var extendData[]
     */
    public $extendData;

    /**
     * @example 20220509034
     *
     * @var string
     */
    public $no;

    /**
     * @example 0
     *
     * @var string
     */
    public $overdue;

    /**
     * @example 2021-03-12 00:00:00
     *
     * @var string
     */
    public $planEndTime;

    /**
     * @example 321
     *
     * @var string
     */
    public $planQuantity;

    /**
     * @example 2021-03-12 00:00:00
     *
     * @var string
     */
    public $planStartTime;

    /**
     * @example { TODO       "uuid": "1543878029722550273",       "name": "YF-钣金",       "preProcess": ""     }
     *
     * @var string
     */
    public $processUuids;

    /**
     * @example 011351
     *
     * @var string
     */
    public $productCode;

    /**
     * @example 毛坯KM50三级盖
     *
     * @var string
     */
    public $productName;

    /**
     * @example KM50
     *
     * @var string
     */
    public $productSpecification;

    /**
     * @example 300
     *
     * @var string
     */
    public $qualifiedQuantity;

    /**
     * @example sell20220509034
     *
     * @var string
     */
    public $sellOrderNo;

    /**
     * @example WORKING
     *
     * @var string
     */
    public $status;

    /**
     * @example {     "processId1": ["teamId11", "teamId12", "teamId13"],     "processId2": ["teamId21", "teamId22", "teamId23"] }
     *
     * @var string
     */
    public $teamList;

    /**
     * @example 毛坯KM50三级盖
     *
     * @var string
     */
    public $title;

    /**
     * @example NORMAL
     *
     * @var string
     */
    public $type;

    /**
     * @example 个
     *
     * @var string
     */
    public $unit;

    /**
     * @example 39C1E213-86B2-706B-9615-5B957DF8C15D
     *
     * @var string
     */
    public $uuid;
    protected $_name = [
        'action'               => 'action',
        'actualEndTime'        => 'actualEndTime',
        'actualStartTime'      => 'actualStartTime',
        'appKey'               => 'appKey',
        'baseDataName'         => 'baseDataName',
        'bomUuid'              => 'bomUuid',
        'events'               => 'events',
        'extendData'           => 'extendData',
        'no'                   => 'no',
        'overdue'              => 'overdue',
        'planEndTime'          => 'planEndTime',
        'planQuantity'         => 'planQuantity',
        'planStartTime'        => 'planStartTime',
        'processUuids'         => 'processUuids',
        'productCode'          => 'productCode',
        'productName'          => 'productName',
        'productSpecification' => 'productSpecification',
        'qualifiedQuantity'    => 'qualifiedQuantity',
        'sellOrderNo'          => 'sellOrderNo',
        'status'               => 'status',
        'teamList'             => 'teamList',
        'title'                => 'title',
        'type'                 => 'type',
        'unit'                 => 'unit',
        'uuid'                 => 'uuid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->action) {
            $res['action'] = $this->action;
        }
        if (null !== $this->actualEndTime) {
            $res['actualEndTime'] = $this->actualEndTime;
        }
        if (null !== $this->actualStartTime) {
            $res['actualStartTime'] = $this->actualStartTime;
        }
        if (null !== $this->appKey) {
            $res['appKey'] = $this->appKey;
        }
        if (null !== $this->baseDataName) {
            $res['baseDataName'] = $this->baseDataName;
        }
        if (null !== $this->bomUuid) {
            $res['bomUuid'] = $this->bomUuid;
        }
        if (null !== $this->events) {
            $res['events'] = $this->events;
        }
        if (null !== $this->extendData) {
            $res['extendData'] = [];
            if (null !== $this->extendData && \is_array($this->extendData)) {
                $n = 0;
                foreach ($this->extendData as $item) {
                    $res['extendData'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->no) {
            $res['no'] = $this->no;
        }
        if (null !== $this->overdue) {
            $res['overdue'] = $this->overdue;
        }
        if (null !== $this->planEndTime) {
            $res['planEndTime'] = $this->planEndTime;
        }
        if (null !== $this->planQuantity) {
            $res['planQuantity'] = $this->planQuantity;
        }
        if (null !== $this->planStartTime) {
            $res['planStartTime'] = $this->planStartTime;
        }
        if (null !== $this->processUuids) {
            $res['processUuids'] = $this->processUuids;
        }
        if (null !== $this->productCode) {
            $res['productCode'] = $this->productCode;
        }
        if (null !== $this->productName) {
            $res['productName'] = $this->productName;
        }
        if (null !== $this->productSpecification) {
            $res['productSpecification'] = $this->productSpecification;
        }
        if (null !== $this->qualifiedQuantity) {
            $res['qualifiedQuantity'] = $this->qualifiedQuantity;
        }
        if (null !== $this->sellOrderNo) {
            $res['sellOrderNo'] = $this->sellOrderNo;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->teamList) {
            $res['teamList'] = $this->teamList;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->unit) {
            $res['unit'] = $this->unit;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return IndustryManufactureMesProductionPlanRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['action'])) {
            $model->action = $map['action'];
        }
        if (isset($map['actualEndTime'])) {
            $model->actualEndTime = $map['actualEndTime'];
        }
        if (isset($map['actualStartTime'])) {
            $model->actualStartTime = $map['actualStartTime'];
        }
        if (isset($map['appKey'])) {
            $model->appKey = $map['appKey'];
        }
        if (isset($map['baseDataName'])) {
            $model->baseDataName = $map['baseDataName'];
        }
        if (isset($map['bomUuid'])) {
            $model->bomUuid = $map['bomUuid'];
        }
        if (isset($map['events'])) {
            if (!empty($map['events'])) {
                $model->events = $map['events'];
            }
        }
        if (isset($map['extendData'])) {
            if (!empty($map['extendData'])) {
                $model->extendData = [];
                $n                 = 0;
                foreach ($map['extendData'] as $item) {
                    $model->extendData[$n++] = null !== $item ? extendData::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['no'])) {
            $model->no = $map['no'];
        }
        if (isset($map['overdue'])) {
            $model->overdue = $map['overdue'];
        }
        if (isset($map['planEndTime'])) {
            $model->planEndTime = $map['planEndTime'];
        }
        if (isset($map['planQuantity'])) {
            $model->planQuantity = $map['planQuantity'];
        }
        if (isset($map['planStartTime'])) {
            $model->planStartTime = $map['planStartTime'];
        }
        if (isset($map['processUuids'])) {
            $model->processUuids = $map['processUuids'];
        }
        if (isset($map['productCode'])) {
            $model->productCode = $map['productCode'];
        }
        if (isset($map['productName'])) {
            $model->productName = $map['productName'];
        }
        if (isset($map['productSpecification'])) {
            $model->productSpecification = $map['productSpecification'];
        }
        if (isset($map['qualifiedQuantity'])) {
            $model->qualifiedQuantity = $map['qualifiedQuantity'];
        }
        if (isset($map['sellOrderNo'])) {
            $model->sellOrderNo = $map['sellOrderNo'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['teamList'])) {
            $model->teamList = $map['teamList'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['unit'])) {
            $model->unit = $map['unit'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
