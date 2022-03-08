<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeRelationMetaResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeRelationMetaResponseBody\relationMetaDTOList\items;
use AlibabaCloud\Tea\Model;

class relationMetaDTOList extends Model
{
    /**
     * @description 创建者userId
     *
     * @var string
     */
    public $creatorUserId;

    /**
     * @description 模型结构描述
     *
     * @var string
     */
    public $desc;

    /**
     * @description 创建时间
     *
     * @var string
     */
    public $gmtCreate;

    /**
     * @description 修改时间
     *
     * @var string
     */
    public $gmtModified;

    /**
     * @description 模型结构字段集合
     *
     * @var items[]
     */
    public $items;

    /**
     * @description 模型结构名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 模型结构code
     *
     * @var string
     */
    public $relationMetaCode;

    /**
     * @description 模型结构状态
     *
     * @var string
     */
    public $relationMetaStatus;

    /**
     * @description 关系类型
     *
     * @var string
     */
    public $relationType;
    protected $_name = [
        'creatorUserId'      => 'creatorUserId',
        'desc'               => 'desc',
        'gmtCreate'          => 'gmtCreate',
        'gmtModified'        => 'gmtModified',
        'items'              => 'items',
        'name'               => 'name',
        'relationMetaCode'   => 'relationMetaCode',
        'relationMetaStatus' => 'relationMetaStatus',
        'relationType'       => 'relationType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->creatorUserId) {
            $res['creatorUserId'] = $this->creatorUserId;
        }
        if (null !== $this->desc) {
            $res['desc'] = $this->desc;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->items) {
            $res['items'] = [];
            if (null !== $this->items && \is_array($this->items)) {
                $n = 0;
                foreach ($this->items as $item) {
                    $res['items'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->relationMetaCode) {
            $res['relationMetaCode'] = $this->relationMetaCode;
        }
        if (null !== $this->relationMetaStatus) {
            $res['relationMetaStatus'] = $this->relationMetaStatus;
        }
        if (null !== $this->relationType) {
            $res['relationType'] = $this->relationType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return relationMetaDTOList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['creatorUserId'])) {
            $model->creatorUserId = $map['creatorUserId'];
        }
        if (isset($map['desc'])) {
            $model->desc = $map['desc'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['items'])) {
            if (!empty($map['items'])) {
                $model->items = [];
                $n            = 0;
                foreach ($map['items'] as $item) {
                    $model->items[$n++] = null !== $item ? items::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['relationMetaCode'])) {
            $model->relationMetaCode = $map['relationMetaCode'];
        }
        if (isset($map['relationMetaStatus'])) {
            $model->relationMetaStatus = $map['relationMetaStatus'];
        }
        if (isset($map['relationType'])) {
            $model->relationType = $map['relationType'];
        }

        return $model;
    }
}
