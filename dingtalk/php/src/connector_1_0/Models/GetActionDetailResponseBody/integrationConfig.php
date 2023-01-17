<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\GetActionDetailResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\GetActionDetailResponseBody\integrationConfig\categoryNames;
use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\GetActionDetailResponseBody\integrationConfig\props;
use AlibabaCloud\Tea\Model;

class integrationConfig extends Model
{
    /**
     * @description 类目配置
     *
     * @var categoryNames[]
     */
    public $categoryNames;

    /**
     * @description 集成对象的名称
     *
     * @var string
     */
    public $entityName;

    /**
     * @description 其它额外属性
     *
     * @var props[]
     */
    public $props;
    protected $_name = [
        'categoryNames' => 'categoryNames',
        'entityName'    => 'entityName',
        'props'         => 'props',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->categoryNames) {
            $res['categoryNames'] = [];
            if (null !== $this->categoryNames && \is_array($this->categoryNames)) {
                $n = 0;
                foreach ($this->categoryNames as $item) {
                    $res['categoryNames'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->entityName) {
            $res['entityName'] = $this->entityName;
        }
        if (null !== $this->props) {
            $res['props'] = [];
            if (null !== $this->props && \is_array($this->props)) {
                $n = 0;
                foreach ($this->props as $item) {
                    $res['props'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return integrationConfig
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['categoryNames'])) {
            if (!empty($map['categoryNames'])) {
                $model->categoryNames = [];
                $n                    = 0;
                foreach ($map['categoryNames'] as $item) {
                    $model->categoryNames[$n++] = null !== $item ? categoryNames::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['entityName'])) {
            $model->entityName = $map['entityName'];
        }
        if (isset($map['props'])) {
            if (!empty($map['props'])) {
                $model->props = [];
                $n            = 0;
                foreach ($map['props'] as $item) {
                    $model->props[$n++] = null !== $item ? props::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
