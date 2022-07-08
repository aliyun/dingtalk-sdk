<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QuerySchemaByProcessCodeResponseBody\result\schemaContent\items;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QuerySchemaByProcessCodeResponseBody\result\schemaContent\items\children\props;
use AlibabaCloud\Tea\Model;

class children extends Model
{
    /**
     * @description 控件类型
     *
     * @var string
     */
    public $componentName;

    /**
     * @description 子控件属性
     *
     * @var props
     */
    public $props;
    protected $_name = [
        'componentName' => 'componentName',
        'props'         => 'props',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->componentName) {
            $res['componentName'] = $this->componentName;
        }
        if (null !== $this->props) {
            $res['props'] = null !== $this->props ? $this->props->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return children
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['componentName'])) {
            $model->componentName = $map['componentName'];
        }
        if (isset($map['props'])) {
            $model->props = props::fromMap($map['props']);
        }

        return $model;
    }
}
