<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesProcessRequest\extendData;
use AlibabaCloud\Tea\Model;

class IndustryManufactureMesProcessRequest extends Model
{
    /**
     * @example add
     *
     * @var string
     */
    public $action;

    /**
     * @example opsoft
     *
     * @var string
     */
    public $appKey;

    /**
     * @example process
     *
     * @var string
     */
    public $baseDataName;

    /**
     * @var extendData[]
     */
    public $extendData;

    /**
     * @example 打磨
     *
     * @var string
     */
    public $name;

    /**
     * @example y
     *
     * @var string
     */
    public $needDispatch;

    /**
     * @example n
     *
     * @var string
     */
    public $needQualityTest;

    /**
     * @example 011354
     *
     * @var string
     */
    public $no;

    /**
     * @example 0.21
     *
     * @var string
     */
    public $price;

    /**
     * @example 自制
     *
     * @var string
     */
    public $prop;

    /**
     * @example 这里是备注
     *
     * @var string
     */
    public $remark;

    /**
     * @example 止口面攻牙的操作方法
     *
     * @var string
     */
    public $sop;

    /**
     * @example 39C1E213-86B2-706B-9615-5B957DF8C15D
     *
     * @var string
     */
    public $uuid;
    protected $_name = [
        'action'          => 'action',
        'appKey'          => 'appKey',
        'baseDataName'    => 'baseDataName',
        'extendData'      => 'extendData',
        'name'            => 'name',
        'needDispatch'    => 'needDispatch',
        'needQualityTest' => 'needQualityTest',
        'no'              => 'no',
        'price'           => 'price',
        'prop'            => 'prop',
        'remark'          => 'remark',
        'sop'             => 'sop',
        'uuid'            => 'uuid',
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
        if (null !== $this->appKey) {
            $res['appKey'] = $this->appKey;
        }
        if (null !== $this->baseDataName) {
            $res['baseDataName'] = $this->baseDataName;
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
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->needDispatch) {
            $res['needDispatch'] = $this->needDispatch;
        }
        if (null !== $this->needQualityTest) {
            $res['needQualityTest'] = $this->needQualityTest;
        }
        if (null !== $this->no) {
            $res['no'] = $this->no;
        }
        if (null !== $this->price) {
            $res['price'] = $this->price;
        }
        if (null !== $this->prop) {
            $res['prop'] = $this->prop;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->sop) {
            $res['sop'] = $this->sop;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return IndustryManufactureMesProcessRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['action'])) {
            $model->action = $map['action'];
        }
        if (isset($map['appKey'])) {
            $model->appKey = $map['appKey'];
        }
        if (isset($map['baseDataName'])) {
            $model->baseDataName = $map['baseDataName'];
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
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['needDispatch'])) {
            $model->needDispatch = $map['needDispatch'];
        }
        if (isset($map['needQualityTest'])) {
            $model->needQualityTest = $map['needQualityTest'];
        }
        if (isset($map['no'])) {
            $model->no = $map['no'];
        }
        if (isset($map['price'])) {
            $model->price = $map['price'];
        }
        if (isset($map['prop'])) {
            $model->prop = $map['prop'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['sop'])) {
            $model->sop = $map['sop'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
