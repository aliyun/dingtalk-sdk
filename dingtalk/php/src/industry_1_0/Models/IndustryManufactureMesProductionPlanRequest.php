<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesProductionPlanRequest\extendData;
use AlibabaCloud\Tea\Model;

class IndustryManufactureMesProductionPlanRequest extends Model
{
    /**
     * @description 本次操作的行为
     *
     * @var string
     */
    public $action;

    /**
     * @description actualEndTime
     *
     * @var string
     */
    public $actualEndTime;

    /**
     * @description actualStartTime
     *
     * @var string
     */
    public $actualStartTime;

    /**
     * @description 生态唯一标识,枚举:opsoft， 需要注册
     *
     * @var string
     */
    public $appKey;

    /**
     * @description 主数据名称
     *
     * @var string
     */
    public $baseDataName;

    /**
     * @description BOM业务唯一标识
     *
     * @var string
     */
    public $bomUuid;

    /**
     * @description 事件列表
     *
     * @var string[]
     */
    public $events;

    /**
     * @description 扩展字段
     *
     * @var extendData[]
     */
    public $extendData;

    /**
     * @description 工单编号(生产订单号)
     *
     * @var string
     */
    public $no;

    /**
     * @description 任务逾期
     *
     * @var string
     */
    public $overdue;

    /**
     * @description 计划结束时间
     *
     * @var string
     */
    public $planEndTime;

    /**
     * @description 工单计划数
     *
     * @var string
     */
    public $planQuantity;

    /**
     * @description 计划开始时间
     *
     * @var string
     */
    public $planStartTime;

    /**
     * @description 工序列表(有序) 主体
     *
     * @var string
     */
    public $processUuids;

    /**
     * @description 产品代码(物料编号)
     *
     * @var string
     */
    public $productCode;

    /**
     * @description 产品名称
     *
     * @var string
     */
    public $productName;

    /**
     * @description 规格型号
     *
     * @var string
     */
    public $productSpecification;

    /**
     * @description 最后一道工序完成数量
     *
     * @var string
     */
    public $qualifiedQuantity;

    /**
     * @description 销售订单
     *
     * @var string
     */
    public $sellOrderNo;

    /**
     * @description 工单状态
     *
     * @var string
     */
    public $status;

    /**
     * @description 班组信息(有序)
     *
     * @var string
     */
    public $teamList;

    /**
     * @description 工单标题
     *
     * @var string
     */
    public $title;

    /**
     * @description 工单类型,["NORMAL"(普通),"返工","样品"],默认"NORMAL"
     *
     * @var string
     */
    public $type;

    /**
     * @description 单位
     *
     * @var string
     */
    public $unit;

    /**
     * @description 工单实例的唯一Id
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
