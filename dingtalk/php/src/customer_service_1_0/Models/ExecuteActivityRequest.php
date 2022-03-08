<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models\ExecuteActivityRequest\properties;
use AlibabaCloud\Tea\Model;

class ExecuteActivityRequest extends Model
{
    /**
     * @description 动作编码
     *
     * @var string
     */
    public $activityCode;

    /**
     * @description 会员ID
     *
     * @var string
     */
    public $foreignId;

    /**
     * @description 会员名称
     *
     * @var string
     */
    public $foreignName;

    /**
     * @description 实例id
     *
     * @var string
     */
    public $openInstanceId;

    /**
     * @description 产品类型
     *
     * @var int
     */
    public $productionType;

    /**
     * @description 工单表单字段
     *
     * @var properties[]
     */
    public $properties;

    /**
     * @description 来源ID
     *
     * @var string
     */
    public $sourceId;
    protected $_name = [
        'activityCode'   => 'activityCode',
        'foreignId'      => 'foreignId',
        'foreignName'    => 'foreignName',
        'openInstanceId' => 'openInstanceId',
        'productionType' => 'productionType',
        'properties'     => 'properties',
        'sourceId'       => 'sourceId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->activityCode) {
            $res['activityCode'] = $this->activityCode;
        }
        if (null !== $this->foreignId) {
            $res['foreignId'] = $this->foreignId;
        }
        if (null !== $this->foreignName) {
            $res['foreignName'] = $this->foreignName;
        }
        if (null !== $this->openInstanceId) {
            $res['openInstanceId'] = $this->openInstanceId;
        }
        if (null !== $this->productionType) {
            $res['productionType'] = $this->productionType;
        }
        if (null !== $this->properties) {
            $res['properties'] = [];
            if (null !== $this->properties && \is_array($this->properties)) {
                $n = 0;
                foreach ($this->properties as $item) {
                    $res['properties'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->sourceId) {
            $res['sourceId'] = $this->sourceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ExecuteActivityRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['activityCode'])) {
            $model->activityCode = $map['activityCode'];
        }
        if (isset($map['foreignId'])) {
            $model->foreignId = $map['foreignId'];
        }
        if (isset($map['foreignName'])) {
            $model->foreignName = $map['foreignName'];
        }
        if (isset($map['openInstanceId'])) {
            $model->openInstanceId = $map['openInstanceId'];
        }
        if (isset($map['productionType'])) {
            $model->productionType = $map['productionType'];
        }
        if (isset($map['properties'])) {
            if (!empty($map['properties'])) {
                $model->properties = [];
                $n                 = 0;
                foreach ($map['properties'] as $item) {
                    $model->properties[$n++] = null !== $item ? properties::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['sourceId'])) {
            $model->sourceId = $map['sourceId'];
        }

        return $model;
    }
}
