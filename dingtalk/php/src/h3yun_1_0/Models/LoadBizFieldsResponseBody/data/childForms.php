<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\LoadBizFieldsResponseBody\data;

use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\LoadBizFieldsResponseBody\data\childForms\fields;
use AlibabaCloud\Tea\Model;

class childForms extends Model
{
    /**
     * @description 子表编码
     *
     * @var string
     */
    public $schemaCode;

    /**
     * @description 子表名称
     *
     * @var string
     */
    public $formName;

    /**
     * @description 子表字段
     *
     * @var fields[]
     */
    public $fields;
    protected $_name = [
        'schemaCode' => 'schemaCode',
        'formName'   => 'formName',
        'fields'     => 'fields',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->schemaCode) {
            $res['schemaCode'] = $this->schemaCode;
        }
        if (null !== $this->formName) {
            $res['formName'] = $this->formName;
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return childForms
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['schemaCode'])) {
            $model->schemaCode = $map['schemaCode'];
        }
        if (isset($map['formName'])) {
            $model->formName = $map['formName'];
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

        return $model;
    }
}
