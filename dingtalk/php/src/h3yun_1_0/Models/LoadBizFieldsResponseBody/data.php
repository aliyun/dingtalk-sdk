<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\LoadBizFieldsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\LoadBizFieldsResponseBody\data\childForms;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\LoadBizFieldsResponseBody\data\fields;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var childForms[]
     */
    public $childForms;

    /**
     * @var fields[]
     */
    public $fields;

    /**
     * @example 客户管理
     *
     * @var string
     */
    public $formName;

    /**
     * @example D0001839bbbbe346bbf496498bb76c44c7eb972
     *
     * @var string
     */
    public $schemaCode;
    protected $_name = [
        'childForms' => 'childForms',
        'fields' => 'fields',
        'formName' => 'formName',
        'schemaCode' => 'schemaCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->childForms) {
            $res['childForms'] = [];
            if (null !== $this->childForms && \is_array($this->childForms)) {
                $n = 0;
                foreach ($this->childForms as $item) {
                    $res['childForms'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['childForms'])) {
            if (!empty($map['childForms'])) {
                $model->childForms = [];
                $n = 0;
                foreach ($map['childForms'] as $item) {
                    $model->childForms[$n++] = null !== $item ? childForms::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['fields'])) {
            if (!empty($map['fields'])) {
                $model->fields = [];
                $n = 0;
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
