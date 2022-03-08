<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models\CreateTicketRequest\properties;
use AlibabaCloud\Tea\Model;

class CreateTicketRequest extends Model
{
    /**
     * @description 第三方会员ID
     *
     * @var string
     */
    public $foreignId;

    /**
     * @description 第三方会员名称
     *
     * @var string
     */
    public $foreignName;

    /**
     * @description 实例ID
     *
     * @var string
     */
    public $openInstanceId;

    /**
     * @description 智能客服产品
     *
     * @var int
     */
    public $productionType;

    /**
     * @description 工单表单
     *
     * @var properties[]
     */
    public $properties;

    /**
     * @description 会员来源
     *
     * @var string
     */
    public $sourceId;

    /**
     * @description 工单模板ID
     *
     * @var string
     */
    public $templateId;

    /**
     * @description 工单标题
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'foreignId'      => 'foreignId',
        'foreignName'    => 'foreignName',
        'openInstanceId' => 'openInstanceId',
        'productionType' => 'productionType',
        'properties'     => 'properties',
        'sourceId'       => 'sourceId',
        'templateId'     => 'templateId',
        'title'          => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
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
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateTicketRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
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
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
