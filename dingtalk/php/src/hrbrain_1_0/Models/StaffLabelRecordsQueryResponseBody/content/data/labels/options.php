<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\StaffLabelRecordsQueryResponseBody\content\data\labels;

use AlibabaCloud\Tea\Model;

class options extends Model
{
    /**
     * @var string
     */
    public $label;

    /**
     * @var string
     */
    public $tip;

    /**
     * @var string
     */
    public $value;
    protected $_name = [
        'label' => 'label',
        'tip' => 'tip',
        'value' => 'value',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->label) {
            $res['label'] = $this->label;
        }
        if (null !== $this->tip) {
            $res['tip'] = $this->tip;
        }
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return options
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['label'])) {
            $model->label = $map['label'];
        }
        if (isset($map['tip'])) {
            $model->tip = $map['tip'];
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }

        return $model;
    }
}
