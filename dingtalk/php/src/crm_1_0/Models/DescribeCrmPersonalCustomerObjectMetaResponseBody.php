<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeCrmPersonalCustomerObjectMetaResponseBody\fields;
use AlibabaCloud\Tea\Model;

class DescribeCrmPersonalCustomerObjectMetaResponseBody extends Model
{
    /**
     * @description 表单code
     *
     * @var string
     */
    public $code;

    /**
     * @description 是否自定义对象
     *
     * @var bool
     */
    public $customized;

    /**
     * @description 字段列表
     *
     * @var fields[]
     */
    public $fields;

    /**
     * @description 对象名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 表单状态
     *
     * @var string
     */
    public $status;
    protected $_name = [
        'code'       => 'code',
        'customized' => 'customized',
        'fields'     => 'fields',
        'name'       => 'name',
        'status'     => 'status',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->customized) {
            $res['customized'] = $this->customized;
        }
        if (null !== $this->fields) {
            $res['fields'] = [];
            if (null !== $this->fields && \is_array($this->fields)) {
                $n = 0;
                foreach ($this->fields as $item) {
                    $res['fields'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DescribeCrmPersonalCustomerObjectMetaResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['customized'])) {
            $model->customized = $map['customized'];
        }
        if (isset($map['fields'])) {
            if (!empty($map['fields'])) {
                $model->fields = [];
                $n             = 0;
                foreach ($map['fields'] as $item) {
                    $model->fields[$n++] = null !== $item ? fields::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
