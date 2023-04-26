<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\LoadBizFieldsResponseBody\data;

use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\LoadBizFieldsResponseBody\data\childForms\fields;
use AlibabaCloud\Tea\Model;

class childForms extends Model
{
    /**
     * @var fields[]
     */
    public $fields;

    /**
     * @example 子表
     *
     * @var string
     */
    public $formName;

    /**
     * @example D000183Fcd15f3a51e624bbc9945392d190b6aa8
     *
     * @var string
     */
    public $schemaCode;
    protected $_name = [
        'fields'     => 'fields',
        'formName'   => 'formName',
        'schemaCode' => 'schemaCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fields) {
            $res['fields'] = [];
            if (null !== $this->fields && \is_array($this->fields)) {
                $n = 0;
                foreach ($this->fields as $item) {
                    $res['fields'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->formName) {
            $res['formName'] = $this->formName;
        }
        if (null !== $this->schemaCode) {
            $res['schemaCode'] = $this->schemaCode;
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
        if (isset($map['fields'])) {
            if (!empty($map['fields'])) {
                $model->fields = [];
                $n             = 0;
                foreach ($map['fields'] as $item) {
                    $model->fields[$n++] = null !== $item ? fields::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['formName'])) {
            $model->formName = $map['formName'];
        }
        if (isset($map['schemaCode'])) {
            $model->schemaCode = $map['schemaCode'];
        }

        return $model;
    }
}
