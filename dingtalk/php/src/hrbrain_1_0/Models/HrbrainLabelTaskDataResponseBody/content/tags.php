<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainLabelTaskDataResponseBody\content;

use AlibabaCloud\Tea\Model;

class tags extends Model
{
    /**
     * @var string
     */
    public $code;

    /**
     * @var string
     */
    public $description;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string[]
     */
    public $values;
    protected $_name = [
        'code' => 'code',
        'description' => 'description',
        'name' => 'name',
        'values' => 'values',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->values) {
            $res['values'] = $this->values;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return tags
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['values'])) {
            if (!empty($map['values'])) {
                $model->values = $map['values'];
            }
        }

        return $model;
    }
}
